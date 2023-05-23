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
    public partial class AddOperation : Form

    {
        public AddPerson addPerson;
        public OperationHistory operationHistory;
        public bool closeOperation = true;

        public AddOperation()
        {
            InitializeComponent();
        }

        //Function to add an operation
        private void addOperation()
        {
            string patternAmount = @"^\d+([.]\d{1,2})?$";
            if (Regex.IsMatch(txtOperationAmount.Text, patternAmount))
            {
                closeOperation = true;
                if (normalOperation)
                {
                    try
                    {
                        lba_testEntities1 db = new lba_testEntities1();

                        decimal operationAmountLimit = db.T_Limit.Select(l => l.limitAmount).FirstOrDefault();
                        if (operationAmountLimit < decimal.Parse(txtOperationAmount.Text))
                        {
                            System.Windows.Forms.MessageBox.Show("Le montant dépasse la limite fixée !");
                        }
                        bool countryIsRisked = db.T_Nationality.Join(db.T_Person, n => n.nationalityId, p => p.nationalityFk, (n, p) => new
                        {
                            p.personId,
                            n.countryRisk

                        }).Where(p => p.personId == personToAddOperation).Select(n => n.countryRisk).FirstOrDefault();

                        if (countryIsRisked)
                        {
                            System.Windows.Forms.MessageBox.Show("Sa nationalité est un pays à risque !");
                        }

                        db.T_Operation.Add(new T_Operation()
                        {
                            personFk = personToAddOperation,
                            operationTypeFk = cmbAddOperationType.SelectedIndex + 1,
                            operatorName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1],
                            cashdesk = System.Environment.MachineName,
                            operationDate = DateTime.Now,
                            operationAmount = decimal.Parse(txtOperationAmount.Text),
                            operationComment = cmbAddOperationComment.Text
                        });
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Il y a eu un problème lors de l'ajout de la nouvelle transaction !");
                    }
                }
                else
                {
                    try
                    {
                        personToAddOperation = addPerson.lastIdAdded;
                        lba_testEntities1 db = new lba_testEntities1();

                        decimal operationAmountLimit = db.T_Limit.Select(l => l.limitAmount).FirstOrDefault();
                        if (operationAmountLimit < decimal.Parse(txtOperationAmount.Text))
                        {
                            System.Windows.Forms.MessageBox.Show("Le montant dépasse la limite fixée !");
                        }
                        bool countryIsRisked = db.T_Nationality.Join(db.T_Person, n => n.nationalityId, p => p.nationalityFk, (n, p) => new
                        {
                            p.personId,
                            n.countryRisk

                        }).Where(p => p.personId == personToAddOperation).Select(n => n.countryRisk).FirstOrDefault();

                        if (countryIsRisked)
                        {
                            System.Windows.Forms.MessageBox.Show("Sa nationalité est un pays à risque !");
                        }

                        db.T_Operation.Add(new T_Operation()
                        {
                            personFk = personToAddOperation,
                            operationTypeFk = cmbAddOperationType.SelectedIndex + 1,
                            operatorName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1],
                            cashdesk = System.Environment.MachineName,
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
            }
            else
            {
                closeOperation = false;
                System.Windows.Forms.MessageBox.Show("Merci de mettre un point avant vos décimales !");
            }      
        }

        //Button to empty the fields
        private void btnAddOperationEmpty_Click(object sender, EventArgs e)
        {
            cmbAddOperationType.SelectedItem = null;
            txtOperationAmount.Clear();
            cmbAddOperationComment.SelectedItem = null;
        }

        //Button to add on operation
        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            addOperation();
            if (Application.OpenForms.OfType<OperationHistory>().Count() == 1)
            {
                operationHistory.viewOperation();
            }
            if (closeOperation)
            {
                closeOperation = true;
                this.Close();
            }
        }

        private void AddOperation_Load(object sender, EventArgs e)
        {
            this.t_OperationTypeTableAdapter.Fill(this.lba_testDataSet.T_OperationType);
        }
    }
}
