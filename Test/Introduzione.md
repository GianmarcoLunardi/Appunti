


  

##Tipi di Test##
      -Unitt
      Sono test senza dipendenze esterne
      -integration
      sono test con dipendenze estene come esempio db o file.
      -End-To-End 
      test che sono eseguibili sull interfaccia grafica
   
    
      In visual studio installare i pacchetti

        Nunit
        Nunit3TestApplication
        Microsoft.Test.Application
      
     **Convenzione sul nome dei file< 
      -Una Soluzione di tipo Test si chiama con il nome della soluzione.test.Adapter
      Es: si vuole testare la soluzione EcdlBooking il test sulla soluzione si chiamera EcdlBooking.test
      
      -Le struttura della cartelle della soluzione deve essere uguale nella soluzione da testate

  **Creazione dei Test con Visual Studio**
  -Alla creazione del progetto:
   -Dopo la creazione del progetto:
    da Esplora soluzione Cliccare sul progetto>selezionare supporto Docker
      la file lauchsetting.json verrà aggiunto un profilo Docker

        Nb: nwl lmomento in cui si avvia un progetto docker addicurarzi che tutti i progetti docker collegati siano avviati: sqlserver, Api, Front End
       </div>
    </div>



      
      -convenzione sul nome del metodo del test:
      NoneMetodo_CasoDelTest_Risultato

     Esempio di codice


    [TestFixture]
    internal class ClasseTest
    {
       
       [Fact] 
        public void TMetodo_CasoDelTest_Risultato()
        {

            *Arrange< continie inizializzazione delle variabili da testare
            int i = 0;
            *Act contiene il metodo da testare
            var result = math.Add(1);
            Assertion Confronta i risultati con quelli sperati
            result.Assert(result, verifica una condizione)
           
            
        }
      }

        
        Al dine di creare un metodo di inizailizzazione di una classe 
        [setup]
        public void SetUp(){
        IService _service = new Mock<Iservice>();
        }
        
      
      
       **Attibuti che si possono mettere al metodo da testare
       
      [Test, TimeOut(5000)] // tempo massimo di completamento 5 sec
      [Categoty("nome della categoria che si vuole assegnare")]<br>
      [Ingnore("motivo per cui si vuole ignorare un test es: lento da eseguire")]<br>
      [TestCase(1,2,3)]
      [TestCase(4.5.6)]
      metido_da_testare (int a , int b, int c)        {
      {
      var result math(a,b);
      Aseert(c, IsEqual(c))     
            
        }
      
      *Possibili Assert 
      per stringhe , array
      Assert.That(stringa, IsNotEmpty())
      Assert.That(stringa, DoesStarWith(""))
      Assert.That(stringa, DoesContain(""))
      Assert.That(stringa, Has.Lenth.CraracterThen(10))
      -Collezioni
      Assert.That(collezione, Has.Count.EqualTo(5))
      Assert.That(collezione, Conmtain.Items(5))
      Assert.That(collezione, IsOrdered())
      -Su singoli valori
      Assert.AreEqual(a, b)
      Assert.IsFalse(r)
      Assert.IsNull(r)
      è possibile fornire anche una desctizione sul risultato  es: Asser.IsNull(a,"descrizione")<br>
      
      
      
    <spamc lass=".text-success"> Alla creazione del progetto: </spam> spuntare Docker
    <spamc lass=".text-success"> Dopo la creazione del progetto: </spam> 
      da Esplora soluzione Cliccare sul progetto>selezionare supporto Docker
      la file lauchsetting.json verrà aggiunto un profilo Docker
      <br>
    <div class="Container">
      <div class="alert alert-primary" role="alert">
        Nb: nwl lmomento in cui si avvia un progetto docker addicurarzi che tutti i progetti docker collegati siano avviati: sqlserver, Api, Front End
       </div>
    </div>
     <br>
     <br>
        

  <!-- Fine Della PAgina Visual Studio-->  

      <!-- Inizio della pagina come fare un docker sqlserver -->
       <h3> Creare un immagine docker per sql </h3>
      <br>
      
        <a href="https://hub.docker.com/" target="_blank"> https://hub.docker.com/ </a>
     
      Sito che contiene tutte immagini docked </br>

Dalla Gui di dicke c' un casella per cercare in immagine da scaricare  nostro caso MSQLS Server<br>

Da Riga di Comando<br>
Docker pull .mcr.microsoft.com/msql/server 
<br><br>
      
<h3 >Mettere in esecuzione l immagine </h3>
      <p class=".text-dark-emphasis">
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=123456a@' -p 1400:1433 -d mcr.microsoft.com/mssql/server:2019-latest -e SA_PASSWORD=123456a@' assegnazione all utente sa la passqwped -p fa il mapping delle porte 1400:1433 per non generare conflitti sualla porta sql locale con quella ( si imposta su docker 1400) -d mcr.microsoft.com/mssql/server:2019-latest specifica quale immagine avviare --name mio_container
--hostname webserver01 </p>
      <div class="container">
      -p 1400:1433 questo fa il mapping delle porte <br>
      1433 è la pprta di comunicanzion dei mssqul di default <br>
      1400 è la porta che verrà utilizzata per accere da smqlserver dentro Docker <br>
      -d mcr.microsoft.com/mssql/server:2019-latest specifica quale immagine avviare<br>
      --name mio_container
      --hostname webserver01 , è il nome da dare all host 
        <br>
Per la configurazione dei cuntiner, possibile utilizza Docker UI Per La Lettura delle tabelle è possibile configurare mmc con porta e nome host dell immagine docker
      </div>

 <p class=".text-dark-emphasis">     
docker ps lista di tutti i containe
 </p>
 <br> <br>

    <div class="Container">
      <div class="alert alert-primary" role="alert">
        Per la configurazione dei cuntiner, possibile utilizza Docker UI Per La Lettura delle tabelle è possibile configurare mmc con porta e nome host dell immagine docker
      </div>
    </div>
      

Nel quale poi è possibile leggere i dati della tabella


      </div>
      <!-- Fine della pagina docker fine pagina -->
      
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.min.js" integrity="sha384-G/EV+4j2dNv+tEPo3++6LCgdCROaejBqfUeNjuKAiuXbjrxilcCdDz6ZAVfHWe1Y" crossorigin="anonymous"></script>
    
    </body>
</html>
