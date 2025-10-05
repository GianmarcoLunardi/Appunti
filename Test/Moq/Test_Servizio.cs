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
