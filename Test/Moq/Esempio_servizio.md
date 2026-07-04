## Libreria Moq 
 serve per simulare un servizio eesterno, viene inserito dentro al classe trami una dependency injectiom
csharp```

// Definizione dell Interfaccia del servizio

public interface lEmailService 
{
 bool SendEmail(string to, string subject, string body); 
} 

// è omessa l implementazionde del servizio
//Sotto viene creata una classe che utilizza il servizio per esempio un controller


// Nella classe Controller
// si vuole testare metodo RegisterUser(string email) 
// La classe controller instanza una DI del Servizio di mailService
// poi ritorna true o folse a secondo di cone è andato l esecuzione del servizio

public class Controller
{
 private readonly IEmailService _emailService;
 // viiene instanziata la DI
  public UserService(IEmailService emailService) 
     {
     _emailService = emailService;
     }

   public bool RegisterUser(string email)
     {
       // Some registration logic...
       bool registrationSuccessful = true;
       if (registrationSuccessful) 
          {
           return _emailService.SendEmail(email, "Welcome!", "Welcome to our service!");
          }
      return false;
    }
 }
```
Per simulare il sevizio 

```csharp
// Questo tipo di test viene utilizzato generalmente quando un controller chiama di DI
// un servizio , che interroga un db o un file esterno
// Il moq simula il servizio e isola la l iterazione con l esterno

using System.Threading;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

[Test]
 public void Controller_UtilizzaServioMail_RitornaOK() 
{
  var mockEmailService = new Mock<IEmailService>();  
   // Arrange Inizializzazione del servizio 
   // Si vuole simulare un servizio che invia una mail 
   // e si vuole conficurare il metodi setup(strin indirizzo, string soggetto, string corpo)
   // It.IsAny<T> un qualsiasi valore di tipo T
  mockEmailService.Setup(m => m.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
 .Returns(true);

 //si istanz1a la classe Controller che poi chimera la DI del Servizio
 var Controller = new UserService(mockEmailService.Object);
 // Act 
 bool result =  Controller.RegisterUser("test@example.com");
 // Assert
 Assert.IsTrue(result);


 // è possibile verifica anche uno specifico paramentro della chiamata al servizio
 Controller.Verify(m =>
 m.SendEmail("test@example.com", "Welcome!", "Welcome to our service!"), Times.Once); 
  // inoltre specifica che il servizio è stato chiamato una sola volta
 }
** note:
Il Moq può implementare più metodi 
 mockEmailService.Setup(m => m.**SendEmail1**(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
 .Returns(true);
 mockEmailService.Setup(m => **m.SendEmail2**(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
 .Returns(true);

La Argomento è It. 
It.IsAny<string>()  controllo sul tipo stringa
(It.Is<string>(u => u.value == "Name1") controllo si tipo e valore

Per metrodi asyncroni
.ReturnsAsync()
```
