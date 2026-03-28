
```CSharp
Classe ViewModel {
  public string url;
  public string Campo2;
}


public class DocumentiController : Controller
{
    

    public IActionResult CaricaFile()
    {
        // Viene ceato un oggetto vuoto da inviare alla view, il campo url contiene il nome del file
        // che verrà inserito dentro l imput img
        return View();
    }

    // POST: /Documenti/CaricaFile
    [HttpPost]
    public async Task<IActionResult> CaricaFile(IFormFile mioFile)
    {
        if (mioFile != null && mioFile.Length > 0)
        {
            // Definisci dove salvare il file (es. cartella "uploads")
            var percorsoSorgente = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", mioFile.FileName);

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
