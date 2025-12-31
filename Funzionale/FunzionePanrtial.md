** Function Partial
Dichiarazione di una funzione

FUNCT<T1,T2,T3,,,,,Treslut>

Si vuole scrivere una funzione salutami che restituisce il saluto a una persona

using nome = System.String;
using saluto = System.String;
using SalutoCompleto = System.Strin;

Funct<saluto,nome,SalutoCompleto> Salutami(saluto,nome)=>$"{saluto} {nome}"

Se Faccio Salutami("ciao","gianmarco")  mi risponde // "ciao Gianmarco

Una funzione parziale è una funzione che fissa una delle variavili 
Funct<nome,SalutoCompleto> = BuingiornoSaluto => Salutami("Buongiorno" , nome)

Funzione paziale secondo paramentro
Funct<Saluto,SalutoCompleto> GianmarcoSaluto(saluto) => Salutami(saluto, "gianmarco")

* un modo per riscrivere la funzione in modo piu elegante fissano il primo paramentro .Apply(T1) ApplySecond(T1)
  rirensiamo la prima funzione salutami.Apply("Buongiorno");
  mentre nella secondda BuongionoSaluto("Ciao").ApplySecond("Gianmarco")
