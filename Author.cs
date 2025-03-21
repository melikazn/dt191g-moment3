using System.ComponentModel.DataAnnotations;

namespace moment3.Models
{
    // Definierar modellen för en Author
    public class Author
    {
        // Unikt identifieringsnummer för författaren
        public int Id { get; set; }
        [Required]
        // Namnet på författaren
        public string Name { get; set; }

        // Lista över böcker som författaren har skrivit. 
        // Den är nullable, vilket innebär att det kan vara null om ingen bok är kopplad till författaren.
        public List<Book>? Books { get; set; }
    }
}
