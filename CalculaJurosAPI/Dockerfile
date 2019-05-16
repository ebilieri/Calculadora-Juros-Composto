FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["CalculaJurosAPI/CalculaJurosAPI.csproj", "CalculaJurosAPI/"]
COPY ["CalculaJuros.Models/CalculaJuros.Models.csproj", "CalculaJuros.Models/"]
COPY ["CalculaJuros.Services/CalculaJuros.Services.csproj", "CalculaJuros.Services/"]
RUN dotnet restore "CalculaJurosAPI/CalculaJurosAPI.csproj"
COPY . .
WORKDIR "/src/CalculaJurosAPI"
RUN dotnet build "CalculaJurosAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalculaJurosAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalculaJurosAPI.dll"]