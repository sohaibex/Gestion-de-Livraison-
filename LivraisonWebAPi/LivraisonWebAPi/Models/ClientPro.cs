using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class ClientPro
    {
        public ClientPro()
        {
            Commandes = new HashSet<Commande>();
        }

        public int IdClientpro { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? Dtn { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public int IdVille { get; set; }
        public string Mdp { get; set; }
        public string CommandeALivrer { get; set; }
        public string TelWtsp { get; set; }
        public string NomEntreprise { get; set; }
        public string SiteWeb { get; set; }
        public string Email { get; set; }
        public string SecteurActivite { get; set; }
        public string Rc { get; set; }
        public string Cin { get; set; }
        public string Tp { get; set; }
        public string Ice { get; set; }

        public Ville IdVilleNavigation { get; set; }
        public ICollection<Commande> Commandes { get; set; }
    }
}
