// Definizione dell Interfaccia del servizio

public interface lEmailService 
{
 bool SendEmail(string to, string subject, string body); 
} 

// è omessa l implementazionde del servizio
//Sotto viene creata una classe che utilizza il servizio per esempio un controller


public class UserService_Controller
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
