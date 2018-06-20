using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_compte
{
    class Transfert
    {
        public string Id_Transfert { get; set; }
        public string Nom_Transfert { get; set; }
        public double Somme_Transfert { get; set; }

        public string Emissaire_Transfert { get; set; }
        public string Date_Transfert { get; set; }

        public Transfert(string Id, string Nom, double Somme, string Emissaire, string Date)
        {
            Id_Transfert = Id;
            Nom_Transfert = Nom;
            Somme_Transfert = Somme;
            Emissaire_Transfert = Emissaire;
            Date_Transfert = Date;
        }
        public Transfert():this ("0", "Aucun nom", 150.56,"Dépense", "Emissaire Inconnu", "2018-02-21" ) { }
        public override string ToString()
        {
            return ("ID:" +Id_Transfert+ " Nom:" +Nom_Transfert+ " Somme:"+Somme_Transfert+"€ Date:"+Date_Transfert);
        }
    }
}
