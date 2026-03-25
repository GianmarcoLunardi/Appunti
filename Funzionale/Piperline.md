## Piperline
E' un insieme di funzioni composte , seseguite secondo in concatenazione una dopo l' altra
ogni funzione ha come valore di ritorno Rigth (giusto) e passa alla successiva
Left valore di uscita della piperline.
Usa Map quando la funzione di trasformazione non può fallire (es. cambiare un formato stringa).

Per concatenare le funzioni si utilizza bind
Usa Bind quando anche la funzione successiva restituisce un Either o un Option (evita di avere un Either<Error, Either<Error, Success>>).
Mentre si utilizza il map, per ottenere un tipo base , un valore finale

Es: di approccio dunzionale con uno schema funzionale
```csharp
// dichiarazione della funzione
using LanguageExt;
using static LanguageExt.Prelude;

namespace FunctionalApi.Examples;

public static class MonadInitialValueExample
{


    public static void Run()
    {
        // 1. IL VALORE INIZIALE È GIÀ UNA MONADE
        // Magari questo arriva da un parsing di un input utente che potrebbe fallire
        Either<string, double> inputMonadico = Right(100.0);

        // 2. CONCATENAZIONE (PIPELINING)
        // Dato che partiamo da un Either, usiamo subito Bind per "entrare" nel flusso
        var result = inputMonadico
            .Bind(val => Divide(val, 2))  // Risultato: Right(50)
            .Bind(val => Divide(val, 5)); // Risultato: Right(10)

        // 3. ESEMPIO CON INPUT GIÀ FALLITO
        Either<string, double> inputFallito = Left("Input non valido.");

        var ignoredResult = inputFallito
            .Bind(val => Divide(val, 2))  // Non viene eseguita
            .Bind(val => Divide(val, 5)); // Non viene eseguita

        // OUTPUT
        result.Match(
            Right: val => Console.WriteLine($"Risultato finale: {val}"),
            Left: err => Console.WriteLine($"Errore: {err}")
        );

        inputFallito.Match(
            Right: val => Console.WriteLine($"Risultato finale: {val}"),
            Left: err => Console.WriteLine($"Il flusso si è fermato subito: {err}")
        );
    }
}
```
