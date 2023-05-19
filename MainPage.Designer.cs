
namespace LBA
{
    partial class MainPage
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
            this.navBar = new System.Windows.Forms.Panel();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.Panel();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMainPageEmpty = new System.Windows.Forms.Button();
            this.navBar.SuspendLayout();
            this.searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.AutoSize = true;
            this.navBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.navBar.Controls.Add(this.btnAddOperation);
            this.navBar.Controls.Add(this.btnAddPerson);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.MinimumSize = new System.Drawing.Size(100, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(131, 450);
            this.navBar.TabIndex = 0;
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.AutoSize = true;
            this.btnAddOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOperation.Location = new System.Drawing.Point(3, 45);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(125, 27);
            this.btnAddOperation.TabIndex = 1;
            this.btnAddOperation.Text = "Nouveau recensement";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AutoSize = true;
            this.btnAddPerson.Location = new System.Drawing.Point(3, 12);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(125, 27);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Nouveau client";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.searchBar.Controls.Add(this.btnMainPageEmpty);
            this.searchBar.Controls.Add(this.txtSearchClient);
            this.searchBar.Controls.Add(this.lblSearchClient);
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar.Location = new System.Drawing.Point(131, 0);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(669, 57);
            this.searchBar.TabIndex = 1;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(249, 23);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(172, 20);
            this.txtSearchClient.TabIndex = 1;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Location = new System.Drawing.Point(126, 26);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(117, 13);
            this.lblSearchClient.TabIndex = 0;
            this.lblSearchClient.Text = "Recherche d\'un client :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(131, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 393);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnMainPageEmpty
            // 
            this.btnMainPageEmpty.Location = new System.Drawing.Point(478, 22);
            this.btnMainPageEmpty.Name = "btnMainPageEmpty";
            this.btnMainPageEmpty.Size = new System.Drawing.Size(142, 23);
            this.btnMainPageEmpty.TabIndex = 2;
            this.btnMainPageEmpty.Text = "Vider";
            this.btnMainPageEmpty.UseVisualStyleBackColor = true;
            this.btnMainPageEmpty.Click += new System.EventHandler(this.btnMainPageEmpty_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.navBar);
            this.Name = "MainPage";
            this.Text = "LBA - Page d\'accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.searchBar.ResumeLayout(false);
            this.searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Panel searchBar;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMainPageEmpty;
    }
}