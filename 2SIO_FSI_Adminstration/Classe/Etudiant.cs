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

        public Etudiant() { }

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

    }
}
