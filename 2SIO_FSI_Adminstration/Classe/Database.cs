using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.Classe
{
    class Database
    {

        String hostname = "localhost";
        String port = "5432";
        String database = "FSI_Gestion";
        String user = "postgres";
        String password = "pgadmin";

        NpgsqlConnection npgsqlConnection; 

        public Database()
        {
            String connectionString = "Server=" + hostname + ";Port=" + port + ";Database=" + database + ";User Id=" + user + ";Password=" + password + ";";
            npgsqlConnection = new NpgsqlConnection(connectionString);
            npgsqlConnection.Open();
        }

        public Array<Etudiant> getAllEtudiant()
        {
            NpgsqlCommand MyCmd = new NpgsqlCommand("SELECT * FROM :table;", npgsqlConnection);
            MyCmd.Parameters.Add(new NpgsqlParameter("table", NpgsqlDbType.Varchar)).Value = table;
            NpgsqlDataReader npgsqlDataReader = MyCmd.ExecuteReader();
            if (dr.Read())
            {
                int idUti = dr.GetInt32(0);
                loginUti = dr.GetString(1);
                mdpUti = dr.GetString(2);
                Utilisateur uti = new Utilisateur(idUti, loginUti, mdpUti);

                //Ouverture du formulaire d'accueil si la connexion est ok
                this.Hide();
                Form formAccueil = new Accueil(uti);
                formAccueil.Show();
            }

            return null;
        }

    }
}