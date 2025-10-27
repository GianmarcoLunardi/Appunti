## publishing
consente di generare un file immagine e di caricarlo nel docker locale

Nel file di progetto impostare il nome del contenitore
```
<ItemGroup>
  <PropertyGroup>
    <ContainerRepository>Nome_Container</ContainerRepository>
</PropertyGroup>
```

Si esegue il comando dentro la directori in cui risiede il progetto

```
dot publish --os linux --arch x64 /t:Nome_Container -c realise
```
il comando genera un immagine , il cui nome sarà poi fornito a fine compilazione
potrà essere letto dalla UI Docker local oppure *docker rum --name Nome_Container*

** Annotazioni: nel caso si tratti di un api , con un unterfaccia swagger, si ricordi di cambire il file program.cs
in quanto per default viene avviato in versione Development , mente Docker avvia l applicazione in _production mode_

Annotazione: UI Docker quando aore il brosware può generare pagina non trovata in quanto bosognerebbe configurare 
url e la porta di accesso **
