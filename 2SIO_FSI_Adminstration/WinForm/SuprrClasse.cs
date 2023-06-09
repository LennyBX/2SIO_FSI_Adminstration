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
            if (cls != "")
            {
                foreach (Classe.Classe clse in cl)
                {
                    if (cls == clse.LibelleClasse)
                    {
                        database.deleteClasse(clse.IdClasse);
                        MessageBox.Show("Classe " + clse.LibelleClasse + " supprimé avec succès !");
                        refreshClasseList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe !");
            }
        }
    }
}
