using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_compte
{
    class Sortie:Transfert
    {
        public string TypeTransfert { get; set; }
        public Sortie(string Id_Tarnsfert, string string Type)
        {
            TypeTransfert = Type;
        }

        public Sortie()
    }
}
