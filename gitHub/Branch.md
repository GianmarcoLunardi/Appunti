### Installazione git
`git inint`
crea una cartella .git dove verrà salvato la repository Git

Possibilità di ottenere il codice dal github
`git clone`
Oppure vi è la possibilità di importare il codice dall git (pc locale) a GitHub (risorsa on line)
posizionarsi sul branch master
`git push origin master`
con questo comando sarà aggiornata la repository on line


### Utilizzo
Durante la scrittura del codice i file per essere visibili a git devono essere inseriti dentro la stagging area.
un aria di tracciatura delle modifiche.

`git add nome_file`

vedere lo stato della stagging area 
`git status`

Poi per poter salvare i cambiamenti sulla repository git bidogna fare il commit
`git commit`

Al momento in cui è stato fatto il commit sulla repository git viene aggiornato lo stato
### utilizzare i branch
* Master
è il branch che rappresenta il codice messo in produzione

visualizzazazione:
`git log`
`git branch`

Spostarsi
`git switch nome-branch`
`git checkout nome-branch`
`git status`

Aggiungere modificare cancellare un brench
sono tutte operazioni da fare da Master


Creazione
git checkout -b nome-branch

Modifica
git branch -m vecchio-nome nuovo-nome

**Merge di un Branch con il Master

è bene controllare le modifiche che verranno apropriate prima del rilascio della della versione
andare sul ramo branche e fare il merge branch verranno così visualizzate le modifiche che verranno fatte prima di modificare il master
poi si va nel master e si esegue il merge del ramo che si vuole fare

