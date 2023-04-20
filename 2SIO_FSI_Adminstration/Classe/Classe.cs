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

        /// <summary>
        /// Créer une instance d'objet Classe sans attribut
        /// </summary>
        public Classe() { }

        /// <summary>
        /// Créer une instance d'objet Classe avec tous ses attributs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="acronyme"></param>
        /// <param name="libelle"></param>
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