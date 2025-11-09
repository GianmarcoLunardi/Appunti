**Funzioni conposte

Date due funzioni f e g, si può definire una funzione h come la composizione di queste due funzioni, annotata come segue:

h = f • g

Applicare h a un valore x è lo stesso che applicare g a quello stesso valore x per ottenere un risultato intermedio, e poi applicare f a quel risultato intermedio. Ovvero:

h(x) = (f • g)(x) = f(g(x))

```
// si vuole calcolare l indirizzo email delle persone che lavorano in una libreria

//oppure 

Func<Person, string> emailFor =
p => AppendDomain(AbbreviateName(p));
var joe = new Person("Joe", "Bloggs");
var email = emailFor(joe);

```

** Concatenazione di metodi
Sono un concatenarsi di setodi seguiti da .

x.f(x).g(x) vengono eseguite nel ordine f,g,h ciò ne consente una maggiore visibilità nella lettura

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
