using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Jeu
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateSortie { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int JoueurId { get; set; }

        
        public Joueur Joueur { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Le score doit être compris entre 0 et 100.")]
        public int ScoreJoueur { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateEnregistrement { get; set; }
    }

    
}
