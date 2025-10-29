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


