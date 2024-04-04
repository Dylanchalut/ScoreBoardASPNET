namespace ScoreBoard.Models
{
    public interface IJeuRep
    {
        public IEnumerable<Jeu> ListeJeux { get;}
        public Jeu? GetJeu(int id);
        public void ModifierJeu(Jeu jeu);
        public void SupprimerJeu(int id);
        public void AjouterJeu(Jeu jeu);
    }
}
