1)/Views/Shared/_Layout.cshtml
 Inserire il link alla libreria (sia percorso fisico wwwRoot si percorso web url) 
Inserire la libreiria nella pagina di layout l indirizzo fisico della libreria (se scaricata o l indirizzo 
```HTML
<script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
```


2) sulla view alla fine del file inserire lo script
```CSharp
@section Scripts {

    // codice view dentro un file .cshtml
    <script>
        // Passaggio di una stringa semplice
        const nomeUtente = "@ViewBag.NomeUtente";

        // Passaggio di un oggetto complesso (usando JSON)
        const impostazioni = @Html.Raw(Json.Serialize(Model.Impostazioni));

        console.log("Benvenuto " + nomeUtente);
    </script>
    // Oppure inserire il riferiemnto a un file Javascript che risiede dentro una directory wwwRooot
    <script src="~/js/mio-script-personalizzato.js"></script>
}
```
note:
Assicurarsi che nella pagina layout /Views/Shared/_Layout.cshtml
contengra il contenitore per visualizzare lo script passato
```CSharp
    </footer>
    <script src="~/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>

    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
```
