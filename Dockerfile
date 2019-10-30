FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
EXPOSE 5002

WORKDIR /src
COPY dacodes-APICORE.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "dacodes-APICORE.dll"]