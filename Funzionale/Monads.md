##Strutture o Monads
contenitore (un wrapper) per un _valore o collezione_. Questo contenitore non si limita a tenere il valore, ma definisce delle regole su come elaborarlo.

**ci cono associate delle funzioni che rappresentano funzioni asincrone**

Sono monad
Operazioni Asyncrone :
Task<T>
I nullable
Maybe<T> , Nullable<T>, ....
dove si può applicare la map
Collezioni

# Esempio di funzioni associate
IEnumerable<T> Dove si può applicare .select

.Map
prende un valore all'interno di un contenitore, gli applica una funzione e rimette il risultato in un contenitore dello stesso tipo.

Map: (C<T>, T->R) -> C<R>    dove C<T> indica una struttra generica, t->r una funzione che va dai valori di T a R
.bind
si usa quando la funzione di trasformazione restituisce già un contenitore. Se usassi Map in questo caso, ti ritroveresti con un contenitore dentro un altro contenitore (es. List<List<int>>). Bind applica la funzione e poi "appiattisce" il risultato.
Bind: F<A> -> (A -> F<B>) -> F<B>  //modifica si il contenitore che il valore esterno

Esempio: Ogni utente ha una lista di numeri di telefono. Vuoi un'unica lista di tutti i numeri di telefono di tutti gli utenti.

```csharp
var utenti = new List<Utente> { utente1, utente2 };
// Bind (SelectMany) evita di creare una List<List<string>>
var tuttiITelefoni = utenti.SelectMany(u => u.NumeriDiTelefono);
// Risultato: { "123", "456", "789" } -> Una lista piatta di stringh
```



E' una funzione che può essere associata a una struttura di un singolo valore esempio Option<T> oppure IEnumerable<T>.
Map è una funzione che viene applicata al dominio (valore, Valori> e restitutisce un codomio che contiene i valori f(x).
Select(f(x)) è un sinonimo che vale colo su collezioni, mentre Map può essere associata anche a singoli valori.


Es:
(Option<T>, (T -> R)) -> Option<R>        Map f(x) applicato a Option<T> ha come risultato

None       se Option<T> è none
f(Some)    se Option<T> contiene un valore

Es2:
Caso di una collezione ha funziona equivalentemente a .Select


** Funzione Binding 

prende una funzione la applica ai volori del contenitore, ottine il codominio del valore primitivo
Map: (C<T>, T->R) -> R    dove C<T> rispetto a Map non restituisce C<R>
Esempio : ho una collezione di numeri gli applico una funzione (x)->x*2 ottine un altra collezione ce contiene il doppio dei valori.
Bind: (M<T>,T -> M<U>)-> M<U> applica una funzione T -> M<U>, e restituisce .






Struttura dei contenitori

Funzione Return: prende un (o più valorei) tipo primitivo e lo incapsula dentro un contenitore

Pricipi:
Associativo, se abbiamo una catena di funzioni annidate appplicate a un contenitore, qualunque si l  ordine di easecuzioni il risualtato non cambia
Identita Se associamo una funzione al valore ci un contenitore

**Librerie**
_LanguageExt_ : contine Option<t> Either<T>
_Option_ : solito
_Monads.net_
Maybe<T>, Either<T>, List<T>

Es:



`#0969DA`
```
Maybe<int> contenitore = new Maybe<int>(5);
if contenitore.HasValue then Console.WriteLine(Contenitore.value);
```

La discussione continua a pagina 95

Agiunta di altre metodi 
Funzione map Map: C<T> ->  C<R>   dove  R=f(T)
La funzione map funziona su monad che contengono singoli oggetti
La funzione select si può applicare su Ienumerable
Questa funzione consente di avere altri contenitori, o meglio la concatenazione di funzioni
```
Maybe<T> Map(FUNCT<T,Maybe<R>> f) {
Maybe<T>.HasValue: Maybe.Some(f(T).value)) ? Maybe<R>.HasValue=false:
}
```
Funzione  Bind
Prene il calore del contenitore in T se ha un volare fitorna f(T) nel caso non ha voalore ritorna il valore Maybe<T>.None
```
Funzione  Bind: C<T> ->  f(T)

Maybe<T> Map(FUNCT<T,Maybe<R>> f) {
Maybe<T>.HasValue: f(T).value)) ? Maybe<R>.None:
}
```
Funzione  GetOfElse
Prene il calore del contenitore in T se ha un volare fitorna f(T) nel caso non ha voalore ritorna Di Default
```
Funzione map Bind: C<T> ->  O 
Maybe<T> GetOfElse(T : DefaultValue) {
Maybe<T>.HasValue: f(T).value)) ? DefaultValue:
}
```

Esempio dell utilizzao dei maìonad
```
public Maybe<double> Divide (int nummeratore, int denomunitaore){
donominatore == 0? returno Naybe.None : return Maybe.Sone( (double)numeratore/denominatore);
}
```
Esempio di utilizzo delle funzioni Contenitore
```
Maybe<int> numero = new Maybe<int>.Some(5);
// aggingo una funzione 
Maybe<int> Reusult = numero.Map(x=>x+3);
Consol.Writeline (Result.GetOrElse(10)) //output è 8
```
Utilizzo del bing
```
public record Pesona
{
  public int età {get, init}
  public string nome {get,init}
}

maybe<Presona> Trova(string nome => nome=="Lucio")
{
//caso in cui riesce a trovare un record
Mayve<Persona>.HasValue? new Persone {name='Lucio', eta=24} : Maybe<Persona>.None
}
```

[Result<T>()](Tresult<T>().md)




Esempio che utilizza tutte le funzioni studiate
string personName="john";
Funct<int,int> aggiunge_uno = (p=p+1);

Per Monads composti da collezioni IEnumerable 
si usa la funzione Select() che ha effetto simile al mapping  Esempio: [Funzionale/IEnumerable.md](./IEnumerable.md)  Funzionale/IEnumerable.md

