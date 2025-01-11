#!/bin/bash

# Create a new C# console application project in the 2-new_project folder
dotnet new console -n 2-new_project

# Navigate into the project folder
cd 2-new_project

# Restore project dependencies
dotnet restore

# Build the project
dotnet build

# Run the project
dotnet run
