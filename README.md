# API1
## API para retorno do valor do metro quadrado.


### Docker config:

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /app
COPY ./ ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim
WORKDIR /app
COPY --from=build /app/out .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet API1Core.dll

### Passo a passo para deploy no Heroku:

-docker build -t api1-gmanzini .

-heroku login

-heroku container:login

-docker tag api1-gmanzini registry.heroku.com/api1-gmanzini/web

-heroku container:push web -a api1-gmanzini

-heroku container:release web -a api1-gmanzini

-https://api1-gmanzini.herokuapp.com/swagger/index.html
