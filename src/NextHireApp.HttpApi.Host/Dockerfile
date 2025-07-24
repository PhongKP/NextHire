FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

COPY . .
COPY nuget.config ./
RUN dotnet restore "/host/FRT.MyBasseProject.HttpApi.Host/FRT.MyBasseProject.HttpApi.Host.csproj" --configfile nuget.config -nowarn:msb3202,nu1503 --force

RUN dotnet publish "/host/FRT.MyBasseProject.HttpApi.Host/FRT.MyBasseProject.HttpApi.Host.csproj" --no-restore -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV TZ=Asia/Ho_Chi_Minh
WORKDIR /app
COPY --from=build-env /out /app
ENTRYPOINT ["dotnet", "FRT.MyBasseProject.HttpApi.Host.dll"]
