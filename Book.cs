using System.ComponentModel.DataAnnotations;

namespace moment3.Models
{
    // Definierar modellen för en Book (Bok)
    public class Book
    {
        // Unikt identifieringsnummer för boken
        public int Id { get; set; }

        // Titel på boken. Den är obligatorisk, därför används [Required] attributet.
        // Detta betyder att titeln måste anges när boken skapas eller uppdateras.
        [Required]
        public string? Title { get; set; }

        // Året då boken släpptes
        [Required]
        public int Year { get; set; }

        // Författarens ID

        public int AuthorId { get; set; }

        // Författaren till boken. Detta är en navigation property som skapar en relation mellan Book och Author.

        public Author? Author { get; set; }
    }
}
