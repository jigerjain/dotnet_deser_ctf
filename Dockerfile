FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY DotNet_Deserialization/*.csproj ./DotNet_Deserialization/
RUN dotnet restore


# copy everything and build app
COPY DotNet_Deserialization/. ./DotNet_Deserialization/
WORKDIR /app/DotNet_Deserialization
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
RUN apt-get update && apt-get install curl
WORKDIR /app
COPY --from=build /app/DotNet_Deserialization/out ./
COPY flag.sh .
COPY flag.txt /flag.txt
EXPOSE 80
ENTRYPOINT ["dotnet", "DotNet_Deserialization.dll"]
