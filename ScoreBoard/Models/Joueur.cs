using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Joueur
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-z]{2,20}$", ErrorMessage =
        "Le champs nom doit être entre 2 et 20 caractères.")]
        public string Nom { get; set; }

        [Required]
        [RegularExpression(@"^[a-z]{2,20}$", ErrorMessage =
        "Le champs prenom doit être entre 2 et 20 caractères.")]
        public string Prenom { get; set; }

        [RegularExpression(@"^(?:[^A-Z]*[A-Z]){2,4}[^A-Z]*$", ErrorMessage =
        "Le champs équipe doit avoir 2 à 4 lettres majuscules.")]
        public string? Equipe { get; set; }
        public string? Telephone { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage =
        "Le champs doit être par exemple Identifiant@scoreboard.ca .")]
        public string Courriel { get; set; }
        public List<Jeu>? Jeux { get; set; }
    }
}
