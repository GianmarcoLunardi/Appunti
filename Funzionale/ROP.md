## Railway Oriented Programming (ROP)

L'analogia del binario è alla base del ptreno*
il binario principale rappresenta il "percorso felice" (happy path), mentre il binario secondario raccoglie i fallimenti
 Le funzioni che restituiscono tipi monadici (come Either o Option) agiscono come scambi ferroviari: se l'operazione ha 
 successo, il treno prosegue sul binario principale; se fallisce, viene deviato sul binario dell'errore e vi rimane fino 
 alla fine del percorso, saltando tutte le stazioni successive
#ogni operazione viene modellata come una funzione che accetta un input e restituisce un tipo disgiunto 
# solitamente Either<L, R>
# .bind() permentte di concatenare la funzione

[Vai alla pagina](https://github.com/GianmarcoLunardi/Appunti/blob/main/Funzionale/Either().md)


Librerie che lo omplementano

LanguageExt    Option<T>, 
Funcky,LanguageExt Either<TLeft, TRight>, e molti altri.


* Implrmentazione base
Implementazione

è stata utilizzata la libreria LanguageExt

```csharp
Es1:
// Definiamo i piccoli pezzi del binario
public Either<Error, User> ValidateEmail(User user) => 
    user.Email.Contains("@") ? Right(user) : Left(Errors.InvalidEmail);

public Either<Error, User> CheckUserExists(User user) => 
    _db.Exists(user.Email) ? Left(Errors.UserAlreadyExists) : Right(user);

public Either<Error, Unit> PersistUser(User user) => 
    _db.Save(user) ? Right(unit) : Left(Errors.DatabaseError);

// Costruiamo la catena ROP
public Either<Error, Unit> RegisterWorkflow(User user) =>
    Right(user)               // Partiamo sul binario del successo
        .Bind(ValidateEmail)  // Se fallisce, devia sul binario errore
        .Bind(CheckUserExists)
        .Bind(PersistUser);   // Se arriva qui, salva l'utente
```
