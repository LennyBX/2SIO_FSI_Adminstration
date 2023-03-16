using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void bConnexion_Click(object sender, EventArgs e)
        {
            string loginUti = tbLogin.Text;
            string mdpUti = tbMdp.Text;
            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=FSI_Gestion;User Id=postgres;Password=pgadmin;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM utilisateur where loginutilisateur = :login;";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            MyCmd.Parameters.Add(new NpgsqlParameter("login", NpgsqlDbType.Varchar)).Value = loginUti;
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            if (dr.Read())
            {
                // Création de l'objet utilisateur
                int idUti = dr.GetInt32(0);
                loginUti = dr.GetString(1);
                mdpUti = dr.GetString(2);
                Utilisateur uti = new Utilisateur(idUti, loginUti, mdpUti);

                //Ouverture du formulaire d'accueil si la connexion est ok
                this.Hide();
                Form formAccueil = new Accueil(uti);
                formAccueil.Show();
            }
            else
            {
                MessageBox.Show("Erreur d'authentification");
                tbLogin.Text = "";
                tbMdp.Text = "";
            }

            MyCnx.Close();





        }

     
    }
}
