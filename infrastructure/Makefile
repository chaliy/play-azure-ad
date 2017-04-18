.PHONY: all

TENANT?=play-azure-ad

install:
	pip install azure-cli

login:
	start "" https://aka.ms/devicelogin
	az login

group-list
	az ad group list