è possibile generare file layout che contengono pagina contenitore del sito
all avvio del sito viene cercato nella posizione standart /Views/Shared/_Layout.cshtml

La pagina contenuta per richiamare il contenitore
```cshtml
@{
     Layout = "_Layout"; //pagina standard
     Layout = "/Views/Shared/_Layout.cshtml"; //pagina personalizzata
}
```
Per ricordare il commento del codice
```cshtml
@*      *@
@/
```
