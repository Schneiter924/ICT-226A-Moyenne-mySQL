using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moyenne
{
    public partial class frmNote : Form
    {
        /// <summary>
        /// Création de la classe note
        /// </summary>
        private Notes notesInt;
        
        public Notes NotesInt
        {
            get
            {
                return notesInt;
            }
            set
            {
                notesInt = value;
            }
        }
      
        public frmNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton pour annuler la saisie de la note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult annuler = MessageBox.Show("Confirmez-vous l'annulation ?", "Suppression de la saisie", MessageBoxButtons.YesNo);
            if (annuler == DialogResult.Yes)
            {
                Dispose();
            }
            
        }

        /// <summary>
        /// Bouton pour valider la note entrée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdValider_Click(object sender, EventArgs e)
        {
            notesInt.NotesDecimale = nudDecimal.Value;
            notesInt.NotesEntier = nudEntier.Value;
            if ((notesInt.NotesEntier == 6) && (notesInt.NotesDecimale > 0))
            {
                string message = "Vous avez mis une note plus grand que 6 la note va être mis 6.0";
                string caption = "Note impossible";
                MessageBoxButtons bouton = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, bouton, MessageBoxIcon.Error);
                notesInt.NotesDecimale = 0;
                notesInt.NotesEntier = 6;
            }
            
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            nudDecimal.Value = notesInt.NotesDecimale;
            nudEntier.Value = notesInt.NotesEntier;
        }


    }
}
