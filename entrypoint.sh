#!/bin/sh

# Wait until SQL Server is ready
until dotnet ef database update; do
  >&2 echo "SQL Server is starting up"
  sleep 1
done

# Start the application
exec dotnet NewsletterAPI.dll