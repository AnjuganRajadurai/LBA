
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.operationHistoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.operationHistoryPanel.Controls.Add(this.lblOperationHistoryDate2);
            this.operationHistoryPanel.Controls.Add(this.lblOperationHistoryDate1);
            this.operationHistoryPanel.Controls.Add(this.dtpOperationHistory1);
            this.operationHistoryPanel.Controls.Add(this.dtpOperationHistory2);
            this.operationHistoryPanel.Controls.Add(this.btnOperationHistoryAdd);
            this.operationHistoryPanel.Controls.Add(this.dataGridView1);
            this.operationHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationHistoryPanel.Location = new System.Drawing.Point(0, 0);
            this.operationHistoryPanel.Name = "operationHistoryPanel";
            this.operationHistoryPanel.Size = new System.Drawing.Size(967, 561);
            this.operationHistoryPanel.TabIndex = 0;
            // 
            // lblOperationHistoryDate2
            // 
            this.lblOperationHistoryDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationHistoryDate2.AutoSize = true;
            this.lblOperationHistoryDate2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationHistoryDate2.ForeColor = System.Drawing.Color.White;
            this.lblOperationHistoryDate2.Location = new System.Drawing.Point(695, 34);
            this.lblOperationHistoryDate2.Name = "lblOperationHistoryDate2";
            this.lblOperationHistoryDate2.Size = new System.Drawing.Size(30, 15);
            this.lblOperationHistoryDate2.TabIndex = 6;
            this.lblOperationHistoryDate2.Text = "et le";
            // 
            // lblOperationHistoryDate1
            // 
            this.lblOperationHistoryDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperationHistoryDate1.AutoSize = true;
            this.lblOperationHistoryDate1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationHistoryDate1.ForeColor = System.Drawing.Color.White;
            this.lblOperationHistoryDate1.Location = new System.Drawing.Point(365, 34);
            this.lblOperationHistoryDate1.Name = "lblOperationHistoryDate1";
            this.lblOperationHistoryDate1.Size = new System.Drawing.Size(118, 15);
            this.lblOperationHistoryDate1.TabIndex = 5;
            this.lblOperationHistoryDate1.Text = "Transactions entre le";
            // 
            // dtpOperationHistory1
            // 
            this.dtpOperationHistory1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOperationHistory1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOperationHistory1.Location = new System.Drawing.Point(489, 30);
            this.dtpOperationHistory1.Name = "dtpOperationHistory1";
            this.dtpOperationHistory1.Size = new System.Drawing.Size(200, 21);
            this.dtpOperationHistory1.TabIndex = 4;
            this.dtpOperationHistory1.ValueChanged += new System.EventHandler(this.dtpOperationHistory1_ValueChanged);
            // 
            // dtpOperationHistory2
            // 
            this.dtpOperationHistory2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOperationHistory2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOperationHistory2.Location = new System.Drawing.Point(728, 30);
            this.dtpOperationHistory2.Name = "dtpOperationHistory2";
            this.dtpOperationHistory2.Size = new System.Drawing.Size(200, 21);
            this.dtpOperationHistory2.TabIndex = 3;
            this.dtpOperationHistory2.ValueChanged += new System.EventHandler(this.dtpOperationHistory2_ValueChanged);
            // 
            // btnOperationHistoryAdd
            // 
            this.btnOperationHistoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOperationHistoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.btnOperationHistoryAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOperationHistoryAdd.FlatAppearance.BorderSize = 0;
            this.btnOperationHistoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperationHistoryAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperationHistoryAdd.ForeColor = System.Drawing.Color.White;
            this.btnOperationHistoryAdd.Location = new System.Drawing.Point(810, 521);
            this.btnOperationHistoryAdd.MaximumSize = new System.Drawing.Size(145, 26);
            this.btnOperationHistoryAdd.Name = "btnOperationHistoryAdd";
            this.btnOperationHistoryAdd.Size = new System.Drawing.Size(145, 26);
            this.btnOperationHistoryAdd.TabIndex = 1;
            this.btnOperationHistoryAdd.Text = "Ajouter une transaction";
            this.btnOperationHistoryAdd.UseVisualStyleBackColor = false;
            this.btnOperationHistoryAdd.Click += new System.EventHandler(this.btnOperationHistoryAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(943, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // OperationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 561);
            this.Controls.Add(this.operationHistoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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