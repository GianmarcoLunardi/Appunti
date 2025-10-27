# IEnumerable<T>
Un Monad che contiene una collezione di oggetti.

##Concatenamento di funzioni Chaining
consiste nell'applicare più funzioni consecutivamente su una collezione di dati
```
IEnumerable<T> x ={x1,x2,x3}

m.f();
m.g();
m.h();
//Risulta molto più leggibile 
m.f().g().h();
```

 
## Lazy Loading (di Deafault)
La funzione o la catena delle funzioni vengono valutate sonlo nel momento in cui si richiede o un o piu elemeti ToList()

si carica un elemento alla volta e si fa elaborare a tutte le funzioni della catena
```
x.f(x1).g(x1).h(x1);
//Decine di righe di cosice
// la funzione viene valutata solo nel momento in cui o si richiede un dato, oppure quando si richiadano tutti
y = x[1];

IEnumerable z= x.ToList();
```
# Eager Loading, 
Supponendo di avere un IEnumerable 
```
Le funzioni venfono valutate per pogni elemento
x2=x1.ToList();
x3=x2.h(x3);
```

Leazy Loading è viene caricato un dato e valutato dalla prima all ultima funzione della catena, poi si estrae il successivo dato e si tipete
tipo un foreach, viene estratto x1-> f(x1), g(x1), h(x1), f(x2),....h(x3)

# Leazi Loading
Caricamento lento dei dati

Data una collezione di dati 

```
var input = new[]
{
    75,
    22,
    36
};
```

Estrae un dato alla volta dalla collezione tipo un ciclo foreach
```
var output = input.Select(x => f(x))
                  .Select(x => g(x))
                  .Select(x => h(x));
Fornendo queste chiamate sullo steck
```
18/08/1982 11:24:00 - f(75)
18/08/1982 11:24:01 - g(75)
18/08/1982 11:24:02 - h(75)
18/08/1982 11:24:03 - f(22)
18/08/1982 11:24:04 - g(22)
18/08/1982 11:24:05 - h(22)
18/08/1982 11:24:06 - f(36)
18/08/1982 11:24:07 - g(36)
18/08/1982 11:24:08 - h(36)


#### EagherLoading

8 var temp1 = input.Select(x => f(x)).ToArray();
9 var temp2 = input.Select(x => g(x)).ToArray();
10 var finalAnswer = input.h(x => h(x)).ToArray();

18/08/1982 11:24:00 - f(75)
18/08/1982 11:24:01 - f(22)
18/08/1982 11:24:02 - f(36)
18/08/1982 11:24:03 - g(75)
18/08/1982 11:24:04 - g(22)
18/08/1982 11:24:05 - g(36)
18/08/1982 11:24:06 - DoSomethingThree(75)
18/08/1982 11:24:07 - DoSomethingThree(22)
18/08/1982 11:24:08 - DoSomethingThree(36)

Ad gni chiamata  .ToArray() estrae un nuovo dato
