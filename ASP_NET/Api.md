
olte alle acrion è possibile creare delle Api per rendere il file più standar
```csharp
  #region

        public async Task<IEnumerable<Prodotto>> GetAllAsync()
        {
            List risultato = await _context.Prodotti.ToListAsync();
            return Json( new { data = risultato}); // Ok(new { data = risultato});
        }
Endrigion

  __notare__ che il contenuto della jsono viene forsato a essere restituito come json
  puo essere usato anche il comando _ok(data)_
