using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class Livreur
    {
        public Livreur()
        {
            Commandes = new HashSet<Commande>();
        }

        public int IdLivreur { get; set; }
        public string NomLivreur { get; set; }
        public string PrenomLivreur { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public int? IdVille { get; set; }
        public string Vehicule { get; set; }
        public string Permis { get; set; }
        public int? IdAgence { get; set; }

        public Agence IdAgenceNavigation { get; set; }
        public Ville IdVilleNavigation { get; set; }
        public ICollection<Commande> Commandes { get; set; }
    }
}
