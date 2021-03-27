FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

COPY . .
RUN dotnet publish -c release -o app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /source/app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "WebApiTemplate.WebApi.dll"]