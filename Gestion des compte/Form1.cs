using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_des_compte
{
    public partial class FRM_Transfert : Form
    {
        public static string Save = "//Gestion des compte/bin/Debug";
        ArrayList TransfertEntrée = new ArrayList();
        ArrayList TransfertSortie = new ArrayList();
        public FRM_Transfert()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LBL_Date.Text = Calendar.SelectionStart.ToString("dd/MM/yyyy");
        }

        ///
        ///Commande
        ///

        private void Remplir(Transfert  transfert)
        {
            if (CBX_Type.Text== "Entrée"){ LBX_Entrée.Items.Add(transfert); }
            else if (CBX_Type.Text == "Sortie") { LBX_Sortie.Items.Add(transfert); }
        }

        private void Selection(Transfert transfert) { TBX_ID.Text = transfert.Id_Transfert.ToString(); TBX_Nom.Text = transfert.Nom_Transfert.ToString();TBX_Somme.Text = transfert.Somme_Transfert.ToString(); TBX_Emissaire.Text = transfert.Emissaire_Transfert.ToString(); LBL_Date.Text = transfert.Date_Transfert.ToString(); CBX_Type.Text = transfert.Type_Transfert.ToString(); }


    }
}
