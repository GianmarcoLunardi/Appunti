##Cloud native application 
è un programma strutturato per l archuitetteura Ccomposta da  una collezioni di piccoli pezzezzi indipendenti chiamati Microservice che interagiscono fra loro.



# Visual Studio 22

-Alla creazione del progetto: spuntare Docker
-oppure dopo la creazione del progetto: 
    da Esplora soluzione Cliccare sul progetto>selezionare supporto Docker
    
la file lauchsetting.json verrà aggiunto un profilo Docker
    
'Nb: nel momento in cui si avvia un progetto docker addicurarzi che tutti i progetti docker collegati siano avviati: sqlserver, Api, Front End'

Creazione di una Immagine tramite Cli

Scaricare un immagine docker per sql Server
[Docker Hub](https://hub.docker.com/)
è un sito web sito che contiene tutte immagini docked,
vi è fornita una piccola descrizione per l istallazione , indica il SO su cui risiede.

### Sacaricare immagine tramite Tramite CLI
```
Docker pull .mcr.microsoft.com/msql/server 
```
-pull <url dell immaggine da scaricare>

### Docker Run 
Consente di mette in esecuzione l immagine 
Nel caso disql server, l immagine ha dei paramitri aggiuntivi in quanto è coperta da copywrite

```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456a@' -p 1400:1433 mcr.microsoft.com/mssql/server:2025-latest --name "Container_Sql" --hostname NomeWebserver -d   
  
```
   
-e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456a@' accettazione della licenza
e l assegnazione di una password per l utente sa
-p 1400:1433 questo fa il mapping delle porte 
1433 è la pprta di comunicanzion dei mssqul di default <br>
1400 è la porta che verrà utilizzata per accere da smqlserver dentro Docker <br>
-d mcr.microsoft.com/mssql/server:2019-latest specifica quale immagine avviare
--name mio_container
--hostname nome del webservwe alternativo al local host
    
## SQL Server
Per La Lettura delle tabelle è possibile configurare mmc con porta e nome host dell immagine docker
  oppure Azure Data Studio

Docker ha la possibilitò di utilizzare un interfaccia grafica per avviare, mettere in pausa, stoppare e configurare le immagini *inspect*


  ## Altri comando Docker Cli
```
    docker run docker/whale cawsay Ciao
```
    viene lancata l iammagine docker/whale, viene lanciato il programma sawsay e al programma viene passata la stringa Ciao
```
    docker run -p 8080:80 nginx
```
    si apre explorer sulla porta 80 con local host , viene fatta una richiesta al webserver nginx
```
    docker ps -a
```
    viene fatta la lista delle immagini e il loro stato

```
    docker rm   00000000000000
```
 viene cancellato un containe con id 00000000   

 ```
    docker start image
```
    viene avviata il file image
    
<!--
Indirizzo url
https://gianmarcolunardi.github.io/Appunti/Docker/docker.html#
-->

