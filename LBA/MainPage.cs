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
        private void searchClient()
        {
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
            dataGridView1.Columns[10].HeaderText = "Date de validité";
            dataGridView1.Columns[11].HeaderText = "Numéro de document";
            dataGridView1.Columns[12].HeaderText = "Profession";
            dataGridView1.Columns[13].Visible = false;
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            searchClient();
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            searchClient();
        }
    }
}
