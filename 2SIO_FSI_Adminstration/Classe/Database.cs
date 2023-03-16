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
        }

        public List<Utilisateur> getAllUtilisateurs()
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM utilisateur;", npgsqlConnection);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            while (npgsqlDataReader.Read())
            {
                int idUser = npgsqlDataReader.GetInt32(0);
                String loginUser = npgsqlDataReader.GetString(1);
                String passwordUser = npgsqlDataReader.GetString(2);
                Utilisateur utilisateur = new Utilisateur(idUser, loginUser, passwordUser);
                utilisateurs.Add(utilisateur);
            }
            npgsqlConnection.Close();
            return utilisateurs;
        }

        public Utilisateur getUtilisateur(String username)
        {
            List<Utilisateur > utilisateurs = getAllUtilisateurs();
            foreach(Utilisateur utilisateur in utilisateurs)
            {
                if(utilisateur.LoginUtilisateur == username)
                {
                    return utilisateur;
                }
            }
            return null;
        }

        public Boolean isRegistered(String username)
        {
            List<Utilisateur> utilisateurs = getAllUtilisateurs();
            foreach(Utilisateur user in utilisateurs) {
                if(user.LoginUtilisateur == username)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean authentify(String username, String password)
        {
            bool authentified = isRegistered(username);
            if (authentified == true)
            {
                if (getUtilisateur(username).MdpUtilisateur == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}