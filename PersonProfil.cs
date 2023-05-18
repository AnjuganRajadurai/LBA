using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBA
{
    public partial class PersonProfil : Form
    {
        public MainPage mainPage;

        public PersonProfil()
        {
            InitializeComponent();
        }
        private void PersonProfil_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'lba_testDataSet.T_Nationality'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.t_NationalityTableAdapter.Fill(this.lba_testDataSet.T_Nationality);

        }

        private void btnPersonProfilEmpty_Click(object sender, EventArgs e)
        {
            txtPersonProfilLastName.Clear();
            txtPersonProfilFirstName.Clear();
            txtPersonProfilOtherName.Clear();
            txtPersonProfilRoad.Clear();
            txtPersonProfilCity.Clear();
            txtPersonProfilCountry.Clear();
            cmbPersonProfilNationality.SelectedItem = null;
            dtpPersonProfilBirthday.Value = DateTime.Now.AddYears(-18);
            txtPersonProfilJob.Clear();
            cmbPersonProfilDocType.SelectedItem = null;
            dtpPersonProfilIdValidity.Value = DateTime.Now;
            txtPersonProfilDocNumber.Clear();
            rtbPersonProfilComment.Clear();
        }

        private void btnPersonProfilSave_Click(object sender, EventArgs e)
        {
            lba_testEntities1 db = new lba_testEntities1();

            var personToModify = db.T_Person.Where(x => x.personId == personIdToModify).FirstOrDefault();
            personToModify.lastName = txtPersonProfilLastName.Text;
            personToModify.firstName = txtPersonProfilFirstName.Text;
            personToModify.otherName = txtPersonProfilOtherName.Text;
            personToModify.nationalityFk = cmbPersonProfilNationality.SelectedIndex + 1;
            personToModify.birthday = dtpPersonProfilBirthday.Value;
            personToModify.commentPerson = rtbPersonProfilComment.Text;
            personToModify.road = txtPersonProfilRoad.Text;
            personToModify.city = txtPersonProfilCity.Text;
            personToModify.country = txtPersonProfilCountry.Text;
            personToModify.job = txtPersonProfilJob.Text;
            personToModify.documentType = cmbPersonProfilDocType.Text;
            personToModify.idValidity = dtpPersonProfilIdValidity.Value;
            db.Entry(personToModify).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            mainPage.searchClient();

            System.Windows.Forms.MessageBox.Show("Client modifié avec succès");
            this.Close();
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                lba_testEntities1 db = new lba_testEntities1();

                var personToDelete = db.T_Person.Where(p => p.personId == personIdToModify).FirstOrDefault();
                db.T_Person.Remove(personToDelete);
                db.SaveChanges();
                mainPage.searchClient();
                this.Close();


                System.Windows.Forms.MessageBox.Show("Client supprimé avec succès !");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Il y a eu un problème lors de la suppression du client !");
            }
        }
    }
}
