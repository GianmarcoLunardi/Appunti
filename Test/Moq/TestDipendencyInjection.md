** Test di un DJ

```csharp
public class UserService {
private readonly lEmailService emailService; private readonly IllserRepository userRepository;
public UserService(IEmailService emailService, IllserRepository userRepository)
{
emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
userRepository = userRepository ?? throw new
ArgumentNullException(nameof(userRepository));
}
public bool RegisterUser(string email) {
if (string.IsNullOrWhiteSpace(email))
throw new ArgumentException("Email cannot be empty", nameof(email));
if (userRepository.UserExists(email)) return false;
var user = new User { Email = email };
bool registrationSuccessful = userRepository.CreateUser(user);
if (registrationSuccessful) {
return emailservice.SendEmail(email, "Welcome!", "Welcome to our service!");
}
return false;
}
}
```

```csharp
public class UserServiceTests {
private Mock<IEmailService> mockEmailService;
private Mock<IUserRepository> _mockllserRepository;
private UserService userService;
[Setup]
public void Setup() {
mockEmailService = new Mock<IEmailService>(); mockUserRepository = new Mock<IUserRepository>(); userService = new
UserService( mockEmailService.Object, mockUserRepository.Object);
}
[Test]
public void
RegisterUser NewUser SuccessfulRegistrationAndEmailSent() {
// Arrange
string email = "test@example.com"; mockUserRepository.Setup(r =>
r.UserExists(email)).Returns(false);
mockUserRepository.Setup(r =>
r.CreateUser(It.IsAny<User>())).Returns(true);
mockEmailService.Setup(e => e.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
// Act
bool result = userService.RegisterUser(email);
// Assert
Assert.IsT rue(result);
mockUserRepository .Verify( r => r.Createllser(It.Is<User>(u => u.Email == email)), Times.Once);
mockEmailService.Verify(e => e.SendEmail(email, "Welcome!", "Welcome to our service!"), Times.Once);
}
[Test]
public void
RegisterUser ExistingUser RegistrationFailsf)
{
// Arrange
string email = "existing@example.com";
mockUserRepository.Setup(r => r.UserExists(email)).Returns(true);
// Act
bool result = userService.RegisterUser(email);
// Assert
Assert.IsFalse(result);
mockUserRepository.Verify(r => r.CreateUser(It.IsAny<User>()), Times.Never);
mockEmailService.Verify(e =>
e.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
}
[Test]
public void
RegisterUser EmptyEmail ThrowsArgumentException() {
// Arrange string email =
// Act & Assert
Assert.Throws<ArgumentException>(() => userService.RegisterUser(email));
}
}
```

## Debugger  
è possibile utilizzare la classe Textcontex per stampare linee di dubugger
```csharp
[Test] public void TestWithContext() {
Testcontext.WriteLine("Custom debug information"); // Test code here }
```csharp
