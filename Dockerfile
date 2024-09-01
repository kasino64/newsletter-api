FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NewsletterApi.csproj", "."]
RUN dotnet restore "./NewsletterApi.csproj"
COPY . .

WORKDIR "/src/."
RUN dotnet build "NewsletterApi.csproj" -c Release -o /app/build

#RUN dotnet tool install --global dotnet-ef --version 7.0.20
#ENV PATH="$PATH:/root/.dotnet/tools"
#RUN dotnet ef database update

FROM build AS publish
RUN dotnet publish "NewsletterApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NewsletterApi.dll"]