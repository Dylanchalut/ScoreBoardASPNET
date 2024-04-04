using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class CatalogueJoueursBdContext : DbContext
    {
        public CatalogueJoueursBdContext(DbContextOptions<CatalogueJoueursBdContext> options) : base(options)
        {
        }

        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Jeu> Jeux { get; set; }
    }
}
