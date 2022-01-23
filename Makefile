SHELL = /bin/bash -e

.PHONY: all
all: build autorest

.PHONY: build
build:
	docker build -t swagger-cli -f Dockerfile.swagger-cli .
	docker build -t autorest-dotnetcore -f Dockerfile.autorest .

.PHONY: validate
validate:
	docker run --rm \
		-v $$(pwd):/workspace \
		-t swagger-cli validate /workspace/cds_energy.json
	docker run --rm \
		-v $$(pwd):/workspace \
		-t swagger-cli validate /workspace/cds_common.json
	docker run --rm \
		-v $$(pwd):/workspace \
		-t swagger-cli validate /workspace/cds_admin.json

.PHONY: autorest
autorest:
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore --input-file:/workspace/cds_energy.json --namespace:Agl.Cdr.Energy --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/energy
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore --input-file:/workspace/cds_common.json --namespace:Agl.Cdr.Common --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/common
	docker run --rm \
		-v $$(pwd):/workspace \
		-t autorest-dotnetcore --input-file:/workspace/cds_admin.json --namespace:Agl.Cdr.Admin --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/admin
