FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /app
COPY ["BooksManagement/BooksManagement.Presentation/BooksManagement.Presentation.csproj", "BooksManagement/BooksManagement.Presentation/"]
RUN dotnet restore "BooksManagement/BooksManagement.Presentation/BooksManagement.Presentation.csproj"
COPY . .
WORKDIR "/src/BooksManagement/BooksManagement.Presentation"
RUN dotnet build "BooksManagement.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BooksManagement.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BooksManagement.Presentation.dll"]