using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LBA
{
    public partial class AddPerson : Form
    {
        public MainPage mainPage;
        public int lastIdAdded;
        public bool operationCanceled = true;

        public AddPerson()
        {
            InitializeComponent();
        }

        //Special close if AddPerson is closed before AddOperation
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (operationCanceled)
            {
                if (Application.OpenForms.OfType<AddOperation>().Count() == 1)
                {
                    Application.OpenForms.OfType<AddOperation>().First().Close();
                }
            }

        }

        //Function to add a person
        private void addPerson()
        {
            string patternNames = @"^[\p{L} \.'\-]+$";
            string patternCountry = @"^[a-zA-Z]+$";
            string patternJob = @"^[a-zA-Z]+$";

            if (Regex.IsMatch(txtAddPersonFirstName.Text,patternNames) && Regex.IsMatch(txtAddPersonLastName.Text, patternNames)  && Regex.IsMatch(txtAddPersonOtherName.Text, patternNames) && Regex.IsMatch(txtAddPersonCountry.Text, patternCountry,RegexOptions.IgnorePatternWhitespace) && Regex.IsMatch(txtAddPersonJob.Text, patternJob))
            {
                lba_testEntities1 db = new lba_testEntities1();

                var lastPersonAdded = db.T_Person.Add(new T_Person()
                {
                    lastName = txtAddPersonLastName.Text,
                    firstName = txtAddPersonFirstName.Text,
                    otherName = txtAddPersonOtherName.Text,
                    road = txtAddPersonRoad.Text,
                    city = txtAddPersonCity.Text,
                    country = txtAddPersonCountry.Text,
                    nationalityFk = cmbAddPersonNationality.SelectedIndex + 1,
                    birthday = dtpAddPersonBirthday.Value,
                    job = txtAddPersonJob.Text,
                    documentType = cmbAddPersonDocType.Text,
                    idValidity = dtpAddPersonIdValidity.Value,
                    docNumber = txtAddPersonDocNumber.Text,
                    commentPerson = rtbAddPersonComment.Text
                });
                db.SaveChanges();
                lastIdAdded = lastPersonAdded.personId;
                mainPage.searchClient();
                operationCanceled = false;
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Les champs ne respectent pas les règles !");
            }
            
        }

        //Button to empty the fields
        private void btnAddPersonEmpty_Click(object sender, EventArgs e)
        {
            txtAddPersonLastName.Clear();
            txtAddPersonFirstName.Clear();
            txtAddPersonOtherName.Clear();
            txtAddPersonRoad.Clear();
            txtAddPersonCity.Clear();
            txtAddPersonCountry.Clear();
            cmbAddPersonNationality.SelectedItem = null;
            dtpAddPersonBirthday.Value = DateTime.Now.AddYears(-18);
            txtAddPersonJob.Clear();
            cmbAddPersonDocType.SelectedItem = null;
            dtpAddPersonIdValidity.Value = DateTime.Now;
            txtAddPersonDocNumber.Clear();
            rtbAddPersonComment.Clear();
        }

        //Button to add a person
        private void btnAddPersonSave_Click(object sender, EventArgs e)
        {
            try
            {
                lba_testEntities1 db = new lba_testEntities1();

                int selectedCountry = cmbAddPersonNationality.SelectedIndex +1;
                bool countryIsRisked = db.T_Nationality.Where(n => n.nationalityId == selectedCountry).Select(n => n.countryRisk).FirstOrDefault();

                if (countryIsRisked)
                {
                    System.Windows.Forms.MessageBox.Show("Sa nationalité est un pays à risque !");

                }
                addPerson();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Il y a eu un problème lors de l'ajout du client !");
            }
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'lba_testDataSet.T_Nationality'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.t_NationalityTableAdapter.Fill(this.lba_testDataSet.T_Nationality);
            dtpAddPersonBirthday.Value = DateTime.Now.AddYears(-18);
            cmbAddPersonNationality.SelectedIndex = 190;

        }
    }
}
