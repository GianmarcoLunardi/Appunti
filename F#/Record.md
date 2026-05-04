# Dichiarazione 
-
-I campi possono essere scritti su un'unica riga separati da punti e virgola o su righe separate per una migliore leggibilità

```fsharp

type Persona = { Nome: string; Eta: int }

type Customer = {
Id : string
IsEligible : bool
IsRegistered : bool
}
## creazione di una nuova instanza di un record

let studente = { Nome = "Mario"; Eta = 20}

let fred = {
Id = "Fred"
IsEligible = true
IsRegistered = true
}

```
i record sono generamente immutabili ma è possibile creare uno nuovo modificando uno già esistente

```fsharp
let studentePiuVecchio = { studente with Eta = 21 }
```
#Esistono record anonimi
I record anonimi si distinguono dai record classici perché utilizzano le parentesi graffe con le barre verticali: {| NomeCampo = Valore |}

