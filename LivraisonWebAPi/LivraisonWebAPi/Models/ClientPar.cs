using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivraisonWebAPi.Models
{
    public partial class ClientPar
    {
        public ClientPar()
        {
            Commandes = new HashSet<Commande>();
        }

        public int Idclpar { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? Dtn { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public int IdVille { get; set; }
        [ForeignKey("IdVille")]
        //public Ville Ville { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public string CommandeALivrer { get; set; }
        public string TelWtsp { get; set; }

        //public virtual Ville Ville { get; set; }
        public Ville IdVilleNavigation { get; set; }
        public ICollection<Commande> Commandes { get; set; }
    }
}
