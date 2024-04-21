#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
WORKDIR /src
COPY ["CarteiraDigital/CarteiraDigital.csproj", "CarteiraDigital/"]
RUN dotnet restore "CarteiraDigital/CarteiraDigital.csproj"
COPY . .
WORKDIR "/src/CarteiraDigital"
RUN dotnet build "CarteiraDigital.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarteiraDigital.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarteiraDigital.dll"]