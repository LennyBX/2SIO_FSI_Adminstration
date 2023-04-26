using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutCour : Form
    {

        Database database = new Database();
        Utilisateur utilisateur;

        public AjoutCour(Utilisateur utilisateur1)
        {
            utilisateur = utilisateur1;
            InitializeComponent();
        }

        private void AjoutCour_Load(object sender, EventArgs e)
        {
            foreach (Classe.Classe cl in database.getAllClasses())
            {
                cbClasse.Items.Add(cl.LibelleClasse);
            }
        }

        private void bAddCour_Click(object sender, EventArgs e)
        {
            string nom = TbNomCour.Text;
            string description = tbDesCour.Text;
            string classe = this.cbClasse.GetItemText(this.cbClasse.SelectedItem);
            Classe.Classe classeObj = database.getClasseByLibelle(classe);
            Cours cr = new Cours(0, nom, description, classeObj);


            if (nom != "" && description != "")
            {

                database.newCours(cr);
                MessageBox.Show("Cour " + cr.LibelleCours + " ajouté avec succès !");


            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs sont manquants !");
            }

        }

        private void bClearText_Click(object sender, EventArgs e)
        {
            tbDesCour.Text = "";
            TbNomCour.Text = "";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form connectionForm = new Accueil(utilisateur);
            connectionForm.Show();
        }
    }


}
