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
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public AjoutEtudiant()
        {
            InitializeComponent();

        }
        private void bouton1_Click(object sender, EventArgs e)
        {
            string nom = tbAENom.Text;
            string prenom = tbAEPrenom.Text;
            string list = cbClasse.Text;

            if(nom != "" && prenom != "")
            {
                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=FSI_Gestion;User Id=postgres;Password=pgadmin;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO etudiant (nomEtudiant, prenometudiant, idClasse) values ( :1, :2, :3);";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = nom;
                    commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = prenom;
                    commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Varchar)).Value = list;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();
                    MessageBox.Show("Etudiant ajouté");
                    reInitialisation();
                }
                finally
                {
                    if (commande != null) commande.Dispose();
                    if (maConnexion != null) maConnexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Il manque des champs");
            }
   
         



        }
        private void reInitialisation()
        {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";

        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {



         


        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {

            string Conx = "Server=localhost;Port=5432;Database=FSI_Gestion;User Id=postgres;Password=pgadmin;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM classe";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();


            List<Classes> mesCLasses = new List<Classes>();
            while (dr.Read())
            {
                // Création de l'objet etudiant
                int idclasse = dr.GetInt32(0);
                string libelleclasse = dr.GetString(1);
    ;

                Classes uneClasse = new Classes(idclasse, libelleclasse);
                mesCLasses.Add(uneClasse);

            }

            //Affichage dans le dataGridView
            foreach (Classes cl in mesCLasses)
            {
                cbClasse.Items.Add(cl.LibelleClasse);

            }


            MyCnx.Close();

        }
    }
}
