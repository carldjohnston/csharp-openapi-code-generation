#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/Agl.Cdr.Energy/Agl.Cdr.Energy.csproj", "Agl.Cdr.Energy/"]

# NuGet restore
RUN dotnet restore "Agl.Cdr.Energy/Agl.Cdr.Energy.csproj"
COPY ["src/Agl.Cdr.Energy/", "Agl.Cdr.Energy/"]

# Build the API
WORKDIR "Agl.Cdr.Energy"
RUN dotnet build "Agl.Cdr.Energy.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "Agl.Cdr.Energy.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Agl.Cdr.Energy.dll"]
