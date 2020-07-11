using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class Commande
    {
        public int IdCommande { get; set; }
        public int? IdClientpar { get; set; }
        public int? IdClientpro { get; set; }
        public string Categorie { get; set; }
        public string Produit { get; set; }
        public DateTime? DateSaisie { get; set; }
        public DateTime? DateLivraison { get; set; }
        public string Statue { get; set; }
        public string VilleSortie { get; set; }
        public double? Prix { get; set; }
        public int? IdAgence { get; set; }
        public int? IdLivreur { get; set; }

        public Agence IdAgenceNavigation { get; set; }
        public ClientPar IdClientparNavigation { get; set; }
        public ClientPro IdClientproNavigation { get; set; }
        public Livreur IdLivreurNavigation { get; set; }
    }
}
