#!/bin/bash
# entrypoint.sh


echo "Made it to entrypoint.sh" >> /proc/1/fd/1

echo "Entry point script started..." >> /proc/1/fd/1

# Start SQL Server
echo "Starting SQL Server..." >> /proc/1/fd/1
/opt/mssql/bin/sqlservr &

# Wait for SQL Server to start
echo "Waiting for SQL Server to start..." >> /proc/1/fd/1
MAX_ATTEMPTS = 20
ATTEMPT = 0
while [ $ATTEMPT -lt $MAX_ATTEMPTS ]; do
  sleep 3s
  if sqlcmd -S localhost,1433 -U sa -P IL4veMiD0g! -Q "SELECT 1" &>/dev/null; then
    echo "SQL Server started successfully" >> /proc/1/fd/1
    break
  fi
  ((ATTEMPT++))
  echo "Attempt $ATTEMPT: SQL Server not yet started..." >> /proc/1/fd/1
done
echo "sql server started"

if [ $ATTEMPT -eq $MAX_ATTEMPTS ]; then
  echo "SQL Server failed to start within $MAX_ATTEMPTS attempts" >> /proc/1/fd/1
  exit 1
fi

# Keep the container running
#tail -f /dev/null

# Run Entity Framework migrations
#echo "Running Entity Framework migrations..." >> /proc/1/fd/1
#dotnet ef database update --project CarPriceComparison.csproj

#echo "***** FINISHED RUNNING ENTITY FRAMEWORK MIGRATIONS. *****" >> /proc/1/fd/1

# Run the setup script
#/opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -d master -i /usr/src/app/setup.sql -C

# Start the .NET application
#dotnet CarPriceComparison.dll