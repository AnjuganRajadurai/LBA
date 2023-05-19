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
    public partial class OperationHistory : Form
    {
        public OperationHistory()
        {
            InitializeComponent();
        }
        public void viewOperation()
        {
            lba_testEntities1 db = new lba_testEntities1();

            DateTime conditionDate2 = dtpOperationHistory2.Value.Date.AddDays(1);

            dataGridView1.DataSource = db.T_Operation.Join(db.T_Person, o => o.personFk, p => p.personId, (o, p) => new
            {
                p.lastName,
                p.firstName,
                o.operationTypeFk,
                o.operatorName,
                o.cashdesk,
                o.operationDate,
                o.operationAmount,
                o.operationComment,
                p.personId,
                o.operationId
            }).Join(db.T_OperationType, o => o.operationTypeFk, t => t.operationTypeId, (o, t) => new
            {
                o.lastName,
                o.firstName,
                t.operationTypeName,
                t.operationDetailFk,
                o.operatorName,
                o.cashdesk,
                o.operationDate,
                o.operationAmount,
                o.operationComment,
                o.personId,
                o.operationId
            }).Join(db.T_OperationDetail, o => o.operationDetailFk, d => d.operationDetailId, (o, d) => new
            {
                o.lastName,
                o.firstName,
                o.operationTypeName,
                d.operationDetailName,
                o.operatorName,
                o.cashdesk,
                o.operationDate,
                o.operationAmount,
                o.operationComment,
                o.personId,
                o.operationId
            }).Where(o => o.personId == personIdToViewOperation && o.operationDate >= dtpOperationHistory1.Value.Date  && o.operationDate <= conditionDate2.Date).ToList();

            dataGridView1.Columns[0].HeaderText = "Nom";
            dataGridView1.Columns[1].HeaderText = "Prénom";
            dataGridView1.Columns[2].HeaderText = "Type de transaction";
            dataGridView1.Columns[3].HeaderText = "Détail de transaction";
            dataGridView1.Columns[4].HeaderText = "Caissier";
            dataGridView1.Columns[5].HeaderText = "Caisse";
            dataGridView1.Columns[6].HeaderText = "Date de la transaction";
            dataGridView1.Columns[7].HeaderText = "Montant de la transaction";
            dataGridView1.Columns[8].HeaderText = "Commentaire";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }
        private void OperationHistory_Load(object sender, EventArgs e)
        {
            viewOperation();
        }

        private void dtpOperationHistory1_ValueChanged(object sender, EventArgs e)
        {
            viewOperation();
        }

        private void dtpOperationHistory2_ValueChanged(object sender, EventArgs e)
        {
            viewOperation();
        }

        private void btnOperationHistoryAdd_Click(object sender, EventArgs e)
        {
            AddOperation display6 = new AddOperation();
            display6.personToAddOperation = personIdToViewOperation;
            display6.operationHistory = this;
            display6.normalOperation = true;
            display6.Show();
        }
    }
}
