
```CSharp
Classe ViewModel {
  public string url;
  public string Campo2;
}


public class DocumentiController : Controller
{
    private readonly IWebHostEnvironment _WebHostEnvironment;

    // viene creata una di , la di esiste già nella libreria asp net
    public DocumentiController(IWebHostEnvironment WebHostEnvironment)
    {
        _WebHostEnvironment = WebHostEnvironment;
    }

    public IActionResult CaricaFile()
    {
        // Viene ceato un oggetto vuoto da inviare alla view, il campo url contiene il nome del file
        // <input type="file" _name="mioFile"_ class="form-control" />
        return View();
    }

    // POST: /Documenti/CaricaFile
    // il nome della variabile (mioFile) viene dichiarato dal tag name, della view CaricaFile
    //
    [HttpPost]
    public async Task<IActionResult> CaricaFile_Post (IFormFile mioFile)
    {
        if (mioFile != null && mioFile.Length > 0)
        {
            
            // Definisci dove salvare il file (es. cartella "uploads")
            // legge la varialibe  per sapere l indirizzo fisico di partenza del sito
            string wwwRoot = _WebHostEnvironment.WebRootPath ;
            // "Foto" è una cartella fisica nel progetto nella cartella wwwRoot

            // nomeFile deve essere composto da una parte casuale per non generare il sovrapponimento
            // con altro file cartella, po Guid+nome, o dateteime+nome
            string FileName = Guid.NewGuid.ToString() + path.GetExtention(mioFile.FileName ; 
            var percorsoSorgente = Path.Combine( WwwRoot, "Foto", mioFile.FileName);

            ViewModel.url = "\" + "cartella" + mioFile;
            using (var stream = new FileStream(percorsoSorgente, FileMode.Create))
            {
                await mioFile.CopyToAsync(stream);
            }

            ViewBag.Messaggio = "File caricato con successo!";
        }
        else
        {
            ViewBag.Messaggio = "Seleziona un file valido.";
        }

        return View();
    }
}
```

La View CaricaFile

```HTML
<form asp-action="CaricaFile" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label>Seleziona il file:</label>
        <input type="file" name="mioFile" class="form-control" />
    </div>
    
    <button type="submit" class="btn btn-primary">Invia File</button>
</form>
```

mentre la View del CaricaFile_Post

```HTML
```
