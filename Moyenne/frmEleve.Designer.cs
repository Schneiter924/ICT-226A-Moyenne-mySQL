namespace Moyenne
{
    partial class frmEleve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDonnees = new System.Windows.Forms.GroupBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.picEleve = new System.Windows.Forms.PictureBox();
            this.grbNote = new System.Windows.Forms.GroupBox();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.grbDonnees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEleve)).BeginInit();
            this.grbNote.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDonnees
            // 
            this.grbDonnees.Controls.Add(this.txtPrenom);
            this.grbDonnees.Controls.Add(this.txtNom);
            this.grbDonnees.Controls.Add(this.lblPrenom);
            this.grbDonnees.Controls.Add(this.lblNom);
            this.grbDonnees.Controls.Add(this.picEleve);
            this.grbDonnees.Location = new System.Drawing.Point(21, 18);
            this.grbDonnees.Name = "grbDonnees";
            this.grbDonnees.Size = new System.Drawing.Size(528, 173);
            this.grbDonnees.TabIndex = 0;
            this.grbDonnees.TabStop = false;
            this.grbDonnees.Text = "Données personnelles";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(247, 76);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(177, 20);
            this.txtPrenom.TabIndex = 4;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(247, 49);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(177, 20);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(185, 83);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(185, 49);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // picEleve
            // 
            this.picEleve.Location = new System.Drawing.Point(6, 30);
            this.picEleve.Name = "picEleve";
            this.picEleve.Size = new System.Drawing.Size(134, 137);
            this.picEleve.TabIndex = 0;
            this.picEleve.TabStop = false;
            // 
            // grbNote
            // 
            this.grbNote.Controls.Add(this.txtMoyenne);
            this.grbNote.Controls.Add(this.lblMoyenne);
            this.grbNote.Controls.Add(this.lstNotes);
            this.grbNote.Controls.Add(this.cmdSupprimer);
            this.grbNote.Controls.Add(this.cmdModifier);
            this.grbNote.Controls.Add(this.cmdAjouter);
            this.grbNote.Location = new System.Drawing.Point(21, 197);
            this.grbNote.Name = "grbNote";
            this.grbNote.Size = new System.Drawing.Size(528, 128);
            this.grbNote.TabIndex = 1;
            this.grbNote.TabStop = false;
            this.grbNote.Text = "Les notes";
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(284, 62);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.ReadOnly = true;
            this.txtMoyenne.Size = new System.Drawing.Size(48, 20);
            this.txtMoyenne.TabIndex = 5;
            // 
            // lblMoyenne
            // 
            this.lblMoyenne.AutoSize = true;
            this.lblMoyenne.Location = new System.Drawing.Point(281, 41);
            this.lblMoyenne.Name = "lblMoyenne";
            this.lblMoyenne.Size = new System.Drawing.Size(51, 13);
            this.lblMoyenne.TabIndex = 5;
            this.lblMoyenne.Text = "Moyenne";
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.Location = new System.Drawing.Point(106, 27);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(66, 95);
            this.lstNotes.TabIndex = 3;
            this.lstNotes.Click += new System.EventHandler(this.lstNotes_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(25, 89);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.cmdSupprimer.TabIndex = 2;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(25, 60);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(75, 23);
            this.cmdModifier.TabIndex = 1;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(25, 31);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdAjouter.TabIndex = 0;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.cmdAnnuler);
            this.grbAction.Controls.Add(this.cmdValider);
            this.grbAction.Location = new System.Drawing.Point(21, 331);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(316, 53);
            this.grbAction.TabIndex = 4;
            this.grbAction.TabStop = false;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Location = new System.Drawing.Point(206, 19);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(75, 23);
            this.cmdAnnuler.TabIndex = 1;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdValider.Location = new System.Drawing.Point(58, 19);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(75, 23);
            this.cmdValider.TabIndex = 0;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // frmEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 466);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbNote);
            this.Controls.Add(this.grbDonnees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEleve";
            this.Text = "Elève";
            this.Load += new System.EventHandler(this.frmEleve_Load);
            this.grbDonnees.ResumeLayout(false);
            this.grbDonnees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEleve)).EndInit();
            this.grbNote.ResumeLayout(false);
            this.grbNote.PerformLayout();
            this.grbAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDonnees;
        private System.Windows.Forms.GroupBox grbNote;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox picEleve;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdAjouter;
    }
}