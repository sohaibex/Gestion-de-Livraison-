using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class Responsable
    {
        public Responsable()
        {
            Agences = new HashSet<Agence>();
        }

        public int IdResponsable { get; set; }
        public string NomResponsable { get; set; }
        public string PrenomResponsable { get; set; }
        public string LoginResponsable { get; set; }
        public string MdpResponsable { get; set; }
        public int? Ville { get; set; }

        public Ville VilleNavigation { get; set; }
        public ICollection<Agence> Agences { get; set; }
    }
}
