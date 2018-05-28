FROM microsoft/dotnet
EXPOSE 5000

WORKDIR /app
COPY Services.csproj /app
COPY Services.sln /app
RUN dotnet restore

COPY . /app

ENTRYPOINT ["dotnet", "run"]