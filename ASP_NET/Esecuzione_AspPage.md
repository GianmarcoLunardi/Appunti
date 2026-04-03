Le Pagine possono asp.net possono essere eseguite in più modalità
Modalità 
IIS
Kastrol un file esecuibile multipiattaforma
Docker
Kastet http, https

Le modalità vengono definite nel file _\Properties\launchSettings.json_
Ogni profilo gestisce un ambiente diverso

```JSON
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"   // valori Development, Staging, Production
        "ASPNETCORE_URLS": "https://localhost:7000;http://localhost:5000",
        "MIA_CHIAVE_CONFIG": "ValoreSegreto123"
      }
```

