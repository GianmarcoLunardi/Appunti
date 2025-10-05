 [TestFixture]
   public class ProductApilntegrationTests 
    {
       private WebApplicationFactory<Program> factory;
 private HttpClient client;
 [OneTimeSetUp]
 public void OneTimeSetUp() 
{
 factory = new WebApplicationFactory<Program>(); 
client = factory.CreateClient();
 }
 [OneTimeTea rDown]
 public void OneTimeTearDown() 
{
 client.Disposef);
 factory.Dispose(); 
}
 [Test]
 public async Task
 GetProducts ReturnsSuccessAndProducts()
{
 // Arrange
 // (Assume products are seeded in the test database)
 // Act 
var response = await 
client.GetAsync("/api/products");
 // Assert 
response.EnsureSuccessStatusCode(); 
var content = await
 response.Content.ReadAsStringAsync(); 
var products =
 JsonSerializer .Deserialize<List<Product»(content);
 Assert.That(products, Is.Not.Null); 
Assert.That(products, Is.Not.Empty); 
}
 [Test]
 public async Task
 CreateProduct ValidProduct ReturnsCreatedResponse() 
{
 // Arrange 
var newProduct = new Product 
{
 Name = "New Test Product",
 Description = "A new product for testing", 
Price = 29.99m 
};
 var json = JsonSerializer.Serialize(newProduct);
 var content = new StringContent(json, Encoding.UTF8, 
"application/j son");
// Act
 var response = await 
client.PostAsync("/api/products", content);
 // Assert
 Assert.That(response.StatusCode, 
Is.EqualTo(HttpStatusCode.Created));
 var responsecontent = await 
response.Content.ReadAsStringAsync();
 var createdProduct = 
JsonSerializer.Deserialize<Product>(responsecontent);
 Assert.That(createdProduct, Is.Not.Null);
 Assert.ThatfcreatedProduct.Id, Is.GreaterThan(O));
 Assert.That(createdProduct.Name, Is.EqualTof"New 
Test Product"));
 }
 }
