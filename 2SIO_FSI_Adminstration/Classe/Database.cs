﻿using Npgsql;
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

        /// <summary>
        /// Instance permettant d'utiliser une BDD MySQL dans tout le projet
        /// </summary>
        public Database()
        {
            String connectionString = "Server=" + hostname + ";Port=" + port + ";Database=" + database + ";User Id=" + user + ";Password=" + password + ";";
            npgsqlConnection = new NpgsqlConnection(connectionString);
        }

        public void newLog(string type, string table, string description)
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("INSERT INTO log (typeLog, tableLog, descLog, dateLog) VALUES (:type, :table, :description, :date);", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("type", NpgsqlDbType.Varchar)).Value = type;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("table", NpgsqlDbType.Varchar)).Value = table;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("description", NpgsqlDbType.Varchar)).Value = description;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("date", NpgsqlDbType.Date)).Value = DateTime.Now;
            npgsqlCommand.Prepare();
            npgsqlCommand.CommandType = CommandType.Text;
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        /////////////////////////////////
        /// Requêtes pour les classes ///
        /////////////////////////////////

        /// <summary>
        /// Permet de récupérer une liste d'objet Classe de la BDD
        /// </summary>
        /// <returns></returns>
        public List<Classe> getAllClasses()
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM classe;", npgsqlConnection);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            List<Classe> classes = new List<Classe>();
            while (npgsqlDataReader.Read())
            {
                int idClasse = npgsqlDataReader.GetInt32(0);
                String acronymeClasse = npgsqlDataReader.GetString(1);
                String libelleClasse = npgsqlDataReader.GetString(2);
                classes.Add(new Classe(idClasse, acronymeClasse, libelleClasse));
            }
            npgsqlConnection.Close();
            return classes;
        }

        /// <summary>
        /// Permet de récupérer un objet Classe en fonction de son ID de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Classe getClasseById(int id)
        {
            Classe classe = new Classe();

            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM classe where idclasse = :id;", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = id;
            npgsqlCommand.Prepare();
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

            if (npgsqlDataReader.Read())
            {
                classe.IdClasse = npgsqlDataReader.GetInt32(0);
                classe.AcronymeClasse = npgsqlDataReader.GetString(1);
                classe.LibelleClasse = npgsqlDataReader.GetString(2);
            }
            npgsqlConnection.Close();
            return classe;
        }

        /// <summary>
        /// Permet de récupérer un objet Classe en fonction de son libellé de la BDD
        /// </summary>
        /// <param name="libelleClasse"></param>
        /// <returns></returns>
        public Classe getClasseByLibelle(String libelleClasse)
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
                classe.AcronymeClasse = npgsqlDataReader.GetString(1);
                classe.LibelleClasse = npgsqlDataReader.GetString(2);
            }
            npgsqlConnection.Close();
            return classe;
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle classe dans la BDD
        /// </summary>
        /// <param name="libelle"></param>
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

        //////////////////////////////////////
        /// Requêtes pour les utilisateurs ///
        //////////////////////////////////////

        /// <summary>
        /// Permet de récupérer une liste d'objet Utilisateur de la BDD
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Permet de récupérer un objet Utilisateur en fonction de son nom d'utilisateur de la BDD
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Utilisateur getUtilisateurByUsername(String username)
        {
            List<Utilisateur> utilisateurs = getAllUtilisateurs();
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                if (utilisateur.LoginUtilisateur == username)
                {
                    return utilisateur;
                }
            }
            return null;
        }

        ///////////////////////////////////
        /// Requêtes pour les étudiants ///
        ///////////////////////////////////

        /// <summary>
        /// Permet de récupérer une liste d'objet Etudiant de la BDD
        /// </summary>
        /// <returns></returns>
        public List<Etudiant> getAllEtudiants()
        {
            List<Classe> classes = getAllClasses();
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM etudiant;", npgsqlConnection);
            NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();
            
            List<Etudiant> etudiants = new List<Etudiant>();
            while (npgsqlDataReader.Read())
            {
                int idEtudiant = npgsqlDataReader.GetInt32(0);
                String nomEtudiant = npgsqlDataReader.GetString(1);
                String prenomEtudiant = npgsqlDataReader.GetString(2);
                String numeroEtudiant = npgsqlDataReader.GetString(3);
                String mailEtudiant = npgsqlDataReader.GetString(4);
                Classe classeEtudiant = new Classe();
                foreach (Classe classe in classes)
                {
                    if (classe.IdClasse == npgsqlDataReader.GetInt32(5))
                    {
                        classeEtudiant = classe;
                    }
                }
                etudiants.Add(new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant, numeroEtudiant, mailEtudiant, classeEtudiant));
                
            }
            npgsqlConnection.Close();
            return etudiants;
        }

        /// <summary>
        /// Permet d'ajouter un nouvel utilisateur dans la BDD
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="idclasse"></param>
        public void newEtudiant(Etudiant etu)
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("INSERT INTO etudiant (nometudiant, prenometudiant, numeroetudiant, mailetudiant, idclasse) VALUES (:nom, :prenom, :numero, :mail, :idclasse);", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("nom", NpgsqlDbType.Varchar)).Value = etu.NomEtudiant;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("prenom", NpgsqlDbType.Varchar)).Value = etu.PrenomEtudiant;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("numero", NpgsqlDbType.Varchar)).Value = etu.NumeroEtudiant;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("mail", NpgsqlDbType.Varchar)).Value = etu.MailEtudiant;
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("idclasse", NpgsqlDbType.Integer)).Value = etu.ClasseEtudiant.IdClasse;
            npgsqlCommand.Prepare();
            npgsqlCommand.CommandType = CommandType.Text;
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
            newLog("INSERT INTO", "ETUDIANT", "Ajout d'un nouvel étudiant " + etu.getFullName());
        }

        /// <summary>
        /// Permet de supprimer un étudiant de la BDD
        /// </summary>
        /// <param name="id"></param>
        public void deleteEtudiant(int id)
        {
            npgsqlConnection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand("DELETE FROM etudiant WHERE idEtudiant = :id;", npgsqlConnection);
            npgsqlCommand.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Integer)).Value = id;
            npgsqlCommand.Prepare();
            npgsqlCommand.CommandType = CommandType.Text;
            npgsqlCommand.ExecuteNonQuery();
            npgsqlConnection.Close();
        }

        /////////////////////////
        /// Requêtes diverses ///
        /////////////////////////

        /// <summary>
        /// Permet de vérifier si un utilisateur est enregistré dans la BDD
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Permet de vérifier si le mot de passe entré est le même que celui stocké en BDD
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Boolean authentify(String username, String password)
        {
            bool authentified = isRegistered(username);
            if (authentified == true)
            {
                if (getUtilisateurByUsername(username).MdpUtilisateur == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}