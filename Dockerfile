FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
EXPOSE 5002
COPY dacodes-APICORE.csproj .
RUN dotnet restore
#RUN dotnet tool install --global dotnet-ef
#RUN dotnet ef migrations add initial
#RUN dotnet ef database update
COPY . .
RUN dotnet publish -c release -o /app
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "dacodes-APICORE.dll"]

