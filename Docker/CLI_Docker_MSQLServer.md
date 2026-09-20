## Gli strumenti grafici di configurazioni 
Docker UI
Microsoft MMC Per la lettura e le eventuali interrogazioni sulle tabelle  sql
>con porta e nome host dell immagine docker


## Configurazione da terminale
Sito che contiene le immagini docker [Docker Hub](https://hub.docker.com)
# Immagine SQL Server
Si sceglie l immagine che si desidera scaticare nel nostro caso MSQLS Server
Per la scelta del db, non c'e da sottovalutare MariaDB che puo' girare su so Linux


Docker pull .mcr.microsoft.com/msql/server
*il pul consentira di fare il downloa dell  immagine*
l immagine sarà scaricata, inoltre sara visibile anche dall app docker

Avviare l immagine con paramentri
Scaricare Immagine Docker di Sql Server 
```console
Docker pull .mcr.microsoft.com/msql/server

Avviare l immagine con paramentri

_docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456a@' -p 1400:1433 -d mcr.microsoft.com/mssql/server:2019-latest_
-e SA_PASSWORD=123456a@'  assegnazione all utente sa la passqwped
-p fa il mapping delle porte 1400:1433  per non generare conflitti sualla porta sql locale con quella ( si imposta su docker 1400)
-d mcr.microsoft.com/mssql/server:2019-latest specifica quale immagine avviare se non c'è la scarica
--name mio_container \
--hostname webserver01 \
```



## Lista delle immagini scaricate
```console
_docker ps_ lista di tutti i containe
```

## Avvio di una container 
```console
_docker start <nome container>
nel momento in cui si avviano i container è bene dare agli host nomi 
```
__ è possibile utilizzare Docker UI __

Nel quale poi è possibile leggere i dati della tabella

> durante il mapping delle porte  dei container , spesso viene cambiato il valore
> per poterle utilizzare , bisogna anche aggiornare url della connection-string
> infine fare il seeding tramite una migrazione*
