## Funzioni anonime o lamda

```fsharp
fun()->printf
fun x->x+1
fun x y ->x+y
```

## Funzioni con nome

```fsharp
let  somma (a) = a+3
// oppure
let somma = (a)->a+1
// dichiarare una funzione che orende due paramentri poi li stampa con l interpolation strin
let scrivi (a:int) (b:int) :string
$"{a} e {b}""

```
## Option
restitutisce due valorei o some oppure none 
```fsharp
let divisioneSicura (dividendo: float) (divisore: float) =
    if divisore = 0.0 then
        None // Non possiamo dividere per zero, restituiamo la "scatola vuota"
    else
        Some (dividendo / divisore)
```
