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
    public partial class ListeCour : Form
    {

        Database database = new Database();
        Utilisateur utilisateur;

        public ListeCour(Utilisateur utilisateur1)

        {
            InitializeComponent();
            utilisateur = utilisateur1;
            List<Cours> crs = database.getAllCours();
            foreach (Cours cr in crs)
            {
                dgvCour.Rows.Add(cr.LibelleCours, cr.DescriptionCours, cr.ClasseCours.LibelleClasse);
            }
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newForm = new Accueil(utilisateur);
            newForm.Show();
        }
    }
}
