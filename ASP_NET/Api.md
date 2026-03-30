## Viste
Con le action si possono creare la logica delle _viste_ 

```csharp
        public IActionResult Index() 
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
           
            return View(objCompanyList);
        }
```
##API
olte alle action è possibile creare delle Api per rendere il file più standar
usando i comando OK() ecc
```csharp
  #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = objCompanyList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var CompanyToBeDeleted = _unitOfWork.Company.Get(u => u.Id == id);
            if (CompanyToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Company.Remove(CompanyToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion

  __notare__ che il contenuto della jsono viene forsato a essere restituito come json
  puo essere usato anche il comando _ok(data)_
