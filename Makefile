SHELL = /bin/bash -e

.PHONY: all
all: build autorest

.PHONY: build
build:
	docker build -t swagger-cli -f Dockerfile.swagger-cli .
	docker build -t autorest-dotnetcore -f Dockerfile.autorest .

.PHONY: validate
validate: swagger-cli-validate-energy swagger-cli-validate-common swagger-cli-validate-admin openapi-generator-validate-energy openapi-generator-validate-common openapi-generator-validate-admin

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

.PHONY: openapi-generator-validate-energy
openapi-generator-validate-energy:
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli validate \
		--input-spec /workspace/cds_energy.json

.PHONY: openapi-generator-validate-common
openapi-generator-validate-common:
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli validate \
		--input-spec /workspace/cds_common.json

.PHONY: openapi-generator-validate-admin
openapi-generator-validate-admin:
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli validate \
		--input-spec /workspace/cds_admin.json

.PHONY: autorest
autorest: autorest-energy autorest-common autorest-admin

.PHONY: autorest-energy
autorest-energy:
	mkdir -p autorest/energy/.autorest
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore --input-file:/workspace/cds_energy.json --namespace:Agl.Cdr.Energy --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/energy --verbose | tee autorest/energy/.autorest/LOG

.PHONY: autorest-common
autorest-common:
	mkdir -p autorest/common/.autorest
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore --input-file:/workspace/cds_common.json --namespace:Agl.Cdr.Common --azure-functions-csharp --generate-metadata:false --output-folder:/workspace/autorest/common --verbose | tee autorest/common/.autorest/LOG

.PHONY: autorest-admin
autorest-admin:
	mkdir -p autorest/admin/.autorest
	docker run --rm \
		-v $$(pwd):/workspace \
		-t autorest-dotnetcore autorest/admin.yaml --debug

.PHONY: openapi-generator
openapi-generator: openapi-generator-energy

.PHONY: openapi-generator-energy
openapi-generator-energy:
	mkdir -p openapi-generator/energy/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli generate \
		--input-spec /workspace/cds_energy.json \
		--generator-name csharp-netcore-functions \
		--model-package Agl.Cdr.Energy \
		--output /workspace/openapi-generator/energy | tee openapi-generator/energy/.openapi-generator/LOG
