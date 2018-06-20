using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_compte
{
    class Solde
    {
        public double Resultat { get; set; }
        public Solde (double solde)
        {
            Resultat = solde;
        }
        public Solde():this(0)
        { }

        public override string ToString()
        {
            return (+Resultat+"€");
        }
  
    }
}
