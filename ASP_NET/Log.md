## Il Logging
In C#, il logging è il processo di registrazione di eventi, errori e messaggi informativi durante l'esecuzione di un'applicazione. Il framework moderno di riferimento è Microsoft.Extensions.Logging

Le principali categorie

#Trace	
Dettagli minimi (estremamente rumoroso)	"Ingresso nel metodo X con parametri Y"
Debug
#Informazioni 
utili durante lo sviluppo"Variabile temporanea impostata a 10"
#Information
Flusso normale dell'app	"Utente 'Mario' loggato con successo
#Warning
Eventi anomali ma non bloccanti	"Tentativo di login fallito (password errata)"
#Error
Eccezioni che interrompono un'operazione	"Impossibile connettersi al Database"
#Critical
Fallimento totale dell'app	"Memoria esaurita, il sistema si arresta"


## Come inviare un errore su schermo

```Csharp
public class ProdottiController : Controller
{
    private readonly ILogger<ProdottiController> _logger;

    // Il framework inietta automaticamente il logger
    public ProdottiController(ILogger<ProdottiController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Accesso alla lista prodotti alle {Time}", DateTime.Now);
        
        try {
            // Logica...
        }
        catch (Exception ex) {
            _logger.LogError(ex, "Errore durante il caricamento dei prodotti");
        }
        
        return View();
    }
}
```

Gli errori da visualizzare possono essere filtrati

```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning",
      "MyProject.Namespace": "Debug" 
    }
  }
}
```
