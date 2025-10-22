**Tuple**

Esempio di dichiarazione di una tupla, per definizione è __ummutabule__

`
(int count, string Status) t = (Count: 5, Status: "OK");
var t = (Count: 5, Status: "OK");'

Esempio di accesso da nome
`t.count  = 2
t.Status="OK"

Ritorno di una funzione come tupla
`(int Id, string Name) GetPerson() => (1, "Alex");'

**ES**
esaminato i cicli per convertire un elemento in un altro, X elementi in ingresso → X nuovi elementi in uscita

Nel mio esempio qui sopra, uso una Tupla per accoppiare dati provenienti da due funzioni di ricerca per ogni ID di film dato, il che significa che posso eseguire un'operazione Select successiva per semplificare la coppia di oggetti in un singolo valore di ritorno.

'
var filmIds = new[]
{
    4665,
    6718,
    7101
};

var filmsWithCast = filmIds.Select(x => (
    film: GetFilm(x),
    castList: GetCastList(x)
));

var renderedFilmDetails = filmsWithCast.Select(x =>
@$"
Title: {x.film.Title}
Director: {x.film.Director}
Cast: {string.Join(", ", x.castList)}
".Trim());
'
