DROP TABLE IF EXISTS UTILISATEUR;
DROP TABLE IF EXISTS ETUDIANT;
DROP TABLE IF EXISTS COURS;
DROP TABLE IF EXISTS CLASSE;
DROP TABLE IF EXISTS LOG;

CREATE TABLE CLASSE (
   idClasse serial,
   acronymeClasse VARCHAR(10),
   libelleClasse VARCHAR(50),
   CONSTRAINT classe_PK PRIMARY KEY(idClasse)
);

CREATE TABLE COURS (
   idCours serial,
   libelleCours VARCHAR(20) NOT NULL,
   descriptionCours VARCHAR(100) NOT NULL,
   idClasse INT NOT NULL,
   CONSTRAINT cours_PK PRIMARY KEY(idCours),
   CONSTRAINT cours_classe_FK FOREIGN KEY(idClasse) REFERENCES CLASSE(idClasse)
);

CREATE TABLE ETUDIANT (
   idEtudiant serial,
   nomEtudiant VARCHAR(50) NOT NULL,
   prenomEtudiant VARCHAR(50) NOT NULL,
   numeroEtudiant VARCHAR(10) NOT NULL,
   mailEtudiant VARCHAR(50) NOT NULL,
   idClasse INT NOT NULL,
   CONSTRAINT eleve_PK PRIMARY KEY(idEtudiant),
   CONSTRAINT eleve_classe_FK FOREIGN KEY(idClasse) REFERENCES CLASSE(idClasse)
);


CREATE TABLE UTILISATEUR (
   idUtilisateur serial,
   loginUtilisateur VARCHAR(50) NOT NULL,
   mdpUtilisateur VARCHAR(255) NOT NULL,
   CONSTRAINT utilisateur_PK PRIMARY KEY(idUtilisateur)
);

CREATE TABLE LOG (
   idLog serial,
   typeLog VARCHAR(50) NOT NULL,
   tableLog VARCHAR(50) NOT NULL,
   descLog VARCHAR(255) NOT NULL,
   dateLog DATE NOT NULL,
   CONSTRAINT log_PK PRIMARY KEY(idLog)
);

