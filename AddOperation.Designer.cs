
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
            this.tOperationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lba_testDataSet = new LBA.lba_testDataSet();
            this.t_OperationTypeTableAdapter = new LBA.lba_testDataSetTableAdapters.T_OperationTypeTableAdapter();
            this.btnAddOperationEmpty = new System.Windows.Forms.Button();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.txtOperationAmount = new System.Windows.Forms.TextBox();
            this.cmbAddOperationComment = new System.Windows.Forms.ComboBox();
            this.cmbAddOperationType = new System.Windows.Forms.ComboBox();
            this.lblOperationComment = new System.Windows.Forms.Label();
            this.lblOperationAmount = new System.Windows.Forms.Label();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.addOperationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOperationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addOperationPanel
            // 
            this.addOperationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.addOperationPanel.Size = new System.Drawing.Size(484, 261);
            this.addOperationPanel.TabIndex = 0;
            // 
            // tOperationTypeBindingSource
            // 
            this.tOperationTypeBindingSource.DataMember = "T_OperationType";
            this.tOperationTypeBindingSource.DataSource = this.lba_testDataSet;
            // 
            // lba_testDataSet
            // 
            this.lba_testDataSet.DataSetName = "lba_testDataSet";
            this.lba_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_OperationTypeTableAdapter
            // 
            this.t_OperationTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddOperationEmpty
            // 
            this.btnAddOperationEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOperationEmpty.Location = new System.Drawing.Point(198, 162);
            this.btnAddOperationEmpty.Name = "btnAddOperationEmpty";
            this.btnAddOperationEmpty.Size = new System.Drawing.Size(84, 23);
            this.btnAddOperationEmpty.TabIndex = 24;
            this.btnAddOperationEmpty.Text = "Vider";
            this.btnAddOperationEmpty.UseVisualStyleBackColor = true;
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOperation.Location = new System.Drawing.Point(288, 162);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(99, 23);
            this.btnAddOperation.TabIndex = 23;
            this.btnAddOperation.Text = "Ajouter transaction";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            // 
            // txtOperationAmount
            // 
            this.txtOperationAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperationAmount.Location = new System.Drawing.Point(210, 99);
            this.txtOperationAmount.Name = "txtOperationAmount";
            this.txtOperationAmount.Size = new System.Drawing.Size(147, 20);
            this.txtOperationAmount.TabIndex = 22;
            // 
            // cmbAddOperationComment
            // 
            this.cmbAddOperationComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAddOperationComment.FormattingEnabled = true;
            this.cmbAddOperationComment.Items.AddRange(new object[] {
            "Clarification",
            "Identification",
            "Recensement",
            "Suivi client"});
            this.cmbAddOperationComment.Location = new System.Drawing.Point(210, 121);
            this.cmbAddOperationComment.Name = "cmbAddOperationComment";
            this.cmbAddOperationComment.Size = new System.Drawing.Size(147, 21);
            this.cmbAddOperationComment.TabIndex = 21;
            // 
            // cmbAddOperationType
            // 
            this.cmbAddOperationType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAddOperationType.DataSource = this.tOperationTypeBindingSource;
            this.cmbAddOperationType.DisplayMember = "operationTypeName";
            this.cmbAddOperationType.FormattingEnabled = true;
            this.cmbAddOperationType.Location = new System.Drawing.Point(210, 76);
            this.cmbAddOperationType.Name = "cmbAddOperationType";
            this.cmbAddOperationType.Size = new System.Drawing.Size(147, 21);
            this.cmbAddOperationType.TabIndex = 20;
            // 
            // lblOperationComment
            // 
            this.lblOperationComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationComment.AutoSize = true;
            this.lblOperationComment.Location = new System.Drawing.Point(130, 126);
            this.lblOperationComment.Name = "lblOperationComment";
            this.lblOperationComment.Size = new System.Drawing.Size(68, 13);
            this.lblOperationComment.TabIndex = 19;
            this.lblOperationComment.Text = "Commentaire";
            // 
            // lblOperationAmount
            // 
            this.lblOperationAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationAmount.AutoSize = true;
            this.lblOperationAmount.Location = new System.Drawing.Point(152, 101);
            this.lblOperationAmount.Name = "lblOperationAmount";
            this.lblOperationAmount.Size = new System.Drawing.Size(46, 13);
            this.lblOperationAmount.TabIndex = 18;
            this.lblOperationAmount.Text = "Montant";
            // 
            // lblOperationType
            // 
            this.lblOperationType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationType.AutoSize = true;
            this.lblOperationType.Location = new System.Drawing.Point(97, 76);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(101, 13);
            this.lblOperationType.TabIndex = 17;
            this.lblOperationType.Text = "Type de transaction";
            // 
            // AddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.addOperationPanel);
            this.Name = "AddOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBA - Ajout d\'une transaction";
            this.Load += new System.EventHandler(this.AddOperation_Load);
            this.addOperationPanel.ResumeLayout(false);
            this.addOperationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOperationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addOperationPanel;
        public int personToAddOperation;
        private lba_testDataSet lba_testDataSet;
        private System.Windows.Forms.BindingSource tOperationTypeBindingSource;
        private lba_testDataSetTableAdapters.T_OperationTypeTableAdapter t_OperationTypeTableAdapter;
        public bool normalOperation;
        private System.Windows.Forms.Button btnAddOperationEmpty;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.TextBox txtOperationAmount;
        private System.Windows.Forms.ComboBox cmbAddOperationComment;
        private System.Windows.Forms.ComboBox cmbAddOperationType;
        private System.Windows.Forms.Label lblOperationComment;
        private System.Windows.Forms.Label lblOperationAmount;
        private System.Windows.Forms.Label lblOperationType;
    }
}