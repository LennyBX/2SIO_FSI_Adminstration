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

        public Array<Utilisateur> getAllUtilisateurs()
        {
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM etudiant;", npgsqlConnection);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            Array<Utilisateur> utilisateurs = new Array<Utilisateur>();
            while (npgsqlDataReader.Read())
            {
                int idUti = dr.GetInt32(0);
                loginUti = dr.GetString(1);
                mdpUti = dr.GetString(2);
                Utilisateur utilisateur = new Utilisateur(idUti, loginUti, mdpUti);
                utilisateurs.Add(utilisateur);
            }
            return utilisateurs;
        }
    }
}