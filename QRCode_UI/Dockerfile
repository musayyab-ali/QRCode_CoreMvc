# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Restore dependencies
COPY *.sln ./
COPY QRCode_UI/*.csproj ./QRCode_UI/
RUN dotnet restore

# Build and publish the application
COPY . ./
WORKDIR /app/QRCode_UI
RUN dotnet publish -c Release -o /out

# Stage 2: Run the application
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build-env /out .

# Expose the ports used by the application
EXPOSE 5000
EXPOSE 5001

# Configure the application to listen on all network interfaces
ENV ASPNETCORE_URLS="http://0.0.0.0:5000;http://0.0.0.0:5001"

# Run the application
ENTRYPOINT ["dotnet", "QRCode_UI.dll"]
