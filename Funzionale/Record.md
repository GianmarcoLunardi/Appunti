## Definizione di un Record
é immutabile, dichiarazione
'''
public record Persona(string Nome, int Età);
'''
Creazione di un'Istanza
'''
var persona1 = new Persona("Mario", 30);
var persona2 = new Persona("Giulia", 25);
'''
# Eguaglianza per Valore
'''
var persona1 = new Persona("Mario", 30);
var persona2 = new Persona("Mario", 30);

'''
bool sonoUguali = persona1 == persona2; // true
'''
