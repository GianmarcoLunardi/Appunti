## Gestire le eccezioni in modo funzionale

'''CSharp
In questo approccio, se SaveChanges() fallisce, EF Core lancia una DbUpdateException. Il programmatore deve catturarla manualmente.
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
Esempio 2: Approccio Funzionale (Wrapping in Exceptional)
Per rendere la funzione "onesta", possiamo avvolgere l'operazione in un tipo come Exceptional<T> o Try<T>. In questo modo, l'errore non interrompe il flusso ma viene restituito come "payload"
.
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
'''
