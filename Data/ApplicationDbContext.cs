using Microsoft.EntityFrameworkCore;
using moment3.Models;

namespace moment3.Data
{
    // Definierar databaskontexten för applikationen, som används för att interagera med databasen
    public class ApplicationDbContext : DbContext
    {
        // Konstruktor som tar emot DbContextOptions som parameter och skickar det vidare till bas-klassen 
        // Dessa options innehåller inställningar för hur databasen ska konfigureras (t.ex. val av databas).
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet för Authors (Författare). Den här egenskapen gör det möjligt att arbeta med författare i databasen.
        // DbSet är en samling av entiteter som representerar tabellen "Authors" i databasen.
        public DbSet<Author> Authors { get; set; }

        // DbSet för Books (Böcker). Den här egenskapen gör det möjligt att arbeta med böcker i databasen.
        // DbSet representerar tabellen "Books" i databasen och används för att utföra CRUD-operationer på böcker.
        public DbSet<Book> Books { get; set; }
    }
}
