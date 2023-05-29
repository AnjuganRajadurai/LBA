using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //Function to delete a person
        private void deletePerson()
        {
            lba_testEntities1 db = new lba_testEntities1();

            int hasOperation = db.T_Operation.Join(db.T_Person, o => o.personFk, p => p.personId, (o, p) => new
            {
                o.personFk,
                o.operationId
            }).Where(o=>o.personFk == personIdToModify).Select(o=>o.operationId).Count();
            if (hasOperation >=1)
            {
                System.Windows.Forms.MessageBox.Show("Impossible de supprimer ce client car il possède une ou plusieures transactions !");
            }
            else
            {
                try
                {

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

        //Function to save the modifications
        private void personProfilSave()
        {
            string patternNames = @"^[\p{L} \.'\-]+$";
            string patternCountry = @"^[a-zA-Z]+$";
            string patternJob = @"^[a-zA-Z]+$";

            if (Regex.IsMatch(txtPersonProfilFirstName.Text, patternNames) && Regex.IsMatch(txtPersonProfilLastName.Text, patternNames) && Regex.IsMatch(txtPersonProfilCountry.Text, patternCountry, RegexOptions.IgnorePatternWhitespace) && Regex.IsMatch(txtPersonProfilJob.Text, patternJob))
            {
                if (dtpPersonProfilBirthday.Value <= DateTime.Now.AddYears(-18))
                {
                    if (dtpPersonProfilIdValidity.Value >= DateTime.Now.AddDays(-1))
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

                        this.Close();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("La date d'expiration est déjà dépassée !");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Le client n'a pas 18 ans !");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Un champ 'Nom' ou 'Pénom' ne respecte pas les règles d'insertions !");
            }
        }

        //Button to empty the fields
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

        //Button to save the modifications
        private void btnPersonProfilSave_Click(object sender, EventArgs e)
        {
            personProfilSave();
        }

        //Button to delete the person
        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            deletePerson();
        }
    }
}
