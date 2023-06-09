﻿using _2SIO_FSI_Adminstration.Classe;
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
            string login = tbLogin.Text;
            string password = tbMdp.Text;

            if (database.isRegistered(login) == true)
            {
                if (database.authentify(login, password) == true)
                {
                    this.Hide();
                    Form formAccueil = new Accueil(database.getUtilisateurByUsername(login));
                    formAccueil.Show();
                }
                else
                {
                    MessageBox.Show("Le mot de passe est incorrect !");
                    tbMdp.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas enregistré dans la BDD !");
                tbLogin.Text = "";
                tbMdp.Text = "";
            }
        }

        private void tbMdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bConnexion_Click((object)sender, e);
            }
        }
    }
}
