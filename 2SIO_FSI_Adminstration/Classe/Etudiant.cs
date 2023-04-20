using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class Etudiant
    {
        private int idEtudiant;
        private string nomEtudiant;
        private string prenomEtudiant;
        private string numeroEtudiant;
        private string mailEtudiant;
        private Classe classeEtudiant;

        /// <summary>
        /// Créer une instance d'objet Etudiant sans attribut
        /// </summary>
        public Etudiant() { }

        /// <summary>
        /// Créer une instance d'objet Etudiant avec tous ses attributs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="numero"></param>
        /// <param name="mail"></param>
        /// <param name="classe"></param>
        public Etudiant(int id, string nom, string prenom, string numero, string mail, Classe classe)
        {
            this.idEtudiant = id;
            this.nomEtudiant = nom;
            this.prenomEtudiant = prenom;
            this.numeroEtudiant = numero;
            this.mailEtudiant = mail;
            this.classeEtudiant = classe;
        }

        public int IdEtudiant { get => idEtudiant; set => idEtudiant = value; }
        public string NomEtudiant { get => nomEtudiant; set => nomEtudiant = value; }
        public string PrenomEtudiant { get => prenomEtudiant; set => prenomEtudiant = value; }
        public string NumeroEtudiant { get => numeroEtudiant; set => numeroEtudiant = value; }
        public string MailEtudiant { get => mailEtudiant; set => mailEtudiant = value; }
        public Classe ClasseEtudiant { get => classeEtudiant; set => classeEtudiant = value; }

        public string getFullName()
        {
            return this.prenomEtudiant + " " + this.nomEtudiant;
        }

    }
}
