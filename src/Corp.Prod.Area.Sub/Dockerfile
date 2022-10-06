#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:6.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:6.0-buster AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/Corp.Prod.Area.Sub/Corp.Prod.Area.Sub.csproj", "Corp.Prod.Area.Sub/"]

# NuGet restore
RUN dotnet restore "Corp.Prod.Area.Sub/Corp.Prod.Area.Sub.csproj"
COPY ["src/Corp.Prod.Area.Sub/", "Corp.Prod.Area.Sub/"]

# Build the API
WORKDIR "Corp.Prod.Area.Sub"
RUN dotnet build "Corp.Prod.Area.Sub.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "Corp.Prod.Area.Sub.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Corp.Prod.Area.Sub.dll"]
