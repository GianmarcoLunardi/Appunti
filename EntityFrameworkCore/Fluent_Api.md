## Fluent Api 
La base di una Fluent API è il Method Chaining (concatenazione di metodi). Invece di chiamare metodi separatamente su un oggetto, ogni metodo restituisce l'oggetto stesso (o uno nuovo), permettendo di chiamare il metodo successivo immediatamente.


var miaPizza = new PizzaBuilder()
    .ConImpasto("Integrale")
    .ConSalsa()
    .ConIngredienti("Mozzarella", "Basilico")
    .Build();
```csharp
public class Pizza {
    public string Impasto { get; set; }
    public bool HaSalsa { get; set; }
    // ... altri ingredienti
}

public class PizzaBuilder {
    private Pizza _pizza = new Pizza();

    public PizzaBuilder ConImpasto(string tipo) {
        _pizza.Impasto = tipo;
        return this; // <--- Il "segreto" è qui!
    }

    public PizzaBuilder ConSalsa() {
        _pizza.HaSalsa = true;
        return this; 
    }

    public Pizza Build() {
        return _pizza; // Metodo finale per ottenere l'oggetto pronto
    }
}
```

Il rpoblema del concatenamento dei metodi può generare delle azioni in ordine scorretto
La Soluzione: I binari delle Interfacce
L'idea è che ogni metodo non restituisca più l'intero PizzaBuilder, ma un'interfaccia specifica che espone solo i metodi permessi in quel momento.

Ecco come potremmo strutturare le fasi:

IPizzaImpasto: Espone solo ConImpasto().

IPizzaCondimento: Espone ConSalsa(), ConIngredienti() e Build().

Implementazione dello Step Builder
Proviamo a vedere come cambia la firma dei metodi. La classe PizzaBuilder implementerà tutte le interfacce, ma le "mostrerà" un po' alla volta.

```csharp
public interface IPizzaImpasto {
    IPizzaCondimento ConImpasto(string tipo);
}

public interface IPizzaCondimento {
    IPizzaCondimento ConSalsa();
    Pizza Build();
}

public class PizzaBuilder : IPizzaImpasto, IPizzaCondimento {
    private Pizza _pizza = new Pizza();

    // Questo è il punto di ingresso statico
    public static IPizzaImpasto CreaNuova() => new PizzaBuilder();

    public IPizzaCondimento ConImpasto(string tipo) {
        _pizza.Impasto = tipo;
        return this; // Ritorno me stesso, ma "vestito" da IPizzaCondimento
    }

    public IPizzaCondimento ConSalsa() {
        _pizza.HaSalsa = true;
        return this;
    }

    public Pizza Build() => _pizza;
}

```
