using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class Ville
    {
        public Ville()
        {
            Agences = new HashSet<Agence>();
            ClientPars = new HashSet<ClientPar>();
            ClientProes = new HashSet<ClientPro>();
            Livreurs = new HashSet<Livreur>();
            Responsables = new HashSet<Responsable>();
        }

        public int Id { get; set; }
        public string NomVille { get; set; }

        public ICollection<Agence> Agences { get; set; }
        public ICollection<ClientPar> ClientPars { get; set; }
        public ICollection<ClientPro> ClientProes { get; set; }
        public ICollection<Livreur> Livreurs { get; set; }
        public ICollection<Responsable> Responsables { get; set; }
    }
}
