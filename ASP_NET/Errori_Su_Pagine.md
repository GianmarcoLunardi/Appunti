## Gestione degli errori co interfaccia IExceptionHandler
L interfaccia definisce una classe che gestisce tutte le eccezioni.
Quando si verifica una eccezione viene consultato il log, il quale fornisce altri dettagli sull errore.

configurazione del Middleware
C#
```Csharp
var builder = WebApplication.CreateBuilder(args);

// Aggiungi i servizi necessari
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails(); // Genera risposte standard RFC 7807

var app = builder.Build();

// ATTENZIONE: Questo middleware deve essere chiamato per attivare gli handler registrati
app.UseExceptionHandler(); 
app.MapGet("/", () => { throw new Exception("Boom!"); });
app.Run();
```
Poi guardre il manuale

## Gestione errori sulle pagine.
Durante l esecuzione di una pagina web si scatena un eccezione o un orrere in generale
Ci spostiamo in una pagina che segnala all utente il tipo di errore 

launchSettings.json
Dichiarazione dello stato delle variabili di ambiente 

```JSON
{
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"  // <-- SETTATA QUI
      }
    }
  }
}
```
Midlewere
Program.cs
Controlla lo stato lo stato in cui viene eseguito codice
Nel caso sia stata lanciata un eccezione , essa viene gestita dalla Action Error . in Home Controller
```Csharp

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Mostra la "Yellow Screen of Death" con stack trace completo
    app.UseDeveloperExceptionPage();
}
else
{
    // 1. Gestisce le eccezioni non catturate (500) reindirizzando a una pagina amichevole
    app.UseExceptionHandler("/Error");

    // 2. Gestisce errori di stato HTTP come il 404 (Pagina non trovata)
    // {0} viene sostituito dal codice errore (es. 404, 403)
    app.UseStatusCodePagesWithReExecute("/Error/{0}");
    
    app.UseHsts();
}
```

da finire di verificare

## Gestione degli Error Status 404,500

```Csharp
[Route("/Error/{statusCode}")]
public void OnGet(int statusCode)
{
    if (statusCode == 404) 
    {
        ViewData["Message"] = "Ops! La pagina che cerchi è svanita nel nulla.";
    }
}
```
