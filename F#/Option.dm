##Il tipo Option è definito con due casi possibili

Some(valore): Indica che un valore è presente e lo "avvolge" al suo interno
None: Indica esplicitamente l'assenza di un valore

let valorePresente = Some 42        // Assegna un intero opzionale con valore 42
let valoreAssente = None           // Assegna l'assenza di valore

mentre il Result<>

  // Dichiarazione del tipo Result con due parametri generici
type Result<TSuccess, TFailure> =
    | Ok of 'TSuccess
    | Error of 'TFailure
