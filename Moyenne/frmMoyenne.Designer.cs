namespace Moyenne
{
    partial class frmMoyenne
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
            this.grbEleves = new System.Windows.Forms.GroupBox();
            this.lstEleves = new System.Windows.Forms.ListBox();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.grbEleves.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEleves
            // 
            this.grbEleves.Controls.Add(this.lstEleves);
            this.grbEleves.Location = new System.Drawing.Point(12, 12);
            this.grbEleves.Name = "grbEleves";
            this.grbEleves.Size = new System.Drawing.Size(237, 413);
            this.grbEleves.TabIndex = 0;
            this.grbEleves.TabStop = false;
            this.grbEleves.Text = "Elèves";
            // 
            // lstEleves
            // 
            this.lstEleves.FormattingEnabled = true;
            this.lstEleves.Location = new System.Drawing.Point(6, 18);
            this.lstEleves.Name = "lstEleves";
            this.lstEleves.Size = new System.Drawing.Size(230, 394);
            this.lstEleves.TabIndex = 0;
            this.lstEleves.Click += new System.EventHandler(this.lstEleves_Click);
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.cmdSupprimer);
            this.grbAction.Controls.Add(this.cmdModifier);
            this.grbAction.Controls.Add(this.cmdAjouter);
            this.grbAction.Location = new System.Drawing.Point(258, 12);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(237, 413);
            this.grbAction.TabIndex = 1;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Actions";
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(61, 242);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(123, 65);
            this.cmdSupprimer.TabIndex = 2;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(61, 144);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(123, 65);
            this.cmdModifier.TabIndex = 1;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(61, 45);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(123, 65);
            this.cmdAjouter.TabIndex = 0;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // frmMoyenne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 437);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbEleves);
            this.Name = "frmMoyenne";
            this.Text = "frmMoyenne";
            this.grbEleves.ResumeLayout(false);
            this.grbAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEleves;
        private System.Windows.Forms.ListBox lstEleves;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdAjouter;
    }
}