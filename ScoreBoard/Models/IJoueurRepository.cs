namespace ScoreBoard.Models
{
    public interface IJoueurRepository
    {
        public IEnumerable<Joueur> ListeJoueurs { get;}
        public Joueur? GetJoueur(int id);
        public void ModifierJoueur(Joueur joueur);
        public void SupprimerJoueur(int id);
        
        public void AjouterJoueur(Joueur joueur);
    }
}
