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
    
    public partial class frmMoyenne : Form
    {
        
        public frmMoyenne()
        {
            InitializeComponent();
            cmdModifier.Enabled = false;
            cmdSupprimer.Enabled = false;
        }

        /// <summary>
        /// Bouton pour ajouter un élève
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            frmEleve ajouEleve = new frmEleve();
            ajouEleve.ElevesInt = new Eleves();
            ajouEleve.ElevesInt.NoteEleve = new List<Notes>();
            if (ajouEleve.ShowDialog(this) == DialogResult.OK)
            {
                lstEleves.Items.Add(ajouEleve.ElevesInt);
            }
            else
            {

            }
        }

        /// <summary>
        /// Bouton pour modifier un élève
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (lstEleves.SelectedIndex != -1)
            {
                frmEleve modifEleve = new frmEleve();
                modifEleve.ElevesInt = (Eleves)lstEleves.SelectedItem;
                int index = lstEleves.SelectedIndex;
                if (modifEleve.ShowDialog(this) == DialogResult.OK)
                {
                    lstEleves.Items.RemoveAt(index);
                    lstEleves.Items.Insert(index, modifEleve.ElevesInt);
                }
            }
            
        }

        /// <summary>
        /// Bouton pour supprimer un élève
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lstEleves.SelectedIndex != -1)
            {
                DialogResult supprimer = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'un élève", MessageBoxButtons.YesNo);
                if (supprimer == DialogResult.Yes)
                {
                    int index = lstEleves.SelectedIndex;
                    lstEleves.Items.RemoveAt(index);
                }
                else if (supprimer == DialogResult.No)
                {

                }
            }
            
        }
        
        private void lstEleves_Click(object sender, EventArgs e)
        {
            updateStatus();
        }

        /// <summary>
        /// Fonction qui regarde s'il y a un élève qui est sélectionné
        /// </summary>
        private void updateStatus()
        {
            if (lstEleves.SelectedIndex > -1)
            {
                cmdModifier.Enabled = true;
                cmdSupprimer.Enabled = true;
            }
            else
            {
                cmdModifier.Enabled = false;
                cmdSupprimer.Enabled = false;
            }
        }
    }
}
