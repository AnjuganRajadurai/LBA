
namespace LBA
{
    partial class AddOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addOperationPanel = new System.Windows.Forms.Panel();
            this.btnAddOperationEmpty = new System.Windows.Forms.Button();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.txtOperationAmount = new System.Windows.Forms.TextBox();
            this.cmbAddOperationComment = new System.Windows.Forms.ComboBox();
            this.cmbAddOperationType = new System.Windows.Forms.ComboBox();
            this.lblOperationComment = new System.Windows.Forms.Label();
            this.lblOperationAmount = new System.Windows.Forms.Label();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.lba_testDataSet = new LBA.lba_testDataSet();
            this.tOperationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_OperationTypeTableAdapter = new LBA.lba_testDataSetTableAdapters.T_OperationTypeTableAdapter();
            this.addOperationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOperationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addOperationPanel
            // 
            this.addOperationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.addOperationPanel.Controls.Add(this.btnAddOperationEmpty);
            this.addOperationPanel.Controls.Add(this.btnAddOperation);
            this.addOperationPanel.Controls.Add(this.txtOperationAmount);
            this.addOperationPanel.Controls.Add(this.cmbAddOperationComment);
            this.addOperationPanel.Controls.Add(this.cmbAddOperationType);
            this.addOperationPanel.Controls.Add(this.lblOperationComment);
            this.addOperationPanel.Controls.Add(this.lblOperationAmount);
            this.addOperationPanel.Controls.Add(this.lblOperationType);
            this.addOperationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOperationPanel.Location = new System.Drawing.Point(0, 0);
            this.addOperationPanel.Name = "addOperationPanel";
            this.addOperationPanel.Size = new System.Drawing.Size(800, 450);
            this.addOperationPanel.TabIndex = 0;
            // 
            // btnAddOperationEmpty
            // 
            this.btnAddOperationEmpty.Location = new System.Drawing.Point(478, 379);
            this.btnAddOperationEmpty.Name = "btnAddOperationEmpty";
            this.btnAddOperationEmpty.Size = new System.Drawing.Size(84, 23);
            this.btnAddOperationEmpty.TabIndex = 8;
            this.btnAddOperationEmpty.Text = "Vider";
            this.btnAddOperationEmpty.UseVisualStyleBackColor = true;
            this.btnAddOperationEmpty.Click += new System.EventHandler(this.btnAddOperationEmpty_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(619, 356);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(158, 68);
            this.btnAddOperation.TabIndex = 7;
            this.btnAddOperation.Text = "Ajouter transaction";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // txtOperationAmount
            // 
            this.txtOperationAmount.Location = new System.Drawing.Point(326, 203);
            this.txtOperationAmount.Name = "txtOperationAmount";
            this.txtOperationAmount.Size = new System.Drawing.Size(147, 20);
            this.txtOperationAmount.TabIndex = 6;
            // 
            // cmbAddOperationComment
            // 
            this.cmbAddOperationComment.FormattingEnabled = true;
            this.cmbAddOperationComment.Items.AddRange(new object[] {
            "Clarification",
            "Identification",
            "Recensement",
            "Suivi client"});
            this.cmbAddOperationComment.Location = new System.Drawing.Point(326, 225);
            this.cmbAddOperationComment.Name = "cmbAddOperationComment";
            this.cmbAddOperationComment.Size = new System.Drawing.Size(147, 21);
            this.cmbAddOperationComment.TabIndex = 5;
            // 
            // cmbAddOperationType
            // 
            this.cmbAddOperationType.DataSource = this.tOperationTypeBindingSource;
            this.cmbAddOperationType.DisplayMember = "operationTypeName";
            this.cmbAddOperationType.FormattingEnabled = true;
            this.cmbAddOperationType.Location = new System.Drawing.Point(326, 180);
            this.cmbAddOperationType.Name = "cmbAddOperationType";
            this.cmbAddOperationType.Size = new System.Drawing.Size(147, 21);
            this.cmbAddOperationType.TabIndex = 3;
            // 
            // lblOperationComment
            // 
            this.lblOperationComment.AutoSize = true;
            this.lblOperationComment.Location = new System.Drawing.Point(246, 230);
            this.lblOperationComment.Name = "lblOperationComment";
            this.lblOperationComment.Size = new System.Drawing.Size(68, 13);
            this.lblOperationComment.TabIndex = 2;
            this.lblOperationComment.Text = "Commentaire";
            // 
            // lblOperationAmount
            // 
            this.lblOperationAmount.AutoSize = true;
            this.lblOperationAmount.Location = new System.Drawing.Point(268, 205);
            this.lblOperationAmount.Name = "lblOperationAmount";
            this.lblOperationAmount.Size = new System.Drawing.Size(46, 13);
            this.lblOperationAmount.TabIndex = 1;
            this.lblOperationAmount.Text = "Montant";
            // 
            // lblOperationType
            // 
            this.lblOperationType.AutoSize = true;
            this.lblOperationType.Location = new System.Drawing.Point(213, 180);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(101, 13);
            this.lblOperationType.TabIndex = 0;
            this.lblOperationType.Text = "Type de transaction";
            // 
            // lba_testDataSet
            // 
            this.lba_testDataSet.DataSetName = "lba_testDataSet";
            this.lba_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOperationTypeBindingSource
            // 
            this.tOperationTypeBindingSource.DataMember = "T_OperationType";
            this.tOperationTypeBindingSource.DataSource = this.lba_testDataSet;
            // 
            // t_OperationTypeTableAdapter
            // 
            this.t_OperationTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addOperationPanel);
            this.Name = "AddOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBA - Ajout d\'une transaction";
            this.Load += new System.EventHandler(this.AddOperation_Load);
            this.addOperationPanel.ResumeLayout(false);
            this.addOperationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOperationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addOperationPanel;
        private System.Windows.Forms.ComboBox cmbAddOperationComment;
        private System.Windows.Forms.ComboBox cmbAddOperationType;
        private System.Windows.Forms.Label lblOperationComment;
        private System.Windows.Forms.Label lblOperationAmount;
        private System.Windows.Forms.Label lblOperationType;
        private System.Windows.Forms.TextBox txtOperationAmount;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Button btnAddOperationEmpty;
        public int personToAddOperation;
        private lba_testDataSet lba_testDataSet;
        private System.Windows.Forms.BindingSource tOperationTypeBindingSource;
        private lba_testDataSetTableAdapters.T_OperationTypeTableAdapter t_OperationTypeTableAdapter;
    }
}