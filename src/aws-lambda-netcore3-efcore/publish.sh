#!/bin/bash
RUNTIME=$1

echo $1
dotnet restore
dotnet publish -r $RUNTIME -c Release