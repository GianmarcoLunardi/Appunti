Linq è un linguaggio creato per estrarrere dati da una risorsa
Concetti base del linguaggio: Extention Method , Esperession Lambda

presupponendo di avere due liste
```csharp
public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
}

```
usando **Query Syntax**
```csharp
var query = from e in employees
            join d in departments on e.DepartmentId equals d.Id
            select new 
            {
                EmployeeName = e.Name,
                DepartmentName = d.DepartmentName
            };

foreach (var item in query)
{
    Console.WriteLine($"{item.EmployeeName} lavora in {item.DepartmentName}");
}
```
mentre usando **Method Syntax**
```csharp
var employees = new List<Employer> { /* ... */ };
var departments = new List<Department> { /* ... */ };

var query = employees.Join(
    departments,                // La lista con cui fare join
    e => e.DepartmentId,        // Chiave esterna (dalla prima lista)
    d => d.Id,                  // Chiave primaria (dalla seconda lista)
    (e, d) => new               // Selettore dei risultati
    {
        EmployeeName = e.Name,
        DepartmentName = d.DepartmentName
    }
);

foreach (var item in query)
{
    Console.WriteLine($"{item.EmployeeName} lavora in {item.DepartmentName}");
}
```

## Ricodo Le altre funzioni
Where() Filtro
lista.ElementAt(9)  //elemento nella posizione 9 
lista.ElementAtOrDefault(9)  // in caso non trova l elemento non scatta l eccezione
.GrupBy()
Questi operatori hanno come output True o False
.Any(Lambda)   almeno uno verifica il predicato
.All(Predicato) tutto
.Contain(Elemento) Vero se l elemento è presente nella lista
.SequenceEqual(ICollection)  true se i valori delle due collezioni sono uguali
