Utilizzo delle funzione in un un libguaggio a oggetti

```
**using static** System.Console;
WriteLine("Hello, World");
```

Dichiarare la funzione di alto livello

```
Func<in T,out TResult>(T arg);

Funct<int, string> funzione = ( x => console.writeln(x););
funzione(25); // Srtampa 25
```
