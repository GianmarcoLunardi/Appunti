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
## Aggiornamento di una repository con i record
```csharp
// 1. Recupero il record originale
var clienteEsistente = repository.GetById(1);

// 2. Creo una copia aggiornata
var clienteAggiornato = clienteEsistente with { Email = "nuova.email@esempio.it" };

// 3. Salvo il nuovo stato
repository.Update(clienteAggiornato);
# Eguaglianza per Valore
due record sono uguali quando tutte le loro proprietà hanno gli stessi valori
```
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
*** I dati gerarchi sono i dati che hanno una struttura a albero che i dati figli derivano dai dati padri
*** Questo conetto viene espresso con l ereditarietà
Sue record sono uguali se hanno il _solito tipo concreto uguale_ cioè hanno i soliti attributi
Organizzando dati in modo cerarchico si evita di utilizzare il null
Esempio:
```csharp
public abstract record Messaggio;
public record MessaggioTesto(string Contenuto) : Messaggio;
public record MessaggioImmagine(string Url) : Messaggio;
public record MessaggioErrore(string Errore) : Messaggio;
```
In questo caso un messaggio di testo non può avere un url, un messaggio d errore, non può avere un contenuto.
**  pattern matching
Consente di riconoscere il tipo di dato e estrarrere i relativi campi associati
```csharp
Messaggio m = new MessaggioImmagine("foto.png");

var risultato = m switch
{
    MessaggioTesto t      => $"Testo: {t.Contenuto}",
    MessaggioImmagine i   => $"Immagine: {i.Url}",
    MessaggioErrore e     => $"Errore: {e.Errore}"
};
```


## Metodi e funzioni sui dati
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
