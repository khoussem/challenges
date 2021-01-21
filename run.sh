#!/bin/sh

dotnet build /p:StartupObject=challenges.$1.Solution
cat $1/input.txt | dotnet run --no-restore --no-build