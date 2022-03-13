#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["lochmalloch.com/lochmalloch.com.csproj", "lochmalloch.com/"]
RUN dotnet restore "lochmalloch.com/lochmalloch.com.csproj"
COPY . .
WORKDIR "/src/lochmalloch.com"
RUN dotnet build "lochmalloch.com.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lochmalloch.com.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lochmalloch.com.dll"]