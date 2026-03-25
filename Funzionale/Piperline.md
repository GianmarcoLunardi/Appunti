## Piperline
E' un insieme di funzioni composte , seseguite secondo in concatenazione una dopo l' altra
ogni funzione ha come valore di ritorno Rigth (giusto) e passa alla successiva
Left valore di uscita della piperline.
Usa Map quando la funzione di trasformazione non può fallire (es. cambiare un formato stringa).

Per concatenare le funzioni si utilizza bind
Usa Bind quando anche la funzione successiva restituisce un Either o un Option (evita di avere un Either<Error, Either<Error, Success>>).
Mentre si utilizza il map, per ottenere un tipo base , un valore finale
