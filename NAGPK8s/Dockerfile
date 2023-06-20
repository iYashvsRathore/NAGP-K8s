#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NAGPK8s/NAGPK8s.csproj", "NAGPK8s/"]
RUN dotnet restore "NAGPK8s/NAGPK8s.csproj"
COPY . .
WORKDIR "/src/NAGPK8s"
RUN dotnet build "NAGPK8s.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NAGPK8s.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NAGPK8s.dll"]