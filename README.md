## Create App
`dotnet new webapi -minimal -o MAPI`

## Add SSL Cert
`dotnet dev-certs https --trust`

## Run an app with https profile in launchSettings
## OR Change the order of profile
`dotnet run --launch-profile "https"`

## Test app using swagger url
`https://localhost:7283/swagger/index.html`

## Build an app after changes
`dotnet build`
