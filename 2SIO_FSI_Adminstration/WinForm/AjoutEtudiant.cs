using _2SIO_FSI_Adminstration.Classe;
using System;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutEtudiant : Form
    {

        Database database = new Database();
        Utilisateur utilisateur;

        public AjoutEtudiant(Utilisateur utilisateur1)
        {
            utilisateur = utilisateur1;
            InitializeComponent();
        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {
            foreach (Classe.Classe cl in database.getAllClasses())
            {
                cbClasse.Items.Add(cl.LibelleClasse);
            }
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            string nom = tbLastName.Text;
            string prenom = tbFirstName.Text;
            string numero = tbNumero.Text;
            string mail = tbMail.Text;
            string classe = this.cbClasse.GetItemText(this.cbClasse.SelectedItem);
            Classe.Classe classeObj = database.getClasseByLibelle(classe);
            Etudiant etu = new Etudiant(0, nom, prenom, numero, mail, classeObj);

            if (nom != "" && prenom != "" && classe != "" && numero != "" && mail != "")
            {
                if (numero.Length == 10)
                {
                    database.newEtudiant(etu);
                    MessageBox.Show("Etudiant " + etu.getFullName() + " ajouté avec succès !");
                    bClearText_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un numéro de téléphone valide !");
                    tbNumero.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs sont manquants !");
            }

        }

        private void bClearText_Click(object sender, EventArgs e)
        {
            tbLastName.Text = "";
            tbFirstName.Text = "";
            tbNumero.Text = "";
            tbMail.Text = "";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form connectionForm = new Accueil(utilisateur);
            connectionForm.Show();
        }
    }
}
