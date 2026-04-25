## Collezioni
# Le list sono immutabili
# Le liste sono mutabili
# Le sequenze sono lezzy load
dichiarazione: let numeri = [1; 2; 3]
```fsharp
Lista = [1; 2; 3 ]
Array = [| 1; 2; 3 |]
// gli array essendo sequnenze di celle di meria , hanno un calcolo veloce dell elemento centrale
Es: Array.[0]
let seqInfinita = seq { 1 .. 1000 }
```
Per lavorare tranquillamente sulle strutture dati sono stuziate delle funzioni
_map_	Trasforma ogni elemento della collezione creando una nuova collezione.
_filter_	Crea una nuova collezione contenente solo gli elementi che soddisfano una condizione.
_fold_	"Accumula" i valori della collezione in un unico risultato (es. la somma).
_iter_	Esegue un'azione (come stampare) per ogni elemento, senza restituire nulla.


```fsharp
// data una lista di numeri voglia prima selezionare solo quelli pari
// poi vogliamo moltiplicarli tutti per 10
let numeri = [1; 2; 3; 4; 5; 6]

let risultato =
    numeri
    |> List.filter (fun x -> x % 2 = 0) // Passaggio 1: Teniamo solo i pari
    |> List.map (fun x -> x * 10)```
