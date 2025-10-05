// Esempio di un api da testare

 public class Book 
{
 public int Id { get; set; }
 public string Title { get; set; }
 public string Author { get; set; }
 public int Year { get; set; } 
}
   public class BooksController : ControllerBase 
  {
     private static List<Book> books = new List<Book>();
     
     [HttpGet]
     public ActionResult<IEnumerable<Book» Get() 
      {
         return 0k( books);
       }
       
     [HttpGet("{id}")]
     public ActionResult<Book> Get(int id) 
      {
       var book = books.FirstOrDefault(b => b.Id == id); 
        if (book == null)
           return NotFound();
       return Ok(book);
      }
      
   [HttpPost]
   public ActionResult<Book> Post([FromBody] Book book) 
    {
     book.Id = books.Count + 1;
     books.Add(book);
     return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
   }
   
   [HttpPut("{id}")]
   public lActionResult Put(int id, [FromBody] Book book) 
    {
     var existingBook = books.FirstOrDefault(b => b.Id == id);
     if (existingBook == null) 
      return NotFoundO;
       existingBook.Title = book.Title;
       existingBook.Author = book.Author;
       existingBook.Year = book.Year;
     return NoContentO;
   }
   
 [HttpDelete("{id}")]
 public lActionResult Delete(int id) 
    {
       var book = books.FirstOrDefault(b => b.Id == id);
       if (book == null)
       return NotFound();
       books.Remove(book);
      return NoContent()
    }
}
