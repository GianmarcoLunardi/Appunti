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
