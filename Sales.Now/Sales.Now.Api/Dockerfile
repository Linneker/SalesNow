FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Sales.Now.Api/Sales.Now.Api.csproj", "Sales.Now.Api/"]

RUN dotnet restore "Sales.Now.Api/Sales.Now.Api.csproj"
COPY . .
WORKDIR "/src/Sales.Now.Api"
RUN dotnet build "Sales.Now.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sales.Now.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sales.Now.Api.dll"]