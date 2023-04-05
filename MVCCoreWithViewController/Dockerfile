#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#---------------------------------NOTE------------------------------------------
# open cmd in solution folder and run: docker build -t <<imagename>> -f ProjectDir/Dockerfile .

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MVCCoreWithViewController/MVCCoreWithViewController.csproj", "MVCCoreWithViewController/"]
RUN dotnet restore "MVCCoreWithViewController/MVCCoreWithViewController.csproj"
COPY . .
WORKDIR "/src/MVCCoreWithViewController"
RUN dotnet build "MVCCoreWithViewController.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVCCoreWithViewController.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVCCoreWithViewController.dll"]