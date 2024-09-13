#!/bin/bash
# entrypoint.sh

mv CarPriceComparison.csproj TESTCarPriceComparison.csproj
echo "Made it to entrypoint.sh" >> /proc/1/fd/1

echo "Entry point script started..." >> /proc/1/fd/1

# Start SQL Server
echo "Starting SQL Server..." >> /proc/1/fd/1
/opt/mssql/bin/sqlservr &

# Wait for SQL Server to start
echo "Waiting for SQL Server to start..." >> /proc/1/fd/1
sleep 30s

# Run Entity Framework migrations
echo "Running Entity Framework migrations..." >> /proc/1/fd/1
dotnet ef database update --project CarPriceComparison.csproj

mv CarPriceComparison.csproj TESTCarPriceComparison.csproj

echo "Running Entity Framework migrations..." >> /proc/1/fd/1

# Run the setup script
/opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -d master -i /usr/src/app/setup.sql -C

# Start the .NET application
dotnet CarPriceComparison.dll