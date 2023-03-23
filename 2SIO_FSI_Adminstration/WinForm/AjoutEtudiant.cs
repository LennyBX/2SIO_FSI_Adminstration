using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {

        Database database = new Database();
        Utilisateur utilisateur;

        public AjoutEtudiant(Utilisateur utilisateur1)
        {
            utilisateur = utilisateur1;
            InitializeComponent();
        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {
            foreach (Classe.Classe cl in database.getAllClasses())
            {
                cbClasse.Items.Add(cl.AcronymeClasse);

            }
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            string nom = tbLastName.Text;
            string prenom = tbFirstName.Text;
            string classe = this.cbClasse.GetItemText(this.cbClasse.SelectedItem);
            Classe.Classe classeObj = database.getClasse(classe);

            if (nom != "" && prenom != "" && classe != "")
            {
                database.newUtilisateur(nom, prenom, classeObj.IdClasse);
                MessageBox.Show("Etudiant ajouté avec succès !");
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs sont manquants !");
            }

        }

        private void bClearText_Click(object sender, EventArgs e)
        {
            tbLastName.Text = "";
            tbFirstName.Text = "";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form connectionForm = new Accueil(utilisateur);
            connectionForm.Show();
        }
    }
}
