using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class SuprrClasse : Form
    {

        Utilisateur utilisateur;
        List<Classe.Classe> cl = new List<Classe.Classe>();
        Database database = new Database();
        public SuprrClasse(Utilisateur utilisateur1)
        {
            InitializeComponent();
            utilisateur = utilisateur1;
            refreshClasseList();
        }

        public void refreshClasseList()
        {
            cbListeClasse.Items.Clear();
            cl = database.getAllClasses();
            foreach (Classe.Classe cr in cl)
            {
                cbListeClasse.Items.Add(cr.LibelleClasse);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new Accueil(utilisateur);
            newForm.Show();
        }

        private void SuprrClasse_Load(object sender, EventArgs e)
        {
        
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            string cls = this.cbListeClasse.GetItemText(this.cbListeClasse.SelectedItem);
            List<Etudiant> etudiants = database.getAllEtudiants();

            Classe.Classe cls1 = new Classe.Classe();

            if (cls != "")
            {

                foreach (Classe.Classe clse in cl)
                {

                    if (cls == clse.LibelleClasse)
                    {
                        cls1 = clse;
                    }
                }

                List<Etudiant> errorEtudiants = new List<Etudiant>();
                foreach (Etudiant etudiant in errorEtudiants)
                {
                    if (etudiant.ClasseEtudiant.IdClasse == cls1.IdClasse)
                    {
                        errorEtudiants.Add(etudiant);
                    }
                }

                List<Cours> errorCours = new List<Cours>();
                foreach (Cours cours in errorCours)
                {
                    MessageBox.Show(cours.ClasseCours.IdClasse.ToString());
                    if (cours.ClasseCours.IdClasse == cls1.IdClasse)
                    {
                        errorCours.Add(cours);
                    }
                }

                if (errorEtudiants.Count > 0 || errorCours.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Des étudiants ou des cours sont associés à cette classe. Souhaitez-vous supprimer tout de même cette classe ? ATTENTION: toutes les valeurs associées à cette classe seront aussi supprimés !", "Confirmation de suppression...", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach(Etudiant errorEtu in errorEtudiants)
                            database.deleteEtudiant(errorEtu.IdEtudiant);
                        foreach (Cours cours in errorCours)
                            database.deleteCours(cours.IdCours);

                        database.deleteClasse(cls1.IdClasse);
                        MessageBox.Show("Classe " + cls1.LibelleClasse + " supprimé avec succès !");
                        refreshClasseList();

                    } else
                    {
                        MessageBox.Show("La classe n'a pas été supprimée !");
                    }
                }
                else
                {
                    database.deleteClasse(cls1.IdClasse);
                    MessageBox.Show("Classe " + cls1.LibelleClasse + " supprimé avec succès !");
                    refreshClasseList();
                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe !");
            }
        }
    }
}
