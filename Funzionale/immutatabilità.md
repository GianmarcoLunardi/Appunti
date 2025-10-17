Concetto di immutabile un oggetto può essere inizializzato solo al momento della sui inizialilizzazhone tramite il costruttore
public class ClassA
{
public string PropA { get; private set; }
public int PropB { get; private set; }
public DateTime PropC { get; private set; }
public IEnumerable<double> PropD { get; private set; }
public IList<string> PropE { get; private set; }
public SubClassB PropF { get; private set; }

// inizilaizzazione
public ClassA(string propA, int propB, DateTime propC,
IEnumerable<double> propD, IList<string> propE, SubClassB
propF)
{
this.PropA = propA;
this.PropB = propB;
this.PropC = propC;
this.PropD = propD;
this.PropE = propE;
this.PropF = propF
}
}

Es:


** Concetto di funzione di alto livello
Func<T,TResult>

è una funzione che oltre calcolare un valore può essere assegnata come variabile
Func<int, int, string> FunzioneAggiungi ;

var addTen = (x,y) => x + 10;
var twenty = addTen(10, 20);

una funzione rispetto a una dichiarazione è qualcosa che deve essere valutato.


Le HF sono funzioni che non cambiano ne utilizzano variabili esterne 
In ogni stato del programma, con i soliti valori di input restituiscono solito output
Non hanno effetti collaterali , non lanciano eccezioni durante l esecuzione di un programma.

Preferiscono utilizzare la ricorsione prima di utilizzare i cicli
la funzione ha due paramentri , uno è il paramentro di arresto.

function int AddUntil(int startValue, int valore_arresto)
{
if(startValue == valore_arresto)
return startValue;
else
AddUntil(startValue + 1, endValue);
}

**Immutabilita
una variabile puo ricevere un valore solo all inizializzazuine,  e pero possibile riassegnare il valore a un altra varibile
(il concetto è qyello di una funzione matematca che non puo cambiare il valore di imput durante l elaborazione)

public class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

var person = new Person("Alice", 30);
// person.Name = "Bob"; // Questo genererà un errore di compilazione



Concetti base delle funzioni 

-Le funzioni non influiscono sullo stato esterno
Con soliti parametri di input si ricevono soliti parametri di impuy
Non Hanno effetti collaterali e non utilizzano eccezioni

Le Funzioni Pure non hanno riferimenti a vearibile esterne
public void Add(int a) => this.total += a;
public string SayHello() => "Hello " + this.Name;

**Tuple

Esempio di dichiarazione di una tupla
(double, string) t1 = (4.5, "OK");
var t = (Count: 5, Status: "OK");

Esempio di accesso da nome
t.count  = 2
t.Status="OK"

Ritorno di una funzione come tupla
```(int Id, string Name) GetPerson() => (1, "Alex");

