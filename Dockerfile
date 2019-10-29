FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS builder
WORKDIR /src
COPY *.sln ./
COPY dacodes_APICORE/dacodes_APICORE.csproj dacodes_APICORE/
RUN dotnet restore
COPY . .
WORKDIR /src/dacodes_APICORE
RUN dotnet build -c Release -o /app

FROM builder AS publish
RUN dotnet publish -c Release -o /app

FROM base AS production
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dacodes_APICORE.dll"]

RUN chmod a+x ./run.sh
EXPOSE 5000
CMD ["./run.sh"]