## Tupla
è una struttura ordinata i cui campi non hanno nome

type Customer = string * bool * bool


type Persona = { Nome: string; Eta: int }
## Aggiornamento di un campo
let studente = { Nome = "Mario"; Eta = 20
i rescord sono generamente immutabili ma è possibile cleare una cipia con il comando with

let studentePiuVecchio = { studente with Eta = 21 }
