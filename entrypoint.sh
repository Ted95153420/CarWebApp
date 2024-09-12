#!/bin/bash
# entrypoint.sh

# Start SQL Server
/opt/mssql/bin/sqlservr &

# Wait for SQL Server to start
sleep 30s

# Run Entity Framework migrations
dotnet ef database update --project /app/CarPriceComparison.csproj

# Run the setup script
/opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -d master -i /usr/src/app/setup.sql -C

# Start the .NET application
dotnet CarPriceComparison.dll