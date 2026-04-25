## Dichiarazione 
```fsharp
type Persona = { Nome: string; Eta: int }
// assegnamento
let studente = { Nome = "Mario"; Eta = 20
```
i rescord sono generamente immutabili ma è possibile cleare una cipia con il comando with

```fsharp
let studentePiuVecchio = { studente with Eta = 21 }
```
