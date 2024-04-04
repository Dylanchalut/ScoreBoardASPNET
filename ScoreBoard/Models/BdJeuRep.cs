using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class BdJeuRep : IJeuRep
    {
        private readonly CatalogueJoueursBdContext _catalogueJoueursBdContext;

        public BdJeuRep(CatalogueJoueursBdContext catalogueJoueursBdContext)
        {
            _catalogueJoueursBdContext = catalogueJoueursBdContext;
        }

        public IEnumerable<Jeu> ListeJeux => _catalogueJoueursBdContext.Jeux.Include(j => j.Joueur).ToList();

        public void AjouterJeu(Jeu jeu)
        {
            _catalogueJoueursBdContext.Jeux.Add(jeu);
            _catalogueJoueursBdContext.SaveChanges();
        }

        public Jeu? GetJeu(int id)
        {
            return _catalogueJoueursBdContext.Jeux.Include(j => j.Joueur).ToList().FirstOrDefault(g => g.Id == id);
        }

        public void ModifierJeu(Jeu jeu)
        {
            _catalogueJoueursBdContext.Jeux.Update(jeu);
            _catalogueJoueursBdContext.SaveChanges();
        }

        public void SupprimerJeu(int id)
        {
            _catalogueJoueursBdContext.Jeux.Remove(GetJeu(id));
            _catalogueJoueursBdContext.SaveChanges();
        }
    }
}
