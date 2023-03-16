using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Classes
    {
        private int idClasse;
        private string libelleClasse; 

        public Classes(int idClasse, string libelleClasse)
        {
            this.idClasse = idClasse;
            this.libelleClasse = libelleClasse;
        }

        public int IdClasse { get => idClasse; set => idClasse = value; }
        public String LibelleClasse { get => libelleClasse; set => libelleClasse = value; }

    }
}