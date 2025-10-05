[Test] 
public void UserValidationTest() 
	{ 
		User user = new User 
			{
			 Name = "John Doe", 
				Email = "john@example.com", 
				Age = 30 
			};

	
 		Assert.Multiple(() => 
			{
			Assert.That(user.Name, Is.Not.Empty, "Name should not be empty");
 			Assert.That(user.Email, Does.Contain("@"), "Email should contain @");
 			Assert.That(user.Age, Is.GreaterThan(18), "User should be an adult");
 			});
 }
