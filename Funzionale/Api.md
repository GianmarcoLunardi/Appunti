** Creare un api in modo funzionale
problea: Dato un codice , si deve fare un action che restitutisca i dettogli del prodotto 

```
public class InstrumentsController : Controller
  {
// viene definita una funzione che prende in input cosice e ha come output un oggetto
   Func<string, Option<InstrumentDetails>> Cerc_Oggetti ;

  [HttpGet, Route("api/instruments/{ticker}/details")]
  public IActionResult GetInstrumentDetails(string ticker)
      => Cerc_Oggetti(ticker)
          .Match<IActionResult>(
          () => NotFound(),    //Caso in cui option è none
          (result) => Ok(result)  //Caso in cui viene trovato e si ritorna il json
          );
  }
}
```

Al fine di gestire meglio dipi di dato che descrivono gli errori <br>
Either<L, R>    Right  Left L <br>
Validation<T>   Valid Invalid IEnumerable<Error><br>
Exceptional<T>  Success Exception Exception<br>
