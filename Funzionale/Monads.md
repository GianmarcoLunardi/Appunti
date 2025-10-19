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
Funzione Binding : prende una funzione la applica ai volori del contenitore, ottine un nuovo contenitore con i valori del codominio.
