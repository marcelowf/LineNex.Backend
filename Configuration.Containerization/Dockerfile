FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Packages.props", "."]
COPY ["Directory.Build.props", "."]
COPY ["nuget.config", "."]
COPY ["LineNex.Api/LineNex.Api.csproj", "LineNex.Api/"]
COPY ["LineNex.Infrastructure/LineNex.Infrastructure.csproj", "LineNex.Infrastructure/"]
COPY ["LineNex.Application/LineNex.Application.csproj", "LineNex.Application/"]
COPY ["LineNex.Service/LineNex.Service.csproj", "LineNex.Service/"]
COPY ["LineNex.Domain/LineNex.Domain.csproj", "LineNex.Domain/"]
COPY ["LineNex.Core/LineNex.Core.csproj", "LineNex.Core/"]
COPY ["LineNex.Specification/LineNex.Specification.csproj", "LineNex.Specification/"]
RUN dotnet restore "./LineNex.Api/LineNex.Api.csproj"
COPY . .
WORKDIR "/src/LineNex.Api"
RUN dotnet build "./LineNex.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./LineNex.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LineNex.Api.dll"]