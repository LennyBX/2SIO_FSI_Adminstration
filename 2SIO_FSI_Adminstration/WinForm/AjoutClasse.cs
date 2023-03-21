using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutClasse : Form
    {

        Utilisateur utilisateur;
        Database database = new Database();

        public AjoutClasse(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            string libelle = tbLibelleClasse.Text;

            if (libelle != "")
            {
                database.newClasse(libelle);
                MessageBox.Show("Classe ajoutée avec succès !");
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ du libelle !");
            }
        
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form accueilForm = new Accueil(utilisateur);
            accueilForm.Show();
        }
    }
}
