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
    public partial class AddPerson : Form
    {
        public MainPage mainPage;

        public AddPerson()
        {
            InitializeComponent();
        }
        private void addPerson()
        {
            lba_testEntities1 db = new lba_testEntities1();

            db.T_Person.Add(new T_Person()
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
            mainPage.searchClient();
            System.Windows.Forms.MessageBox.Show("Client ajouté avec succès !");
            this.Close();
        }

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

        }
    }
}
