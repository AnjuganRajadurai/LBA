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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        public void searchClient()
        {
            dataGridView1.Columns.Clear();

            lba_testEntities1 db = new lba_testEntities1();

            dataGridView1.DataSource = db.T_Person.Join(db.T_Nationality, p => p.nationalityFk, n => n.nationalityId, (p, n) => new
            {
                p.lastName,
                p.firstName,
                p.otherName,
                p.road,
                p.city,
                p.country,
                p.birthday,
                n.countryName,
                p.commentPerson,
                p.documentType,
                p.idValidity,
                p.docNumber,
                p.job,
                p.personId
            }).Where(x=>x.firstName.Contains(txtSearchClient.Text) || x.lastName.Contains(txtSearchClient.Text) || x.otherName.Contains(txtSearchClient.Text)).ToList();

            dataGridView1.Columns[0].HeaderText = "Nom";
            dataGridView1.Columns[1].HeaderText = "Prénom";
            dataGridView1.Columns[2].HeaderText = "Autre Noms";
            dataGridView1.Columns[3].HeaderText = "Rue et N°";
            dataGridView1.Columns[4].HeaderText = "Ville";
            dataGridView1.Columns[5].HeaderText = "Pays";
            dataGridView1.Columns[6].HeaderText = "Date de naissance";
            dataGridView1.Columns[7].HeaderText = "Nationalité";
            dataGridView1.Columns[8].HeaderText = "Commentaire";
            dataGridView1.Columns[9].HeaderText = "Type de document";
            dataGridView1.Columns[10].HeaderText = "Date d'expiration";
            dataGridView1.Columns[11].HeaderText = "Numéro de document";
            dataGridView1.Columns[12].HeaderText = "Profession";
            dataGridView1.Columns[13].Visible = false;

            DataGridViewButtonColumn btnViewPersonProfil = new DataGridViewButtonColumn();
            btnViewPersonProfil.HeaderText = "";
            btnViewPersonProfil.Name = "btnSeePersonProfil";
            btnViewPersonProfil.Text = "Profil";
            btnViewPersonProfil.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnViewPersonProfil);

            DataGridViewButtonColumn btnViewPersonOperation = new DataGridViewButtonColumn();
            btnViewPersonOperation.HeaderText = "";
            btnViewPersonOperation.Name = "btnViewPersonOperation";
            btnViewPersonOperation.Text = "Hist. transactions";
            btnViewPersonOperation.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnViewPersonOperation);

            DataGridViewButtonColumn btnAddOperationOnPerson = new DataGridViewButtonColumn();
            btnAddOperationOnPerson.HeaderText = "";
            btnAddOperationOnPerson.Name = "btnAddOPerationOnPerson";
            btnAddOperationOnPerson.Text = "Aj. transaction";
            btnAddOperationOnPerson.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnAddOperationOnPerson);
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            searchClient();
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            searchClient();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 14)
            {
                PersonProfil display3 = new PersonProfil();
                display3.mainPage = this;
                display3.txtPersonProfilLastName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                display3.txtPersonProfilFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                display3.txtPersonProfilOtherName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                display3.txtPersonProfilRoad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                display3.txtPersonProfilCity.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                display3.txtPersonProfilCountry.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                display3.dtpPersonProfilBirthday.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                display3.cmbPersonProfilNationality.SelectedIndex = display3.cmbPersonProfilNationality.FindStringExact(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                display3.rtbPersonProfilComment.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                display3.cmbPersonProfilDocType.SelectedIndex = display3.cmbPersonProfilDocType.FindStringExact(dataGridView1.CurrentRow.Cells[9].Value.ToString());
                display3.dtpPersonProfilIdValidity.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
                display3.txtPersonProfilDocNumber.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                display3.txtPersonProfilJob.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                display3.personIdToModify = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                display3.Show();

            }
            else if(e.ColumnIndex == 15)
            {


            }
            else if (e.ColumnIndex == 16)
            {
                AddOperation display6 = new AddOperation();
                display6.personToAddOperation = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                display6.Show();
            }
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            AddOperation display6 = new AddOperation();
            display6.Show();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson display4 = new AddPerson();
            display4.mainPage = this;
            display4.Show();
        }
    }
}
