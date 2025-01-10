#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project || exit
dotnet new console
echo "The template \"Console Application\" was created successfully."
dotnet build
