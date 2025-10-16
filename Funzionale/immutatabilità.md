Concetto di immutabile un oggetto può essere inizializzato solo al momento della sui inizialilizzazhone tramite il costruttore
public class ClassA
{
public string PropA { get; private set; }
public int PropB { get; private set; }
public DateTime PropC { get; private set; }
public IEnumerable<double> PropD { get; private set; }
public IList<string> PropE { get; private set; }
public SubClassB PropF { get; private set; }
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

** Tupla 
(double, int) t1 = (4.5, 3);

