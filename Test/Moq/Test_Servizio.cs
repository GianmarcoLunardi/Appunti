// Questo tipo di test viene utilizzato generalmente quando un controller chiama di DI
// un servizio , che interroga un db o un file esterno
// Il moq simula il servizio e isola la l iterazione con l esterno

using System.Threading;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

[Test]
 public void RegisterUser () 
{
  var mockEmailService = new Mock<IEmailService>();  
   // Arrange Inizializzazione del servizio 
   // Si vuole simulare un servizio che invia una mail 
   // e si vuole conficurare il metodi setup(strin indirizzo, string soggetto, string corpo)
   // It.IsAny<T> un qualsiasi valore di tipo T
  mockEmailService.Setup(m => m.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
 .Returns(true);

 //si chiama istanza il servizio
 var userService = new UserService(mockEmailService.Object);
 // Act 
 bool result =  userService.RegisterUser("test@example.com");
 // Assert
 Assert.IsTrue(result);


   
 mockEmailService.Verify(m =>
 m.SendEmail("test@example.com", "Welcome!", "Welcome to our 
service!"), Times.Once);
 }
