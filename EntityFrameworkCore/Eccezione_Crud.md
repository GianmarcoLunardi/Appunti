## Gestire le eccezioni in modo funzionale
Durante le chiamate a un database posso generarsi delle eccezione che possono bloccare l intero sosistema
_Exceptional_ la struttura consente sia di fornire un valore , si si fornire l eccezione generata senza l interruzione
In questo approccio, se SaveChanges() fallisce, EF Core lancia una DbUpdateException. Il programmatore deve catturarla manualmente.

```csharp
// Trasformiamo un'operazione che "esplode" in una funzione onesta
public Exceptional<Unit> SaveToDb(User user)
{
    try 
    {
        _context.Users.Add(user);
        _context.SaveChanges(); // Qui può scattare un'eccezione
        return unit; // Successo (valore vuoto funzionale)
    }
    catch (Exception ex) 
    { 
        return ex; // L'eccezione viene restituita come dato, non lanciata [4]
    }
}
'''

public void InserisciUtente(User nuovoUtente)
{
    try
    {
        _context.Users.Add(nuovoUtente);
        _context.SaveChanges(); // Qui può scattare l'eccezione
        Console.WriteLine("Utente salvato.");
    }
    catch (DbUpdateException ex)
    {
        // L'eccezione interrompe il flusso e deve essere gestita qui
        Console.WriteLine($"Errore database: {ex.Message}");
    }
}
```
## Approccio Funzionale (Wrapping in Exceptional)
Per rendere la funzione "onesta", possiamo avvolgere l'operazione in un tipo come Exceptional<T> o Try<T>. In questo modo, l'errore non interrompe il flusso ma viene restituito come "payload"
```csharp

// Utilizzando un wrapper funzionale come suggerito dai sorgenti
public Exceptional<Unit> SafeAdd(User nuovoUtente)
{
    try
    {
        _context.Users.Add(nuovoUtente);
        _context.SaveChanges();
        return unit; // Successo
    }
    catch (Exception ex)
    {
        return ex; // L'eccezione viene restituita come dato, non lanciata [8]
    }
}

// Utilizzo
SafeAdd(utente).Match(
    Success: _ => Console.WriteLine("Tutto ok"),
    Exception: ex => Console.WriteLine($"Fallito: {ex.Message}")
);
```
