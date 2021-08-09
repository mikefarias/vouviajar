#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Vouviajar.API.Autenticacao/Vouviajar.API.Autenticacao.csproj", "Vouviajar.API.Autenticacao/"]
RUN dotnet restore "Vouviajar.API.Autenticacao/Vouviajar.API.Autenticacao.csproj"
COPY . .
WORKDIR "/src/Vouviajar.API.Autenticacao"
RUN dotnet build "Vouviajar.API.Autenticacao.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vouviajar.API.Autenticacao.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vouviajar.API.Autenticacao.dll"]