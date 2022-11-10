#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY MaintenanceCheckinCheckout.sln ./
COPY ["MaintenanceAdapter.API/MaintenanceAdapter.API.csproj", "MaintenanceAdapter.API/"]
COPY ["MaintenanceAdapter.Application/MaintenanceAdapter.Application.csproj", "MaintenanceAdapter.Application/"]
COPY ["MaintenanceAdapter.Domain/MaintenanceAdapter.Domain.csproj", "MaintenanceAdapter.Domain/"]
COPY ["MaintenanceAdapter.Infra.IoC/MaintenanceAdapter.Infra.IoC.csproj", "MaintenanceAdapter.Infra.IoC/"]
COPY ["MaintenanceAdapter.Infra/MaintenanceAdapter.Infra.csproj", "MaintenanceAdapter.Infra/"]
RUN dotnet restore "MaintenanceAdapter.API/MaintenanceAdapter.API.csproj"
COPY . .
WORKDIR "/src/MaintenanceAdapter.API"
RUN dotnet build "MaintenanceAdapter.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MaintenanceAdapter.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MaintenanceAdapter.API.dll"]