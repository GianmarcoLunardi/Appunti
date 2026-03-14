## Definizione di un Record
é immutabile, dichiarazione
```csharp
// Dichiarazione di valori posizionali
public record Persona(string Nome, int Età);
```
Creazione di un'Istanza
```csharp
var persona1 = new Persona("Mario", 30);
var persona2 = new Persona("Giulia", 25);
```
# Eguaglianza per Valore
due record sono uguali quando tutte le loro proprietà hanno gli stessi valori

```csharp
var persona1 = new Persona("Mario", 30);
var persona2 = new Persona("Mario", 30);
bool sonoUguali = persona1 == persona2; // true
```

# Utilizzo di sintassi posizionale 
```csharp
// record con valori non posizionali
class TipoRecord {
public string Titolo { get; init; }
public string Autore { get; init; }, ecc.
}
```
## Instanza di un nuovo record
// nuovo record
var p1 = new Persona("Mario", "Rossi");
// Instanzia nuovamente un record esistente
var p1 = new Persona("Mario", "Rossi");
var p2 = p1 with { Cognome = "Bianchi" };




## Ereditarietà Fra record
Sue record sono uguali se hanno il _solito tipo concreto uguale_ cioèhanno i soliti attributi
## Metodi e fuzioni sui dati
può avere metodi di istanza, metodi statici, proprietà calcolate, costruttori, override… tutto.

public record Persona(string Nome, string Cognome)
{
    public string NomeCompleto() => $"{Nome} {Cognome}";
}

public record Punto(int X, int Y)
{
    public static Punto operator +(Punto a, Punto b)
        => new(a.X + b.X, a.Y + b.Y);
}

```csharp
# Tupla/Record
La tupla rispetto al record è un tipo anonimo, inolte è mutabile
```

```csharp
(string Nome, int Anni) OttieniDatiSemplici()
{
    return ("Marco", 28);
}

// Utilizzo
var utente = OttieniDatiSemplici();
Console.WriteLine($"{utente.Nome} ha {utente.Anni} anni.");
```
