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
    public partial class SupprCour : Form
    {

        Database database = new Database();
        Utilisateur utilisateur;
        List<Cours> cour = new List<Cours>();
        public SupprCour(Utilisateur utilisateur1)
        {
            utilisateur = utilisateur1;
            InitializeComponent();
            refreshCourList();
        }

        public void refreshCourList()
        {
            cbListeCour.Items.Clear();
             cour = database.getAllCours();
            foreach (Cours cr in cour)
            {
                cbListeCour.Items.Add(cr.LibelleCours);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new Accueil(utilisateur);
            newForm.Show();
        }

        private void bClearText_Click(object sender, EventArgs e)
        {
            string cours = this.cbListeCour.GetItemText(this.cbListeCour.SelectedItem);
            if (cours != "")
            {
                foreach (Cours cr in cour)
                {
                    if (cours == cr.LibelleCours)
                    {
                        database.deleteCours(cr.IdCours);
                        MessageBox.Show("Cour " + cr.LibelleCours + " supprimé avec succès !");
                        refreshCourList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cour !");
            }
        }
    }
}
