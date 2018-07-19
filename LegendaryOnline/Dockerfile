FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 51658
EXPOSE 44323

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY LegendaryOnline/LegendaryOnline.csproj LegendaryOnline/
RUN dotnet restore LegendaryOnline/LegendaryOnline.csproj
COPY . .
WORKDIR /src/LegendaryOnline
RUN dotnet build LegendaryOnline.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish LegendaryOnline.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LegendaryOnline.dll"]
