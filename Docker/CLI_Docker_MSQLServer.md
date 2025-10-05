hub.docker.com
Sito che contiene le immagini docked

Si sceglie l immagine che si desidera scaticare nel nostro caso MSQLS Server

__Da Riga di Comando__

Docker pull .mcr.microsoft.com/msql/server
*il pul consentira di fare il downloa dell  immagine*
l immagine sarà scaricata, inoltre sara visibile anche dall app docker

Avviare l immagine con paramentri
_docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456a@' -p 1400:1433 -d mcr.microsoft.com/mssql/server:2019-latest_
-e SA_PASSWORD=123456a@'  assegnazione all utente sa la passqwped
-p fa il mapping delle porte 1400:1433  per non generare conflitti sualla porta sql locale con quella ( si imposta su docker 1400)
-d mcr.microsoft.com/mssql/server:2019-latest specifica quale immagine avviare
--name mio_container \
--hostname webserver01 \


Per la configurazione dei cuntiner, possibile utilizza Docker UI
Per La Lettura delle tabelle è possibile configurare mmc con porta e nome host dell immagine docker

_docker ps_ lista di tutti i containe

_cocker start <nome container>
nel momento in cui si avviano i container è bene dare agli host nomi 

__ è possibile utilizzare Docker UI __

Nel quale poi è possibile leggere i dati della tabella
