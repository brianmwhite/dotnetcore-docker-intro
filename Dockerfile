FROM microsoft/aspnetcore-build:2.0.2 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/aspnetcore:2.0.0
WORKDIR /app
COPY --from=build-env /app/out .
# ENTRYPOINT ["dotnet", "d101.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet d101.dll
