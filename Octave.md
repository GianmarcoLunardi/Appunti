# Octave
Linguaggio di programmazione matematico

variabili (ha autoriconoscimento del tipo)

I tipi itulizzati: interi , reali , immaginari (il compilatore riconmosce il tipo con la semplice assegnazione)
```octave
Reale = 1.2;
Immaginario = 5 +i2;
intero = 4;
```
## Linguaggio Funzionale

help()
clc pulisce il terminale
clear() cancella una variabile
clear all
un file Octave ha un estensione .m per eseguilo sulla basta scrivere il nome mensa estinzione nel prompt

## Operazioni sui dati scalari

+,-,/,* 
sin, cos, tag su radianti 
conversioni da gradi a radianti
r = deg2rad(180);  % Risultato: 3.1416 (pi)
gradi = rad2deg(radianti)
pi e' il pgreco
hypot(a, b) calcola l ipotenusa con il teorema di pitagora

## Matrici
una matrice è una tabella ordinata di elementi disposti su righe e colonne.
le matrici sono generalmente indicate con le lettere maiuscole es A, B
un matrice di una sola riga e' chiamata vettore , la rappresentazione id matrici e evettori

```octave

% Matrice 3x3 (3 righe, 3 colonne)
A = [1,  2,  3; 
     4,  5,  6; 
     7,  8,  9]
% Lettura di un elemento
printf( A(1,2) );
% Vettore colonna 4x1 (elementi separati da punto e virgola)
v_col = [1; 3; 5; 7]
```
## Stampa di Funzioni

stampa di valori scalari
printf("Pi con 2 decimali: %.2f\n", pi_greco);

Stampa di piu punti per ottenere un grafico.

```octave
% PERSONALIZZAZIONE GRAFICO
% title('Titolo del Grafico')	Aggiunge il titolo in alto
% xlabel('Asse X')	Inserisce l'etichetta dell'asse X
% ylabel('Asse Y')	Inserisce l'etichetta dell'asse Y
% grid on / grid off	Attiva o disattiva la griglia di sfondo
% legend('Serie 1', 'Serie 2')	Mostra la legenda dei dati
% xlim([min, max])	Imposta i limiti visibili dell'asse X
% ylim([min, max])	Imposta i limiti visibili dell'asse Y

% Definizione dei punti sul asse x
VettX = [1,  2,  3,  4,  5,  6];
% Definizione dei valori dei punti del codomini da utilizzare il pinto .
VettY = sen(VettX.);
% Lettura di un elemento
plot(VettX,Vetty);
% Vettore colonna 4x1 (elementi separati da punto e virgola)

hold on; % Mantiene la figura corrente attiva

% Secondo grafico (Coseno in blu tratteggiato) plot(x, y2, '--b', 'LineWidth', 2);
```





