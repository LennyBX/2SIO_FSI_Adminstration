INSERT INTO CLASSE (acronymeClasse, libelleClasse) VALUES
('DI', 'Licence développeur et infrastructure'),
('CSI', 'Bachelor Concepteur de Système d''Information');

INSERT INTO COURS (libelleCours, descriptionCours, idClasse) VALUES
('BLOC 2', 'Beaucoup d''infrastructure', 1),
('BLOC 1', 'Beaucoup de programmation', 2);

INSERT INTO ETUDIANT (nomEtudiant, prenomEtudiant, numeroEtudiant, mailEtudiant, idClasse) VALUES
('Singier', 'Romain', '0691827304', 'r.singier@lyon.ort.asso.fr', 1),
('Dupont', 'Remy', '0691027461', 'r.dupont@lyon.ort.asso.fr', 1),
('Castre', 'Alexandra', '0799017492', 'a.castre@lyon.ort.asso.fr', 1),
('Hazaki', 'Tokyo', '0677299410', 't.hazaki@lyon.ort.asso.fr', 2),
('Fournil', 'Dimitri', '0731002251', 'd.fournil@lyon.ort.asso.fr', 2);

INSERT INTO UTILISATEUR (loginutilisateur, mdputilisateur) VALUES
('Magali', 'MAG'),
('Mathys', 'aze'),
('Lenny', '123');

INSERT INTO LOG (typeLog, tableLog, descLog, dateLog) VALUES
('INSERT', 'ALL', 'Ajout de toutes les valeurs nécessaires', GETDATE());