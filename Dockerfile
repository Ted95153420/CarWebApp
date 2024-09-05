
 # Use the official .NET Core SDK image as a base
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

COPY *.csproj ./


# Restore NuGet packages
RUN dotnet restore

# Copy the remaining files into the container
COPY . .

# Build the project
RUN dotnet build -c Release

CMD ["dotnet", "run", "&&", "tail", "-f", "/dev/null"]