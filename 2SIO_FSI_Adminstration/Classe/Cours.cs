using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Cours
    {
        private int idCours;
        private int libelleCours;
        private int descriptionCours;
        private Classe classeCours;

        public Cours() { }

        public Cours(int idCours, int libelleCours, int descriptionCours, Classe classe)
        {
            this.idCours = idCours;
            this.libelleCours = libelleCours;
            this.descriptionCours = descriptionCours;
            this.classeCours = classe;
        }

        public int IdCours { get => idCours; set => idCours = value; }
        public int LibelleCours { get => libelleCours; set => libelleCours = value; }
        public int DescriptionCours { get => descriptionCours; set => descriptionCours = value; }
        public Classe ClasseCours { get => classeCours; set => classeCours = value; }

    }
}
