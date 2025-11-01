** Metoto Per AL Gestione Errrorihttps://github.com/GianmarcoLunardi/Appunti/blob/main/Funzionale/Result%3Ct%3E().md

Librerie che lo omplementano

FluentResults    Result<T>, e altri
LanguageExt    Result<T>, Either<TLeft, TRight>, e molti altri.
Optional    Optional<T> equivalente

* Implrmentazione base
Implementazione

è stata utilizzata la libreria LanguageExt

````
using LanguageExt;
using LanguageExt.Common;


public class Result<T>
{
    public bool IsSuccess { get; }
    public T Value { get; }
    public string Error { get; }
    
    private Result(bool isSuccess, T value, string error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }
    
    **public static Result<T> Success(T value)** => new Result<T>(true, value, null);
    **public static Result<T> Failure(string error)**=> new Result<T>(false, default(T), error);
}
````

````
public async Task<Result<bool>> DivisioneAsync(int a, int b)
{
    if (b!=0)
    {
        //Utilizzare il Prelude per fare riferimento al ritorno della funzione
        return **Prelude**.Success(a/b);
    }
   else
    {
        return **Prelude**.Failure("Errore");
    };
}
````
un altro tipo che può essere usato è either , che restituisce due tipi di dato
in caso di successo restituisce un tipo L in caso di errore può restituire un tipo di oggetto R personalizzato

**Either<L, R>:
using LanguageExt;
using LanguageExt.Common; // se usi Error
using static LanguageExt.Prelude; // Left(...), Right(...), Some(...), ecc.

Either<L, R>: come Result ma con tipo di errore personalizzato L (Result usa Error come L)
Il moan può assumere il valore Left, o il valore Rigth
````
using LanguageExt;

Either<int, int> Monad;


Monad =Either<int, int>.Right(100); // assume lo stato R con valore 100
Monad = Either<int, int>.Left(-1); // cambia stato in L con valore -1


Monad.Match(
    Right: value => Console.WriteLine($"Success: {value}"),
    Left: error => Console.WriteLine($"Failure: {error}")
);
````


