# Flusso di  un programma
tramite la concantenazione è possibile scrivere un flusso di programma

x-->f-->h--> a partire da un dominio viene applicata una funzione che produce un codominio, il quale viene poi utilizzato in un altra funzion

```
Es; //con Linq
static decimal AverageEarningsOfRichestQuartile(List<Person> population)
=> population
.OrderByDescending(p => p.Earnings)
.Take(population.Count / 4)
.Select(p => p.Earnings)
.Average();
```
