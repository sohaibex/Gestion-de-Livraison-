using System;
using System.Collections.Generic;

namespace LivraisonWebAPi.Models
{
    public partial class Superadmin
    {
        public Superadmin()
        {
            Agences = new HashSet<Agence>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }

        public ICollection<Agence> Agences { get; set; }
    }
}
