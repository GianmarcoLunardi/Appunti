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
Dopo aver configurato l a amibiente di lavor ci sisposta sul file appsetting.json che contine
i paramenti di configurazione globali come Connestion string ecc..

in un primo momento vengono caricate le impostazioni di base appsetting.json
poi vengono varicate quelle specifiche allo stato del codice
```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  
  "ConnectionStrings": {
    "DefaultConnection": "Server=MioServer;Database=MioDB;Trusted_Connection=True;"
  },
  
  "ConfigurazioneEmail": {
    "SmtpServer": "smtp.esempio.com",
    "Porta": 587,
    "AbilitaSsl": true
  }
}
```
Poi vengono considerati i casi specifici nei files
appsettings.json (Le impostazioni di base, valide per tutti)
appsettings.Development.json (Impostazioni usate solo mentre stai programmando sul tuo PC)
appsettings.Production.json (Impostazioni usate quando il sito è pubblicato online)

# lettura del valore delle configurazioni 

```CSharp
public class HomeController : Controller
{
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        // Recupera il valore usando i due punti (:) per scendere nella gerarchia JSON
        string smtp = _configuration["ConfigurazioneEmail:SmtpServer"];
        
        return View();
    }
}
```
