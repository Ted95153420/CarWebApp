#!/bin/bash
# entrypoint.sh

# Set logging configuration
LOG_FILE=/var/log/entrypoint.log

# Start SQL Server
start_sql_server() {
  echo "Starting SQL Server..." >> $LOG_FILE
  /opt/mssql/bin/sqlservr &
}

# Wait for SQL Server to start
wait_for_sql_server() {
  local MAX_ATTEMPTS=30
  local ATTEMPT=0
  local SLEEP_TIME=10

  while [ "$ATTEMPT" -lt "$MAX_ATTEMPTS" ]; do
    sleep $SLEEP_TIME
    if sqlcmd -S localhost,1433 -U sa -P IL4veMiD0g! -Q "SELECT 1" &>/dev/null; then
      echo "SQL Server started successfully (Version: $(sqlcmd -S localhost,1433 -U sa -P IL4veMiD0g! -Q "SELECT @@VERSION" 2>&1))" >> $LOG_FILE
      return
    else
      ERROR_MESSAGE=$(sqlcmd -S localhost,1433 -U sa -P IL4veMiD0g! -Q "SELECT 1" 2>&1)
      echo "Attempt $ATTEMPT: SQL Server not yet started... Error: $ERROR_MESSAGE" >> $LOG_FILE
    fi
    ((ATTEMPT++))
  done

  echo "SQL Server failed to start within $MAX_ATTEMPTS attempts" >> $LOG_FILE
  exit 1
}

# Main execution
start_sql_server
wait_for_sql_server

# Optionally run Entity Framework migrations
#echo "Running Entity Framework migrations..." >> $LOG_FILE
#dotnet ef database update --project CarPriceComparison.csproj

# Optionally run setup script
#echo "Running setup script..." >> $LOG_FILE
#/opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -d master -i /usr/src/app/setup.sql -C

# Start the .NET application
#dotnet CarPriceComparison.dll