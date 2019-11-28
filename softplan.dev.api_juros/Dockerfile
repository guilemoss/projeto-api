FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 6000

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["softplan.dev.api_juros/softplan.dev.api_juros.csproj", "softplan.dev.api_juros/"]
RUN dotnet restore "softplan.dev.api_juros/softplan.dev.api_juros.csproj"
COPY . .
WORKDIR "/src/softplan.dev.api_juros"
RUN dotnet build "softplan.dev.api_juros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "softplan.dev.api_juros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "softplan.dev.api_juros.dll"]