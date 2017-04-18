.PHONY: all

RESOURCE_GROUP=play-azure-ad

install:
	pip install azure-cli

login:
	start "" https://aka.ms/devicelogin
	az login

group:
	az resource group create -n $(RESOURCE_GROUP) -l "West Europe"

destroy:
	az group deployment create -m complete -f purge.json $(RESOURCE_GROUP) default


