# Bageriet
Kontinuerlig inlämningsuppgift för kursen Dynamiska Webbsystem 1

I denna uppgift ska du skapa din första riktiga webbapplikation i C#, kunden är i detta fallet en bagare som vill lägga upp sina tillgängliga produkter på en hemsida. Kunden vill ha kunna visa sina kontaktuppgifter och tillgängliga produkter. I framtiden ska hemsidan byggas ut med stöd för direktbeställningar från nätet - men nu vill bagaren ha en första sida klar så snart som möjligt!

### Kravspecifikation:
(Bageriet 1.0)

*   Lösningen ska bestå av en körbar ASP.NET applikation skriven i C# (netcoreapp2.2 eller netcoreapp3.0).
*   Du ska tillämpa designmönstret Model View Controller (MVC).
*   Man ska från en sida kunna se bageriets kontaktuppgifter.
*   Man ska på en annan sida kunna lista alla tillgängliga produkter från bageriet.
*   Dom tillgängliga produkterna ska vara sparade i en lista ( förslagsvis av typen _**List<Product>**_)


### Kravspecifikation:
(Bageriet 3.0)
* En besökare ska kunna registera sig som en användare på hemsidan
* En besökare som registerat sig ska kunna logga in som en användare på hemsidan
* En inloggad användare ska kunna lämna kommentarer på en given typ av produkt/bakelse
* En inloggad användare ska kunna lämna ett betyg på en given typ av produkt/bakelse, betyget ska vara mellan 1 och 5
* Det genomsnittliga betyget på en produkt/bakelse ska visas för alla besökare på sidan.
* Kommentarer på produkter/bakelser ska visas för alla besökare på sidan.
