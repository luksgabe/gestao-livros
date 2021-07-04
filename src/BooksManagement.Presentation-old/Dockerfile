#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine
WORKDIR /app
EXPOSE 80

FROM murbanowicz/net-core-react-builder AS build
WORKDIR /src
COPY ["BooksManagement.Presentation/BooksManagement.Presentation.csproj", "BooksManagement.Presentation/"]
COPY ["BooksManagement.Infra.CrossCutting/BooksManagement.Infra.CrossCutting.csproj", "BooksManagement.Infra.CrossCutting/"]
COPY ["BooksManagement.Infra.Data/BooksManagement.Infra.Data.csproj", "BooksManagement.Infra.Data/"]
COPY ["BooksManagement.Domain/BooksManagement.Domain.csproj", "BooksManagement.Domain/"]
COPY ["BooksManagement.App/BooksManagement.App.csproj", "BooksManagement.App/"]
RUN dotnet restore "BooksManagement.Presentation/BooksManagement.Presentation.csproj"
COPY . .
WORKDIR "/src/BooksManagement.Presentation"
RUN dotnet build "BooksManagement.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BooksManagement.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BooksManagement.Presentation.dll"]