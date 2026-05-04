## Tupla
è una struttura ordinata i cui campi non hanno nome
```fsharp
type Customer = string * bool * bool
```
#Assegnazione 
f# riesce a assegnare il tipo dei dati autinomanemte ache se è possibile assseghanelo in tipo esplicito
```fsharp
let fred = ("Fred", true, true)
let fred : Customer = ("Fred", true, true)
```
