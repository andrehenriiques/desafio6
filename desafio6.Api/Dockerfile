#Nhelper Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

#COPY *.csproj
COPY ["desafio6.Domain/desafio6.Domain.csproj", "desafio6.Domain/"]
COPY ["desafio6.IoC/desafio6.IoC.csproj", "desafio6.IoC/"]
COPY ["desafio6.Data/desafio6.Data.csproj", "desafio6.Data/"]
COPY ["desafio6.Api/desafio6.Api.csproj", "desafio6.Api/"]
COPY ["desafio6.Data.Mongo/desafio6.Data.Mongo.csproj", "desafio6.Data.Mongo/"]
COPY ["desafio6.Tests/desafio6.Tests.csproj", "desafio6.Tests/"]
COPY ["desafio6.Application/desafio6.Application.csproj", "desafio6.Application/"]

RUN dotnet restore "./desafio6.Api/desafio6.Api.csproj"

COPY . .
WORKDIR "/src/desafio6.Api"
RUN dotnet publish "./desafio6.Api.csproj" -c "$BUILD_CONFIGURATION" -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0-jammy-chiseled AS final
WORKDIR /app
EXPOSE 8080

ENV TZ=America/Sao_Paulo \
    ASPNETCORE_URLS=http://*:8080

COPY --from=build /app/publish .

USER app

ENTRYPOINT ["dotnet", "desafio6.Api.dll"]
