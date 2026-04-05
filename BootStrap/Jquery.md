## Jquery 
[Manuale](https://www.esempio.com](https://www.w3schools.com/jquery/default.asp)

E' una libreria javascript  che consente di manipolare il DOM di una pagina html e di fare chiamate asincrone.
Installazione:
Tramite CDN si inserisce il riferiurmento al link della pagina
Si scarica il codice poi si inserisce il riferimento alla pagina, poi si inserisce il riferimento sulla pagina.

La libreria si basa sulla programmazione funzionale e sul condetto di selettore, selezionare ul tag html 
poi appricargli delle proprietà dinameicamente.

Funzione principale, si seleziona il documento, si attende che sia caricata la pagina
poi si esegue la funzione anonima function(){}
```javascript
<script>
$(document).ready(function(){
  //Corpo della Funzione
  });
});
</script>
```

E' possibile poi selezionare un tag <P> per poi modificalo es, farlo sparire
```javascript
<script>
$(document).ready(function(){
    //Corpo della Funzione
    // si seleziona i tag paragrafo
      $("p").hide();
    //
  });
});
</script>
```

Per  selezionare le proprieta in modo più veloce è possibile anche usare gli attributi dei id e class
id identitfica univocamente un tag , class puo identidificarne più di uno

```HTML
<p id="identificatore" >
  paragrafo-speciale
</p>

<h1 class="classe">
  Titolo
</h1>
```

```javascript
<script>
$(document).ready(function(){
    //Corpo della Funzione
    // si seleziona i tag paragrafo
      $("#identificatore").hide(); // fa sparite il paragrafo
      $(".classe").onClick( function(){
                                        alert('classe');
                                      }); //fa apparire un messaggio 
    //
  });
});
</script>
```

# riferimento delle librerie
[JQueryui](https://jqueryui.com/)
