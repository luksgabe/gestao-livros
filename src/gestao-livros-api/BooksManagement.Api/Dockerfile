#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
RUN apt-get update && apt-get install -y locales tzdata
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["BooksManagement.Api/BooksManagement.Api.csproj", "BooksManagement.Api/"]
COPY ["BooksManagement.Infra.CrossCutting/BooksManagement.Infra.CrossCutting.csproj", "BooksManagement.Infra.CrossCutting/"]
COPY ["BooksManagement.Infra.Data/BooksManagement.Infra.Data.csproj", "BooksManagement.Infra.Data/"]
COPY ["BooksManagement.Domain/BooksManagement.Domain.csproj", "BooksManagement.Domain/"]
COPY ["BooksManagement.App/BooksManagement.App.csproj", "BooksManagement.App/"]
RUN dotnet restore "BooksManagement.Api/BooksManagement.Api.csproj"
COPY . .
WORKDIR "/src/BooksManagement.Api"
RUN dotnet build "BooksManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BooksManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
ENV TZ=America/Sao_Paulo
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BooksManagement.Api.dll"]