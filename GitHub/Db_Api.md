## Database
Si utilizza database in memenoria che simulano il database

```csharp
[Test]
public async Task
    CreateProduct ValidProduct SavesToDatabase() {
    // Arrange
    var product = new Product
        {
          Name = "Test Product", Description = "A product for testing", Price = 19.99m
        };

      // Act
      var createdProduct = await
      productService.CreateProductAsync(product);

      // Assert
      Assert.That(createdProduct.Id, Is.GreaterThan(0));
      // Verify product was saved to the database
    using (var dbContext = new TestDbContext()) { var savedProduct = await
          dbContext.Products.FindAsyncfcreatedProduct. Id);
          Assert.That(savedProduct, Is.Not.Null);
          Assert.That(savedProduct.Name, Is.EqualTo("Test Product"));
        Assert.That(savedProduct.Price, Is.EqualTo(19.99m)); }
      }
```
