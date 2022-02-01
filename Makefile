SHELL = /bin/bash -e

.PHONY: build
build:
	docker build -t swagger-cli -f Dockerfile.swagger-cli .
	docker build -t autorest-dotnetcore -f Dockerfile.autorest .

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
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 validate \
		--input-spec /workspace/cds_energy.json

.PHONY: openapi-generator-validate-common
openapi-generator-validate-common:
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 validate \
		--input-spec /workspace/cds_common.json

.PHONY: openapi-generator-validate-admin
openapi-generator-validate-admin:
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 validate \
		--input-spec /workspace/cds_admin.json

.PHONY: autorest-energy
autorest-energy:
	mkdir -p autorest/energy/.autorest
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore autorest/energy.yaml | tee autorest/energy/.autorest/LOG

.PHONY: autorest-common
autorest-common:
	mkdir -p autorest/common/.autorest
	docker run --rm \
    	-v $$(pwd):/workspace \
    	-t autorest-dotnetcore autorest/common.yaml | tee autorest/common/.autorest/LOG

.PHONY: autorest-admin
autorest-admin:
	mkdir -p autorest/admin/.autorest
	docker run --rm \
		-v $$(pwd):/workspace \
		-t autorest-dotnetcore autorest/admin.yaml | tee autorest/admin/.autorest/LOG

.PHONY: openapi-generator-admin
openapi-generator-admin:
	mkdir -p openapi-generator/aspnetcore/admin/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 generate \
		--config /workspace/openapi-generator/aspnetcore/admin.yaml --output /workspace/openapi-generator/aspnetcore/admin | tee openapi-generator/aspnetcore/admin/.openapi-generator/LOG

.PHONY: openapi-generator-admin-functions
openapi-generator-admin-functions:
	mkdir -p openapi-generator/functions/admin/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 generate \
		--config /workspace/openapi-generator/functions/admin.yaml --output /workspace/openapi-generator/functions/admin | tee openapi-generator/functions/admin/.openapi-generator/LOG

.PHONY: openapi-generator-common
openapi-generator-common:
	mkdir -p openapi-generator/aspnetcore/common/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 generate \
		--config /workspace/openapi-generator/aspnetcore/common.yaml --output /workspace/openapi-generator/aspnetcore/common | tee openapi-generator/aspnetcore/common/.openapi-generator/LOG

.PHONY: openapi-generator-common-functions
openapi-generator-common-functions:
	mkdir -p openapi-generator/functions/common/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 generate \
		--config /workspace/openapi-generator/functions/common.yaml --output /workspace/openapi-generator/functions/common | tee openapi-generator/functions/common/.openapi-generator/LOG

.PHONY: openapi-generator-energy
openapi-generator-energy:
	mkdir -p openapi-generator/aspnetcore/energy/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 generate \
		--config /workspace/openapi-generator/aspnetcore/energy.yaml --output /workspace/openapi-generator/aspnetcore/energy | tee openapi-generator/aspnetcore/energy/.openapi-generator/LOG

.PHONY: openapi-generator-energy-functions
openapi-generator-energy-functions:
	mkdir -p openapi-generator/functions/energy/.openapi-generator
	docker run --rm -v "$$(pwd):/workspace" openapitools/openapi-generator-cli:v5.3.1 generate \
		--config /workspace/openapi-generator/functions/energy.yaml --output /workspace/openapi-generator/functions/energy | tee openapi-generator/functions/energy/.openapi-generator/LOG
