#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/LoanDetails/DemoGraphQLTest.API/DemoGraphQLTest.API.csproj", "Services/LoanDetails/DemoGraphQLTest.API/"]
COPY ["Services/LoanDetails/DemoGraphQLTest.Infrastructure/DemoGraphQLTest.Infrastructure.csproj", "Services/LoanDetails/DemoGraphQLTest.Infrastructure/"]
COPY ["Services/LoanDetails/DemoGraphQLTest.Abstraction/DemoGraphQLTest.Abstraction.csproj", "Services/LoanDetails/DemoGraphQLTest.Abstraction/"]
COPY ["Services/LoanDetails/DemoGraphQLTest.Core/DemoGraphQLTest.Core.csproj", "Services/LoanDetails/DemoGraphQLTest.Core/"]
RUN dotnet restore "Services/LoanDetails/DemoGraphQLTest.API/DemoGraphQLTest.API.csproj"
COPY . .
WORKDIR "/src/Services/LoanDetails/DemoGraphQLTest.API"
RUN dotnet build "DemoGraphQLTest.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoGraphQLTest.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoGraphQLTest.API.dll"]
