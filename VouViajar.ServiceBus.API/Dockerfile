#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["VouViajar.ServiceBus.API/VouViajar.ServiceBus.API.csproj", "VouViajar.ServiceBus.API/"]
COPY ["VouViajar.Modulos.Eventos/VouViajar.Modulos.Eventos.csproj", "VouViajar.Modulos.Eventos/"]
COPY ["VouViajar.Modulos.Usuario/VouViajar.Modulos.Usuarios.csproj", "VouViajar.Modulos.Usuario/"]
RUN dotnet restore "VouViajar.ServiceBus.API/VouViajar.ServiceBus.API.csproj"
COPY . .
WORKDIR "/src/VouViajar.ServiceBus.API"
RUN dotnet build "VouViajar.ServiceBus.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VouViajar.ServiceBus.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VouViajar.ServiceBus.API.dll"]