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
    public partial class AddOperation : Form
    {
        public AddOperation()
        {
            InitializeComponent();
        }

        private void addOperation()
        {
            try
            {
                lba_testEntities1 db = new lba_testEntities1();

                decimal operationAmountLimit = db.T_Limit.Select(l=>l.limitAmount).FirstOrDefault();
                if (operationAmountLimit < decimal.Parse(txtOperationAmount.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Le montant dépasse la limite fixée !");
                }

                db.T_Operation.Add(new T_Operation()
                {
                    personFk = personToAddOperation,
                    operationTypeFk = cmbAddOperationType.SelectedIndex + 1,
                    operatorName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1],
                    cashdesk = System.Environment.MachineName,
                    cession = true,
                    retrocession = false,
                    operationDate = DateTime.Now,
                    operationAmount = decimal.Parse(txtOperationAmount.Text),
                    operationComment = cmbAddOperationComment.Text
                });
                db.SaveChanges();
                System.Windows.Forms.MessageBox.Show("Transaction ajoutée avec succès !");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Il y a eu un problème lors de l'ajout de la nouvelle transaction !");
            }
        }
        private void btnAddOperationEmpty_Click(object sender, EventArgs e)
        {
            cmbAddOperationType.SelectedItem = null;
            txtOperationAmount.Clear();
            cmbAddOperationComment.SelectedItem = null;
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            addOperation();
            this.Close();
        }

        private void AddOperation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'lba_testDataSet.T_OperationType'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.t_OperationTypeTableAdapter.Fill(this.lba_testDataSet.T_OperationType);

        }
    }
}
