using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class Agence
    {
        public Agence()
        {
            Commandes = new HashSet<Commande>();
            Livreurs = new HashSet<Livreur>();
        }

        public int IdAgence { get; set; }
        public string Nom { get; set; }
        public int? IdResponsable { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public int IdVille { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public double? Moyens { get; set; }
        public int? IdSuperadmin { get; set; }

        public Responsable IdResponsableNavigation { get; set; }
        public Superadmin IdSuperadminNavigation { get; set; }
        public Ville IdVilleNavigation { get; set; }
        public ICollection<Commande> Commandes { get; set; }
        public ICollection<Livreur> Livreurs { get; set; }
    }
}
