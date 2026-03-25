è possbbile gestire le eccezioni prima che vengano scatenate.

```csharp
using LanguageExt;
using static LanguageExt.Prelude; // Per usare scorciatoie come 'Success' o 'unit'

public class UserRepository
{
    private readonly MyDbContext _context;

    public UserRepository(MyDbContext context) => _context = context;

    public TryAsync<Unit> UpdateAsync(User entity) => TryAsync(async () => 
    {
        _context.Users.Update(entity);
        await _context.SaveChangesAsync();
        
        return unit; // Equivale a 'void' nel mondo funzionale
    });
}


// chiamata del service

var operation = userRepository.UpdateAsync(myUser);

// Risolviamo l'operazione in modo dichiarativo
await operation.Match(
    Succ: unit => Console.WriteLine("Update riuscito con successo!"),
    Fail: ex   => Console.WriteLine($"Errore durante l'update: {ex.Message}")
);
```

### Pipeline Funzionale (Concatenazione)
Puoi anche concatenare altre operazioni. Se UpdateAsync fallisce, le funzioni successive (Map o Bind) verranno saltate automaticamente.
