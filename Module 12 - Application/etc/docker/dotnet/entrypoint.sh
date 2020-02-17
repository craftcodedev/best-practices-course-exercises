#!/bin/bash

set -e
run_cmd="dotnet watch run"

#until dotnet ef database update; do
#>&2 echo "SQL Server is starting up"
#sleep 1
#done

exec "ls"

exec dotnet --help