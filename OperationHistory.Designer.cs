
namespace LBA
{
    partial class OperationHistory
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
            this.operationHistoryPanel = new System.Windows.Forms.Panel();
            this.lblOperationHistoryDate2 = new System.Windows.Forms.Label();
            this.lblOperationHistoryDate1 = new System.Windows.Forms.Label();
            this.dtpOperationHistory1 = new System.Windows.Forms.DateTimePicker();
            this.dtpOperationHistory2 = new System.Windows.Forms.DateTimePicker();
            this.btnOperationHistoryAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationHistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // operationHistoryPanel
            // 
            this.operationHistoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.operationHistoryPanel.Controls.Add(this.lblOperationHistoryDate2);
            this.operationHistoryPanel.Controls.Add(this.lblOperationHistoryDate1);
            this.operationHistoryPanel.Controls.Add(this.dtpOperationHistory1);
            this.operationHistoryPanel.Controls.Add(this.dtpOperationHistory2);
            this.operationHistoryPanel.Controls.Add(this.btnOperationHistoryAdd);
            this.operationHistoryPanel.Controls.Add(this.dataGridView1);
            this.operationHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationHistoryPanel.Location = new System.Drawing.Point(0, 0);
            this.operationHistoryPanel.Name = "operationHistoryPanel";
            this.operationHistoryPanel.Size = new System.Drawing.Size(800, 450);
            this.operationHistoryPanel.TabIndex = 0;
            // 
            // lblOperationHistoryDate2
            // 
            this.lblOperationHistoryDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationHistoryDate2.AutoSize = true;
            this.lblOperationHistoryDate2.Location = new System.Drawing.Point(528, 36);
            this.lblOperationHistoryDate2.Name = "lblOperationHistoryDate2";
            this.lblOperationHistoryDate2.Size = new System.Drawing.Size(27, 13);
            this.lblOperationHistoryDate2.TabIndex = 6;
            this.lblOperationHistoryDate2.Text = "et le";
            // 
            // lblOperationHistoryDate1
            // 
            this.lblOperationHistoryDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationHistoryDate1.AutoSize = true;
            this.lblOperationHistoryDate1.Location = new System.Drawing.Point(210, 36);
            this.lblOperationHistoryDate1.Name = "lblOperationHistoryDate1";
            this.lblOperationHistoryDate1.Size = new System.Drawing.Size(106, 13);
            this.lblOperationHistoryDate1.TabIndex = 5;
            this.lblOperationHistoryDate1.Text = "Transactions entre le";
            // 
            // dtpOperationHistory1
            // 
            this.dtpOperationHistory1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOperationHistory1.Location = new System.Drawing.Point(322, 30);
            this.dtpOperationHistory1.Name = "dtpOperationHistory1";
            this.dtpOperationHistory1.Size = new System.Drawing.Size(200, 20);
            this.dtpOperationHistory1.TabIndex = 4;
            this.dtpOperationHistory1.ValueChanged += new System.EventHandler(this.dtpOperationHistory1_ValueChanged);
            // 
            // dtpOperationHistory2
            // 
            this.dtpOperationHistory2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOperationHistory2.Location = new System.Drawing.Point(561, 30);
            this.dtpOperationHistory2.Name = "dtpOperationHistory2";
            this.dtpOperationHistory2.Size = new System.Drawing.Size(200, 20);
            this.dtpOperationHistory2.TabIndex = 3;
            this.dtpOperationHistory2.ValueChanged += new System.EventHandler(this.dtpOperationHistory2_ValueChanged);
            // 
            // btnOperationHistoryAdd
            // 
            this.btnOperationHistoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOperationHistoryAdd.Location = new System.Drawing.Point(651, 410);
            this.btnOperationHistoryAdd.MaximumSize = new System.Drawing.Size(136, 26);
            this.btnOperationHistoryAdd.Name = "btnOperationHistoryAdd";
            this.btnOperationHistoryAdd.Size = new System.Drawing.Size(136, 26);
            this.btnOperationHistoryAdd.TabIndex = 1;
            this.btnOperationHistoryAdd.Text = "Ajouter une transaction";
            this.btnOperationHistoryAdd.UseVisualStyleBackColor = true;
            this.btnOperationHistoryAdd.Click += new System.EventHandler(this.btnOperationHistoryAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // OperationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operationHistoryPanel);
            this.Name = "OperationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBA - Historique des transactions";
            this.Load += new System.EventHandler(this.OperationHistory_Load);
            this.operationHistoryPanel.ResumeLayout(false);
            this.operationHistoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel operationHistoryPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOperationHistoryDate2;
        private System.Windows.Forms.Label lblOperationHistoryDate1;
        private System.Windows.Forms.DateTimePicker dtpOperationHistory1;
        private System.Windows.Forms.DateTimePicker dtpOperationHistory2;
        public System.Windows.Forms.Button btnOperationHistoryAdd;
        public int personIdToViewOperation;
    }
}