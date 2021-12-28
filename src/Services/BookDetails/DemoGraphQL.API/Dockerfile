#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/BookDetails/DemoGraphQL.API/DemoGraphQL.API.csproj", "Services/BookDetails/DemoGraphQL.API/"]
COPY ["Services/BookDetails/DemoGraphQL.Infrastructure/DemoGraphQL.Infrastructure.csproj", "Services/BookDetails/DemoGraphQL.Infrastructure/"]
COPY ["Services/BookDetails/DemoGraphQL.Abstraction/DemoGraphQL.Abstraction.csproj", "Services/BookDetails/DemoGraphQL.Abstraction/"]
COPY ["Services/BookDetails/DemoGraphQL.Core/DemoGraphQL.Core.csproj", "Services/BookDetails/DemoGraphQL.Core/"]
RUN dotnet restore "Services/BookDetails/DemoGraphQL.API/DemoGraphQL.API.csproj"
COPY . .
WORKDIR "/src/Services/BookDetails/DemoGraphQL.API"
RUN dotnet build "DemoGraphQL.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoGraphQL.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoGraphQL.API.dll"]
