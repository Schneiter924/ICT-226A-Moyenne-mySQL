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
    
    public partial class frmEleve : Form
    {
        /// <summary>
        /// Création de la classe eleves
        /// </summary>
        private Eleves elevesInt;

        public Eleves ElevesInt
        {
            get
            {
                return elevesInt;
            }
            set
            {
                elevesInt = value;
            }
        }
        /// <summary>
        /// Initialisation du form 
        /// </summary>
        public frmEleve()
        {
            InitializeComponent();
            cmdModifier.Enabled = false;
            cmdSupprimer.Enabled = false;
            cmdValiderTest();
                       
        }
        
        /// <summary>
        /// Bouton pour ajouter une note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            frmNote noteAjou = new frmNote();
            noteAjou.NotesInt = new Notes();
            noteAjou.NotesInt.NotesEntier = 1;
            
            if (noteAjou.ShowDialog(this) == DialogResult.OK)
            {
                lstNotes.Items.Add(noteAjou.NotesInt);
                ElevesInt.NoteEleve.Add(noteAjou.NotesInt);
                calculMoyenne();
                cmdValiderTest();
            }
            
        }

        /// <summary>
        /// Bouton pour modifier une note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex != -1)
            {
                frmNote noteModif = new frmNote();
                noteModif.NotesInt = (Notes) lstNotes.SelectedItem;
                int index = lstNotes.SelectedIndex;
                if (noteModif.ShowDialog(this) == DialogResult.OK)
                {
                    lstNotes.Items.RemoveAt(index);
                    ElevesInt.NoteEleve.RemoveAt(index);
                    ElevesInt.NoteEleve.Insert(index, noteModif.NotesInt);
                    lstNotes.Items.Insert(index, noteModif.NotesInt);
                    calculMoyenne();
                    cmdValiderTest();
                }
                
                
            }
                
            
            
        }

        /// <summary>
        /// Bouton pour supprimer une note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex != -1)
            {
                DialogResult supprimer = MessageBox.Show("Confirmez-vous la suppression ?", "Suppression d'une Note", MessageBoxButtons.YesNo);
                if (supprimer == DialogResult.Yes)
                {
                    int index = lstNotes.SelectedIndex;
                    lstNotes.Items.RemoveAt(index);
                    ElevesInt.NoteEleve.RemoveAt(index);
                    calculMoyenne();
                    cmdValiderTest();
                }
                
            }
            
        }

        /// <summary>
        /// Bouton pour annuler la saisie d'un élève
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
        /// Test si le bouton valider doit être actif ou non
        /// </summary>
        private void cmdValiderTest()
        {
            if ((txtMoyenne.Text != "")&&(txtNom.Text != "")&&(txtPrenom.Text != ""))
            {
                cmdValider.Enabled = true;
                
            }
            else
            {
                cmdValider.Enabled = false;
            }
        }
                
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            cmdValiderTest();
        }
                
        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            cmdValiderTest();
        }

        /// <summary>
        /// Fonction qui regarde s'il y a une note qui est sélectionné
        /// </summary>
        private void updateStatus()
        {
            if (lstNotes.SelectedIndex > -1)
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

                
        private void lstNotes_Click(object sender, EventArgs e)
        {
            updateStatus();
        }

        /// <summary>
        /// Calcul la moyenne de l'élève
        /// </summary>
        private void calculMoyenne()
        {
            decimal moyennne = 0;
            foreach (Notes note in ElevesInt.NoteEleve)
            {
                decimal noteDecimale = note.NotesDecimale;
                decimal noteEntier = note.NotesEntier;

                decimal notes = noteEntier + (noteDecimale)/10;
                moyennne += notes;
            }
            moyennne /= ElevesInt.NoteEleve.Count();
            moyennne = Math.Round(moyennne, 1);
            ElevesInt.Moyenne = moyennne;
            txtMoyenne.Text = moyennne.ToString("F1");
            ElevesInt.Prenom = txtPrenom.Text;
            ElevesInt.Nom = txtNom.Text;
        }
        
        
        private void frmEleve_Load(object sender, EventArgs e)
        {
            txtMoyenne.Text = ElevesInt.Moyenne.ToString("F1");
            txtNom.Text = ElevesInt.Nom;
            txtPrenom.Text = ElevesInt.Prenom;
            foreach (Notes note in ElevesInt.NoteEleve)
            {

                lstNotes.Items.Add(note);
            }

        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            ElevesInt.Prenom = txtPrenom.Text;
            ElevesInt.Nom = txtNom.Text;
            ElevesInt.Moyenne = decimal.Parse(txtMoyenne.Text);
        }
    }
}
