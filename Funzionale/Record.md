## Definizione di un Record
é immutabile, dichiarazione
```csharp
public record Persona(string Nome, int Età);
```
Creazione di un'Istanza
```csharp
var persona1 = new Persona("Mario", 30);
var persona2 = new Persona("Giulia", 25);
```
# Eguaglianza per Valore
```csharp
var persona1 = new Persona("Mario", 30);
var persona2 = new Persona("Mario", 30);
bool sonoUguali = persona1 == persona2; // true
```

# Utilizzo di sintassi posizionale 
```csharp
class TipoRecord {
public string Titolo { get; init; }
public string Autore { get; init; }, ecc.
}
```

# Tupla/Record
La tupla rispetto al record è un tipo anonimo, inolte è mutabile

```csharp
(string Nome, int Anni) OttieniDatiSemplici()
{
    return ("Marco", 28);
}

// Utilizzo
var utente = OttieniDatiSemplici();
Console.WriteLine($"{utente.Nome} ha {utente.Anni} anni.");
```
