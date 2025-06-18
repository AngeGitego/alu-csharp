#!/usr/bin/env bash

# Set project directory name
PROJECT_DIR="1-new_project"

# Create the new C# project
dotnet new console -o "$PROJECT_DIR"

# Navigate into the project directory
cd "$PROJECT_DIR" || exit 1

# Restore dependencies
dotnet restore

# Build the project
dotnet build
