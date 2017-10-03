namespace Moyenne
{
    partial class frmNote
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
            this.grbNote = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.nudEntier = new System.Windows.Forms.NumericUpDown();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdValider = new System.Windows.Forms.Button();
            this.grbNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntier)).BeginInit();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNote
            // 
            this.grbNote.Controls.Add(this.label1);
            this.grbNote.Controls.Add(this.nudDecimal);
            this.grbNote.Controls.Add(this.nudEntier);
            this.grbNote.Location = new System.Drawing.Point(44, 22);
            this.grbNote.Name = "grbNote";
            this.grbNote.Size = new System.Drawing.Size(179, 53);
            this.grbNote.TabIndex = 0;
            this.grbNote.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ".";
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(98, 19);
            this.nudDecimal.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(50, 20);
            this.nudDecimal.TabIndex = 1;
            // 
            // nudEntier
            // 
            this.nudEntier.Location = new System.Drawing.Point(26, 19);
            this.nudEntier.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudEntier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEntier.Name = "nudEntier";
            this.nudEntier.Size = new System.Drawing.Size(50, 20);
            this.nudEntier.TabIndex = 0;
            this.nudEntier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.cmdAnnuler);
            this.grbAction.Controls.Add(this.cmdValider);
            this.grbAction.Location = new System.Drawing.Point(44, 94);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(179, 54);
            this.grbAction.TabIndex = 3;
            this.grbAction.TabStop = false;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Location = new System.Drawing.Point(98, 19);
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
            this.cmdValider.Location = new System.Drawing.Point(6, 19);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(75, 23);
            this.cmdValider.TabIndex = 0;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(244, 155);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNote";
            this.Text = "Saisie de note";
            this.Load += new System.EventHandler(this.frmNote_Load);
            this.grbNote.ResumeLayout(false);
            this.grbNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEntier)).EndInit();
            this.grbAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.NumericUpDown nudEntier;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Button cmdValider;
    }
}