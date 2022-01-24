SHELL = /bin/bash -e

.PHONY: all
all: build autorest

.PHONY: build
build:
	docker build -t swagger-cli -f Dockerfile.swagger-cli .
	docker build -t autorest-dotnetcore -f Dockerfile.autorest .

.PHONY: validate
validate: swagger-cli-validate-energy swagger-cli-validate-common swagger-cli-validate-admin

.PHONY: swagger-cli-validate-energy
swagger-cli-validate-energy:
	docker run --rm \
		-v $$(pwd):/workspace \
		-t swagger-cli validate /workspace/cds_energy.json

.PHONY: swagger-cli-validate-common
swagger-cli-validate-common:
	docker run --rm \
		-v $$(pwd):/workspace \
		-t swagger-cli validate /workspace/cds_common.json

.PHONY: swagger-cli-validate-admin
swagger-cli-validate-admin:
	docker run --rm \
		-v $$(pwd):/workspace \
		-t swagger-cli validate /workspace/cds_admin.json

.PHONY: autorest
autorest: autorest-energy autorest-common autorest-admin

.PHONY: autorest-energy
autorest-energy:
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore --input-file:/workspace/cds_energy.json --namespace:Agl.Cdr.Energy --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/energy --no-namespace-folders:true --verbose

.PHONY: autorest-common
autorest-common:
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore --input-file:/workspace/cds_common.json --namespace:Agl.Cdr.Common --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/common --no-namespace-folders:true --verbose

.PHONY: autorest-admin
autorest-admin:
	docker run --rm \
		-v $$(pwd):/workspace \
		-t autorest-dotnetcore --input-file:/workspace/cds_admin.json --namespace:Agl.Cdr.Admin --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/admin --no-namespace-folders:true --verbose

