#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk AS build
WORKDIR /src
COPY ["cheapawesome/", "cheapawesome/"]
RUN dotnet restore "cheapawesome/cheapawesome.csproj"
RUN dotnet build "cheapawesome/cheapawesome.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cheapawesome/cheapawesome.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cheapawesome.dll"]