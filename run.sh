#!/bin/bash

cd ./ConsoleApp/

echo "Building the project..."
dotnet build || { echo "Build failed!"; exit 1; }

echo "Running the project..."
dotnet run
