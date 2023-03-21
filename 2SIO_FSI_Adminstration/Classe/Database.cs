using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Classe getClasse(String libelleClasse)
        {
            Classe classe = new Classe();

            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM classe where libelleclasse = :libelle;", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("libelle", NpgsqlDbType.Varchar)).Value = libelleClasse;
            npgsqlCommand.Prepare();
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            if (npgsqlDataReader.Read())
            {
                classe.IdClasse = npgsqlDataReader.GetInt32(0);
                classe.LibelleClasse = npgsqlDataReader.GetString(1);
            }
            npgsqlConnection.Close();
            return classe;
        }

        public List<Classe> getAllClasses()
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM classe;", npgsqlConnection);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            List<Classe> classes = new List<Classe>();
            while (npgsqlDataReader.Read())
            {
                int idClasse = npgsqlDataReader.GetInt32(0);
                String libelleClasse = npgsqlDataReader.GetString(1);
                classes.Add(new Classe(idClasse, libelleClasse));
            }
            npgsqlConnection.Close();
            return classes;
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
                utilisateurs.Add(new Utilisateur(idUser, loginUser, passwordUser));
            }
            npgsqlConnection.Close();
            return utilisateurs;
        }

        public List<Etudiant> getAllEtudiants()
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM etudiant;", npgsqlConnection);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            List<Etudiant> etudiants = new List<Etudiant>();
            while (npgsqlDataReader.Read())
            {
                int idEtudiant = npgsqlDataReader.GetInt32(0);
                String nomEtudiant = npgsqlDataReader.GetString(1);
                String prenomEtudiant = npgsqlDataReader.GetString(2);
                int idClasse = npgsqlDataReader.GetInt32(3);
                etudiants.Add(new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant, idClasse));
            }
            npgsqlConnection.Close();
            return etudiants;
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

        public void newUtilisateur(String nom, String prenom, int idclasse)
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("INSERT INTO etudiant (nometudiant, prenometudiant, idclasse) VALUES (:nom, :prenom, :idclasse);", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("nom", NpgsqlDbType.Varchar)).Value = prenom;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("prenom", NpgsqlDbType.Varchar)).Value = nom;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("idclasse", NpgsqlDbType.Integer)).Value = idclasse;
            npgsqlCommand.Prepare();
            npgsqlCommand.CommandType = CommandType.Text;
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        public void newClasse(String libelle)
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("INSERT INTO classe (libelleclasse) VALUES (:libelle);", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("libelle", NpgsqlDbType.Varchar)).Value = libelle;
            npgsqlCommand.Prepare();
            npgsqlCommand.CommandType = CommandType.Text;
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
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