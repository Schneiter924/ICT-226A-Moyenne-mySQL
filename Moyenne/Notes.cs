using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    /// <summary>
    /// Gestion des notes des élèves
    /// </summary>
    public class Notes
    {
        public Notes()
        {
            
        }


        /// <summary>
        /// Permet de récuper ou d'ajouter la note décimal
        /// </summary>
        public decimal NotesDecimale { set; get; }

        /// <summary>
        /// Permet de récuper ou d'ajouter la note entier
        /// </summary>
        public decimal NotesEntier { set; get; }

        /// <summary>
        /// convertie la note en entier.décmal
        /// </summary>
        /// <returns>retourne la note entier.décimale</returns>
        public decimal Convertion()
        {
            decimal test = NotesEntier + (NotesDecimale / 10);

            return test;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>retourne la note en string</returns>
        public override string ToString()
        {
            string note = "";
            if (NotesDecimale == 0)
            {
                note = NotesEntier + ".0";
            }
            else
            {
                note = NotesEntier + "." + NotesDecimale;
            }

            return note;
        }
    }
}
