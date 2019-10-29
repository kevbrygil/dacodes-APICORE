set -e
dotnet tool install --global dotnet-ef
dotnet ef migrations add initial
dotnet ef database update