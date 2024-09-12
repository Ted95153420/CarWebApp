# Use the official .NET image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000


RUN apt-get update && apt-get install -y libgssapi-krb5-2

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CarPriceComparison.csproj", "./"]
RUN dotnet restore "CarPriceComparison.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "CarPriceComparison.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "CarPriceComparison.csproj" -c Release -o /app/publish

# Use the base image to run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

#Install dotnet-ef tool
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

# Copy the setup script and entrypoint script
COPY setup.sql /usr/src/app/setup.sql
COPY entrypoint.sh /usr/src/app/entrypoint.sh
RUN chmod +x /usr/src/app/entrypoint.sh

#Set the entry point
ENTRYPOINT ["/usr/src/app/entrypoint.sh"]