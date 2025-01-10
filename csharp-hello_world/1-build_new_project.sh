#!/usr/bin/env bash

# Create the folder for the new project
mkdir -p 1-new_project

# Navigate to the new project folder
cd 1-new_project || exit

# Initialize a new C# Console Application
dotnet new console

# Build the project
dotnet build
