using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class Connexion : Form
    {
        Database database = new Database();

        public Connexion()
        {
            InitializeComponent();
        }

        private void bConnexion_Click(object sender, EventArgs e)
        {
            string loginUti = tbLogin.Text;
            string mdpUti = tbMdp.Text;
            if(database.isRegistered(loginUti) == true)
            {
                if (database.authentify(loginUti, mdpUti) == true)
                {
                    Utilisateur utilisateur = database.GetUtilisateur(loginUti);
                    this.Hide();
                    Form formAccueil = new Accueil(utilisateur);
                    formAccueil.Show();
                }
                else
                {
                    MessageBox.Show("Le mot de passe est incorrect !");
                    tbLogin.Text = "";
                    tbMdp.Text = "";
                }
            } else
            {
                MessageBox.Show("Vous n'êtes pas enregistré dans la bdd !");
            }
        }
    }
}
