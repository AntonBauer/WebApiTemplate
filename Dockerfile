FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

COPY *.sln .
COPY ./WebApiTemplate.Application/*.csproj ./WebApiTemplate.Application/
COPY ./WebApiTemplate.WebApi/*.csproj ./WebApiTemplate.WebApi/
RUN dotnet restore

COPY . .
RUN dotnet publish -c release -o app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /source/app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "WebApiTemplate.WebApi.dll"]