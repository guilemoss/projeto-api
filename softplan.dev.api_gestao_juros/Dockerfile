FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["softplan.dev.api_gestao_juros/softplan.dev.api_gestao_juros.csproj", "softplan.dev.api_gestao_juros/"]
RUN dotnet restore "softplan.dev.api_gestao_juros/softplan.dev.api_gestao_juros.csproj"
COPY . .
WORKDIR "/src/softplan.dev.api_gestao_juros"
RUN dotnet build "softplan.dev.api_gestao_juros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "softplan.dev.api_gestao_juros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "softplan.dev.api_gestao_juros.dll"]