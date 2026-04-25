## fichiarazione di immutabili

```fsharp
// Sintassi: let nomeVariabile : tipo = valore
let numero : int = 10
let testo : string = "Ciao Gemini"
let piGreco : float = 3.14
```
## dichiarazioni di mutabili

```fsharp
// Variabile tipata mutabile
let mutable contatore : int = 0
contatore <- 1  // Si usa l'operatore <- per l'assegnazione
```

## tuple array ecc....
```fsharp
let mioArray = [| "F#"; "C#"; "VB.NET" |]
// 1. Accesso tramite indice
let primoLinguaggio = mioArray.[0]
let secondoLinguaggio = mioArray.[1]
let tupla = (1,2,3)
```
