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
        public string userGroup;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }   

        //Booleans to know what to display
        private bool userIsReadOnly()
        {
            return(userGroup == "G-MONC1-APP-LBA-R");
        }

        private bool userIsWriteOnly()
        {
            return(userGroup == "G-MONC1-APP-LBA-W");
        }

        //Function to display the researched client for -R users
        public void searchClientReadOnly()
        {
            if (string.IsNullOrWhiteSpace(txtSearchClient.Text))
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
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
                }).Where(x => x.firstName.Contains(txtSearchClient.Text) || x.lastName.Contains(txtSearchClient.Text) || x.otherName.Contains(txtSearchClient.Text)).ToList();

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

                DataGridViewButtonColumn btnViewPersonOperation = new DataGridViewButtonColumn();
                btnViewPersonOperation.HeaderText = "";
                btnViewPersonOperation.Name = "btnViewPersonOperation";
                btnViewPersonOperation.Text = "Hist. transactions";
                btnViewPersonOperation.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnViewPersonOperation);
            }
        }

        //Function to display the researched client for -W, -RW and ADM users
        public void searchClientWrite()
        {
            searchClientReadOnly();
            DataGridViewButtonColumn btnViewPersonProfil = new DataGridViewButtonColumn();
            btnViewPersonProfil.HeaderText = "";
            btnViewPersonProfil.Name = "btnSeePersonProfil";
            btnViewPersonProfil.Text = "Profil";
            btnViewPersonProfil.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnViewPersonProfil);

            DataGridViewButtonColumn btnAddOperationOnPerson = new DataGridViewButtonColumn();
            btnAddOperationOnPerson.HeaderText = "";
            btnAddOperationOnPerson.Name = "btnAddOPerationOnPerson";
            btnAddOperationOnPerson.Text = "Aj. transaction";
            btnAddOperationOnPerson.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnAddOperationOnPerson);
        }

        //Function to know what to display
        public void searchClient()
        {
            if (userIsReadOnly())
            {
                searchClientReadOnly();
            }
            else
            {
                searchClientWrite();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if (userIsReadOnly())
            {
                btnAddPerson.Visible = false;
                btnAddOperation.Visible = false;
                searchClientReadOnly();
            }
            else
            {
                searchClientWrite();
            }
        }

        //Reloads the searched client results
        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            searchClient();
        }

        //Function to open AddOperation, AddPerson, PersonProfil or OperationHistory 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userIsReadOnly())
            {
                if (e.ColumnIndex == 14)
                {
                    OperationHistory display8 = new OperationHistory();
                    display8.btnOperationHistoryAdd.Visible = false;
                    display8.personIdToViewOperation = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                    display8.ShowDialog();
                }
                else if (e.ColumnIndex == 15)
                {
                    PersonProfil display3 = new PersonProfil();
                    display3.btnPersonProfilSave.Visible = false;
                    display3.btnPersonProfilEmpty.Visible = false;
                    display3.btnDeletePerson.Visible = false;
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
                    display3.ShowDialog();
                }
            }
            else if (userIsWriteOnly())
            {

                if (e.ColumnIndex == 14)
                {
                    OperationHistory display8 = new OperationHistory();
                    display8.personIdToViewOperation = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                    display8.ShowDialog();
                }
                else if (e.ColumnIndex == 15)
                {
                    PersonProfil display3 = new PersonProfil();
                    display3.btnPersonProfilSave.Visible = false;
                    display3.btnPersonProfilEmpty.Visible = false;
                    display3.btnDeletePerson.Visible = false;
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
                    display3.ShowDialog();
                }
                else if (e.ColumnIndex == 16)
                {
                    AddOperation display6 = new AddOperation();
                    display6.personToAddOperation = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                    display6.normalOperation = true;
                    display6.ShowDialog();
                }
            }
            else
            {
                if (e.ColumnIndex == 14)
                {
                    OperationHistory display8 = new OperationHistory();
                    display8.personIdToViewOperation = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                    display8.ShowDialog();
                }
                else if (e.ColumnIndex == 15)
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
                    display3.ShowDialog();
                }
                else if (e.ColumnIndex == 16)
                {
                    AddOperation display6 = new AddOperation();
                    display6.personToAddOperation = int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());
                    display6.normalOperation = true;
                    display6.ShowDialog();
                }
            }
        }

        //Button to open AddOperation
        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            AddOperation display6 = new AddOperation();
            AddPerson display4 = new AddPerson();
            display6.addPerson = display4;
            display6.Show();

            display4.mainPage = this;
            display4.Show();
        }

        //Button to open AddPerson
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddPerson>().Count() == 1)
            {
                System.Windows.Forms.MessageBox.Show("Veuillez d'abord fermer la première fenêtre !");
            }
            else
            {
                AddPerson display4 = new AddPerson();
                display4.mainPage = this;
                display4.ShowDialog();
            }
        }

        //Button to clear the fields
        private void btnMainPageEmpty_Click(object sender, EventArgs e)
        {
            txtSearchClient.Clear();
            txtSearchClient.Focus();
        }
    }
}
