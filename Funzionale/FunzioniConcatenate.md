**Funzioni conposte
Sono funzioni che si calcolano utilizzando il principio matematico del composto

g(f(x)) , dove g(y) viene calcolata nel codomionio di f(x)

```
static string AbbreviateName(Person p) => Abbreviate(p.FirstName) + Abbreviate(p.LastName);

//oppure 

Func<Person, string> emailFor =
p => AppendDomain(AbbreviateName(p));
var joe = new Person("Joe", "Bloggs");
var email = emailFor(joe);

```

** Concatenazione di metodi
Sono un concatenarsi di setodi seguiti da .

x.f(x).g(x)

Nel contenitore x viene 

Funzioni applicate su un monad che contiene un singolo valore

using System;

public class Calcolatrice
{
    private double valore;

    public Calcolatrice(double iniziale)
    {
        valore = iniziale;
    }

    // Ogni metodo restituisce l'istanza corrente (this)
    public Calcolatrice Somma(double numero)
    {
        valore += numero;
        return this;
    }

    public Calcolatrice Moltiplica(double numero)
    {
        valore *= numero;
        return this;
    }

    public Calcolatrice Sottrai(double numero)
    {
        valore -= numero;
        return this;
    }

    public double Risultato()
    {
        return valore;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            double risultato = new Calcolatrice(10)
                .Somma(5)        // 10 + 5 = 15
                .Moltiplica(2)   // 15 * 2 = 30
                .Sottrai(4)      // 30 - 4 = 26
                .Risultato();

            Console.WriteLine($"Risultato finale: {risultato}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
    }
}
