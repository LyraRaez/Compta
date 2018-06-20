namespace Gestion_des_compte
{
    partial class FRM_Transfert
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBX_Gain = new System.Windows.Forms.GroupBox();
            this.LBX_Entrée = new System.Windows.Forms.ListBox();
            this.GBX_Sortie = new System.Windows.Forms.GroupBox();
            this.LBX_Sortie = new System.Windows.Forms.ListBox();
            this.GBX_Transfert = new System.Windows.Forms.GroupBox();
            this.LBL_Date = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.LBL_Emissaire = new System.Windows.Forms.Label();
            this.LBL_Somme = new System.Windows.Forms.Label();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.GBX_Solde = new System.Windows.Forms.GroupBox();
            this.TBX_Solde = new System.Windows.Forms.TextBox();
            this.CBX_Type = new System.Windows.Forms.ComboBox();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.TBX_ID = new System.Windows.Forms.TextBox();
            this.TBX_Nom = new System.Windows.Forms.TextBox();
            this.TBX_Somme = new System.Windows.Forms.TextBox();
            this.TBX_Emissaire = new System.Windows.Forms.TextBox();
            this.GBX_Gain.SuspendLayout();
            this.GBX_Sortie.SuspendLayout();
            this.GBX_Transfert.SuspendLayout();
            this.GBX_Solde.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Gain
            // 
            this.GBX_Gain.Controls.Add(this.LBX_Entrée);
            this.GBX_Gain.Location = new System.Drawing.Point(12, 12);
            this.GBX_Gain.Name = "GBX_Gain";
            this.GBX_Gain.Size = new System.Drawing.Size(386, 218);
            this.GBX_Gain.TabIndex = 0;
            this.GBX_Gain.TabStop = false;
            this.GBX_Gain.Text = "Entrée";
            // 
            // LBX_Entrée
            // 
            this.LBX_Entrée.FormattingEnabled = true;
            this.LBX_Entrée.Location = new System.Drawing.Point(6, 19);
            this.LBX_Entrée.Name = "LBX_Entrée";
            this.LBX_Entrée.Size = new System.Drawing.Size(374, 186);
            this.LBX_Entrée.TabIndex = 0;
            // 
            // GBX_Sortie
            // 
            this.GBX_Sortie.Controls.Add(this.LBX_Sortie);
            this.GBX_Sortie.Location = new System.Drawing.Point(404, 12);
            this.GBX_Sortie.Name = "GBX_Sortie";
            this.GBX_Sortie.Size = new System.Drawing.Size(386, 218);
            this.GBX_Sortie.TabIndex = 1;
            this.GBX_Sortie.TabStop = false;
            this.GBX_Sortie.Text = "Sortie";
            // 
            // LBX_Sortie
            // 
            this.LBX_Sortie.FormattingEnabled = true;
            this.LBX_Sortie.Location = new System.Drawing.Point(6, 19);
            this.LBX_Sortie.Name = "LBX_Sortie";
            this.LBX_Sortie.Size = new System.Drawing.Size(374, 186);
            this.LBX_Sortie.TabIndex = 2;
            // 
            // GBX_Transfert
            // 
            this.GBX_Transfert.Controls.Add(this.TBX_Emissaire);
            this.GBX_Transfert.Controls.Add(this.TBX_Somme);
            this.GBX_Transfert.Controls.Add(this.TBX_Nom);
            this.GBX_Transfert.Controls.Add(this.TBX_ID);
            this.GBX_Transfert.Controls.Add(this.LBL_ID);
            this.GBX_Transfert.Controls.Add(this.CBX_Type);
            this.GBX_Transfert.Controls.Add(this.LBL_Date);
            this.GBX_Transfert.Controls.Add(this.Calendar);
            this.GBX_Transfert.Controls.Add(this.LBL_Emissaire);
            this.GBX_Transfert.Controls.Add(this.LBL_Somme);
            this.GBX_Transfert.Controls.Add(this.LBL_Type);
            this.GBX_Transfert.Controls.Add(this.LBL_Nom);
            this.GBX_Transfert.Location = new System.Drawing.Point(12, 241);
            this.GBX_Transfert.Name = "GBX_Transfert";
            this.GBX_Transfert.Size = new System.Drawing.Size(463, 262);
            this.GBX_Transfert.TabIndex = 2;
            this.GBX_Transfert.TabStop = false;
            this.GBX_Transfert.Text = "Transfert";
            // 
            // LBL_Date
            // 
            this.LBL_Date.AutoSize = true;
            this.LBL_Date.Location = new System.Drawing.Point(96, 202);
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.Size = new System.Drawing.Size(30, 13);
            this.LBL_Date.TabIndex = 5;
            this.LBL_Date.Text = "Date";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(230, 25);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 4;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // LBL_Emissaire
            // 
            this.LBL_Emissaire.AutoSize = true;
            this.LBL_Emissaire.Location = new System.Drawing.Point(6, 168);
            this.LBL_Emissaire.Name = "LBL_Emissaire";
            this.LBL_Emissaire.Size = new System.Drawing.Size(51, 13);
            this.LBL_Emissaire.TabIndex = 3;
            this.LBL_Emissaire.Text = "Émissaire";
            // 
            // LBL_Somme
            // 
            this.LBL_Somme.AutoSize = true;
            this.LBL_Somme.Location = new System.Drawing.Point(6, 134);
            this.LBL_Somme.Name = "LBL_Somme";
            this.LBL_Somme.Size = new System.Drawing.Size(42, 13);
            this.LBL_Somme.TabIndex = 2;
            this.LBL_Somme.Text = "Somme";
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Location = new System.Drawing.Point(6, 68);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(87, 13);
            this.LBL_Type.TabIndex = 1;
            this.LBL_Type.Text = "Type de transfert";
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(6, 99);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(85, 13);
            this.LBL_Nom.TabIndex = 0;
            this.LBL_Nom.Text = "Nom du transfert";
            // 
            // GBX_Solde
            // 
            this.GBX_Solde.Controls.Add(this.TBX_Solde);
            this.GBX_Solde.Location = new System.Drawing.Point(481, 241);
            this.GBX_Solde.Name = "GBX_Solde";
            this.GBX_Solde.Size = new System.Drawing.Size(309, 100);
            this.GBX_Solde.TabIndex = 3;
            this.GBX_Solde.TabStop = false;
            this.GBX_Solde.Text = "Solde";
            // 
            // TBX_Solde
            // 
            this.TBX_Solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TBX_Solde.Location = new System.Drawing.Point(6, 21);
            this.TBX_Solde.Name = "TBX_Solde";
            this.TBX_Solde.Size = new System.Drawing.Size(297, 60);
            this.TBX_Solde.TabIndex = 0;
            // 
            // CBX_Type
            // 
            this.CBX_Type.FormattingEnabled = true;
            this.CBX_Type.Items.AddRange(new object[] {
            "Entrée",
            "Sortie"});
            this.CBX_Type.Location = new System.Drawing.Point(99, 65);
            this.CBX_Type.Name = "CBX_Type";
            this.CBX_Type.Size = new System.Drawing.Size(121, 21);
            this.CBX_Type.TabIndex = 6;
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Location = new System.Drawing.Point(6, 35);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(53, 13);
            this.LBL_ID.TabIndex = 7;
            this.LBL_ID.Text = "Identifiant";
            // 
            // TBX_ID
            // 
            this.TBX_ID.Location = new System.Drawing.Point(99, 32);
            this.TBX_ID.Name = "TBX_ID";
            this.TBX_ID.Size = new System.Drawing.Size(121, 20);
            this.TBX_ID.TabIndex = 8;
            // 
            // TBX_Nom
            // 
            this.TBX_Nom.Location = new System.Drawing.Point(99, 96);
            this.TBX_Nom.Name = "TBX_Nom";
            this.TBX_Nom.Size = new System.Drawing.Size(121, 20);
            this.TBX_Nom.TabIndex = 9;
            // 
            // TBX_Somme
            // 
            this.TBX_Somme.Location = new System.Drawing.Point(97, 127);
            this.TBX_Somme.Name = "TBX_Somme";
            this.TBX_Somme.Size = new System.Drawing.Size(121, 20);
            this.TBX_Somme.TabIndex = 10;
            // 
            // TBX_Emissaire
            // 
            this.TBX_Emissaire.Location = new System.Drawing.Point(99, 161);
            this.TBX_Emissaire.Name = "TBX_Emissaire";
            this.TBX_Emissaire.Size = new System.Drawing.Size(121, 20);
            this.TBX_Emissaire.TabIndex = 11;
            // 
            // FRM_Transfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Controls.Add(this.GBX_Solde);
            this.Controls.Add(this.GBX_Transfert);
            this.Controls.Add(this.GBX_Sortie);
            this.Controls.Add(this.GBX_Gain);
            this.Name = "FRM_Transfert";
            this.Text = "Gestion des comptes";
            this.GBX_Gain.ResumeLayout(false);
            this.GBX_Sortie.ResumeLayout(false);
            this.GBX_Transfert.ResumeLayout(false);
            this.GBX_Transfert.PerformLayout();
            this.GBX_Solde.ResumeLayout(false);
            this.GBX_Solde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBX_Gain;
        private System.Windows.Forms.ListBox LBX_Entrée;
        private System.Windows.Forms.GroupBox GBX_Sortie;
        private System.Windows.Forms.ListBox LBX_Sortie;
        private System.Windows.Forms.GroupBox GBX_Transfert;
        private System.Windows.Forms.Label LBL_Emissaire;
        private System.Windows.Forms.Label LBL_Somme;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label LBL_Date;
        private System.Windows.Forms.GroupBox GBX_Solde;
        private System.Windows.Forms.TextBox TBX_Solde;
        private System.Windows.Forms.ComboBox CBX_Type;
        private System.Windows.Forms.TextBox TBX_Nom;
        private System.Windows.Forms.TextBox TBX_ID;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.TextBox TBX_Emissaire;
        private System.Windows.Forms.TextBox TBX_Somme;
    }
}

