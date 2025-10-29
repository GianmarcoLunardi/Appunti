** Metoto Per AL Gestione Errrori

* Implrmentazione base
Implementazione 

````
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
        return __Result<bool>.Success(a/b);__
    }
   else
    {
        return __Result<bool>.Failure("Errore");__
    };
}
````


