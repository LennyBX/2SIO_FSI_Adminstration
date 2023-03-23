using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Classe
    {
        private int idClasse;
        private string acronymeClasse;
        private string libelleClasse; 

        public Classe() { }

        public Classe(int id, string acronyme, string libelle)
        {
            this.idClasse = id;
            this.acronymeClasse = acronyme;
            this.libelleClasse = libelle;
        }

        public int IdClasse { get => idClasse; set => idClasse = value; }
        public string AcronymeClasse { get => acronymeClasse; set => acronymeClasse = value; }
        public string LibelleClasse { get => libelleClasse; set => libelleClasse = value; }

    }
}