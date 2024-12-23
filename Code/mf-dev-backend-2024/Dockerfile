# Imagem base para o runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagem base para o SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["mf-dev-backend-2024/mf-dev-backend-2024.csproj", "mf-dev-backend-2024/"]
RUN dotnet restore "./mf-dev-backend-2024/mf-dev-backend-2024.csproj" --no-cache
COPY . .
WORKDIR "/src/mf-dev-backend-2024"
RUN dotnet build "./mf-dev-backend-2024.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./mf-dev-backend-2024.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Fase final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mf-dev-backend-2024.dll"]
