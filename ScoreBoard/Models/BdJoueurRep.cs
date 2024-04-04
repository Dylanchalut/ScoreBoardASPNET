using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class BdJoueurRep : IJoueurRepository
    {
        private readonly CatalogueJoueursBdContext _catalogueJoueursBdContext;

        public BdJoueurRep(CatalogueJoueursBdContext catalogueJoueursBdContext)
        {
            _catalogueJoueursBdContext = catalogueJoueursBdContext;
        }

        public IEnumerable<Joueur> ListeJoueurs => _catalogueJoueursBdContext.Joueurs.ToList();

        public void AjouterJoueur(Joueur joueur)
        {
            _catalogueJoueursBdContext.Joueurs.Add(joueur);
            _catalogueJoueursBdContext.SaveChanges();
        }

        public Joueur? GetJoueur(int id)
        {
            return _catalogueJoueursBdContext.Joueurs.Include(g => g.Jeux).FirstOrDefault(g => g.Id == id);
        }

        public void ModifierJoueur(Joueur joueur)
        {
            _catalogueJoueursBdContext.Joueurs.Update(joueur);
            _catalogueJoueursBdContext.SaveChanges();
        }

        public void SupprimerJoueur(int id)
        {
            _catalogueJoueursBdContext.Joueurs.Remove(GetJoueur(id));
            _catalogueJoueursBdContext.SaveChanges();
        }

    }
}
