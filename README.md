## Bokhanteringsapplikation

Detta projekt är en ASP.NET Core MVC-applikation för att hantera böcker och deras författare. Användaren kan skapa, visa, redigera och ta bort böcker samt koppla dem till författare.

# Funktionalitet

Lista böcker och deras författare

Skapa nya böcker och författare

Redigera befintliga böcker

Visa detaljer om en bok

Ta bort böcker

# Teknologier

ASP.NET Core MVC

Entity Framework Core

MySQL (eller annan databas via EF Core)

Razor Views

Databasmodell

# Applikationen innehåller två huvudmodeller:

Book: Representerar en bok med egenskaper som Titel, Utgivningsår och en koppling till en författare.

Author: Representerar en författare och kan ha flera böcker kopplade till sig (1:N-relation).

## Installation


Installera beroenden:

dotnet restore

Konfigurera databasen i appsettings.json.

Applicera migrationer och uppdatera databasen:

dotnet ef database update

Starta applikationen:

dotnet run

Användning

Navigera till webbplatsens startpunkt och använd gränssnittet för att hantera böcker och författare.

## Förbättringsområden

Implementera autentisering och användarroller

Lägg till en sökfunktion


