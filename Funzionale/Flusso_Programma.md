# Flusso di  un programma
tramite la concantenazione è possibile scrivere un flusso di programma

x-->f-->h--> a partire da un dominio viene applicata una funzione che produce un codominio, il quale viene poi utilizzato in un altra funzion

```csharp
Es; //con Linq
static decimal AverageEarningsOfRichestQuartile(List<Person> population)
=> population
.OrderByDescending(p => p.Earnings)
.Take(population.Count / 4)
.Select(p => p.Earnings)
.Average();
```

Tuilizzo del bind per controllare il flusso delle operazioni

```csharp
Either<string, double> SafeSqrt(double x) =>
    x < 0 
        ? Left("Impossibile calcolare la radice di un numero negativo") 
        : Right(Math.Sqrt(x));

// Concatenazione con Bind
var result = SafeDivide(10, 2)              // Restituisce Right(5)
    .Bind(res => SafeSqrt(res));            // Esegue SafeSqrt(5) -> Right(2.23)

result.Match(
    Right: val => Console.WriteLine($"Risultato: {val}"),
    Left: err => Console.WriteLine($"Errore: {err}")
);
```
