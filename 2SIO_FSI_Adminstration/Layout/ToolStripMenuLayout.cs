using _2SIO_FSI_Adminstration.WinForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.Classe
{
    public class ToolStripMenuLayout
    {
        Utilisateur utilisateur;
        Form activeForm;

        public ToolStripMenuLayout(Form form, Utilisateur utilisateurP)
        {
            activeForm = form;
            utilisateur = utilisateurP;
        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Form formAccueil = new Accueil(utilisateur);
            formAccueil.Show();
        }

        public void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Form formListeEtudiant = new ListeEtudiant(utilisateur);
            formListeEtudiant.Show();
        }

        public void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Form formAjouterEtudiant = new AjoutEtudiant(utilisateur);
            formAjouterEtudiant.Show();
        }

        public void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Form formListeClasse = new ListeClasse(utilisateur);
            formListeClasse.Show();
        }
    }
}
