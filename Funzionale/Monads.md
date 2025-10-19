**Monads**
Sono dei contenitori in cui è racchiuso uno o più valore alla quale è possibile applicare una funzione

Es:
Map: (C<T>, T->R) -> C<R>

Sono monad
Operazioni Asyncrone :
Task<T>
I nullable
Maybe<T> , Nullable<T>, ....
Collezioni
IEnumerable<T>

Struttura dei contenitori

Funzione Return: prende un (o più valorei) tipo primitivo e lo incapsula dentro un contenitore
Funzione Binding : prende una funzione la applica ai volori del contenitore, ottine un nuovo contenitore con i valori del codominio

Pricipi:
Associativo, se abbiamo una catena di funzioni annidate appplicate a un contenitore, qualunque si l  ordine di easecuzioni il risualtato non cambia
Identita Se associamo una funzione al valore ci un contenitore

**Librerie**
_LanguageExt_ : contine Option<t> Either<T>
_Option_ : solito
_Monads.net_
Maybe<T>, Either<T>, List<T>

Es:
```
Maybe<int> contenitore = new Maybe<int>(5);
if contenitore.HasValue then Console.WriteLine(Contenitore.value);
```

