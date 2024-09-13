# Use the official .NET image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .  
RUN dotnet restore "CarPriceComparison.csproj"
RUN dotnet build "CarPriceComparison.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "CarPriceComparison.csproj" -c Release -o /app/publish

# Use the base image to run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

#Set the entry point
ENTRYPOINT ["dotnet", "CarPriceComparison.dll"]