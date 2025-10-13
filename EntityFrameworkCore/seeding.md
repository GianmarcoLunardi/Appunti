 # Fluent API 
 utilizza **HasData** all’interno di **OnModelCreating** per inserire ruoli, utenti e associazioni utente-ruolo in modo statico

  Caso in cui si voglia inserire un Identity user bisogna controllare bene che gli attibuti della classe siano generati da funzioni costanti che non cambiamo a ogni iterazione
  

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
       
        '''
        modelBuilder.Entity<ApplicationUser>().HasData(
        new ApplicationUser {
        Id = "9f5de216-b03f-43d2-b0a1-4f9d6bb5c126",
        UserName = "Gianmarco_Lunardi",
        NormalizedUserName = "GIANMARCO_LUNARDI",
        Email = "gianmarco.lunardi@iis-bressanone.edu.com",
        NormalizedEmail = "GIANMARCO.LUNARDI@IIS-BRESSANONE.EDU.COM",
        EmailConfirmed = true,
        IdSchool = Guid.Parse("a361e1b4-5427-463c-abc8-f2f176821181"),
        PasswordHash = "AQAAAAEAACcQAAAAEXAMPLE_STATIC_HASH_GENERATED_ONCE",  / in questo caso la pasword è stata generata separatamente tramite l ai
        SecurityStamp = "c4f6e9a4-1111-2222-3333-aaaaaaaaaaaa",               /SecurityStamp, e Concorrency gli è stato assefba due valori                                    
        ConcurrencyStamp = "d7b2c9f0-4444-5555-6666-bbbbbbbbbbbb"'''          /creati dal generatore GUID <a href="[https://openai.com](https://www.guidgenerator.com/)" target="_blank" rel="noopener">GUID</a>
    }
);'
}
