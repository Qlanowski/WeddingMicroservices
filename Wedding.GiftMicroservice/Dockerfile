FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Wedding.GiftMicroservice/Wedding.GiftMicroservice.csproj", "Wedding.GiftMicroservice/"]
RUN dotnet restore "Wedding.GiftMicroservice/Wedding.GiftMicroservice.csproj"
COPY . .
WORKDIR "/src/Wedding.GiftMicroservice"
RUN dotnet build "Wedding.GiftMicroservice.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Wedding.GiftMicroservice.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Wedding.GiftMicroservice.dll"]