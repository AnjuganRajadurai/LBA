
namespace LBA
{
    partial class AddPerson
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
            this.addPersonPanel = new System.Windows.Forms.Panel();
            this.btnAddPersonEmpty = new System.Windows.Forms.Button();
            this.btnAddPersonSave = new System.Windows.Forms.Button();
            this.rtbAddPersonComment = new System.Windows.Forms.RichTextBox();
            this.cmbAddPersonDocType = new System.Windows.Forms.ComboBox();
            this.txtAddPersonDocNumber = new System.Windows.Forms.TextBox();
            this.dtpAddPersonIdValidity = new System.Windows.Forms.DateTimePicker();
            this.txtAddPersonJob = new System.Windows.Forms.TextBox();
            this.dtpAddPersonBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbAddPersonNationality = new System.Windows.Forms.ComboBox();
            this.tNationalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lba_testDataSet = new LBA.lba_testDataSet();
            this.txtAddPersonCountry = new System.Windows.Forms.TextBox();
            this.txtAddPersonCity = new System.Windows.Forms.TextBox();
            this.txtAddPersonRoad = new System.Windows.Forms.TextBox();
            this.txtAddPersonOtherName = new System.Windows.Forms.TextBox();
            this.txtAddPersonFirstName = new System.Windows.Forms.TextBox();
            this.txtAddPersonLastName = new System.Windows.Forms.TextBox();
            this.lblAddPersonOtherName = new System.Windows.Forms.Label();
            this.lbAddPersonComment = new System.Windows.Forms.Label();
            this.lblAddPersonJob = new System.Windows.Forms.Label();
            this.lblAddPersonDocNumber = new System.Windows.Forms.Label();
            this.lblAddPersonIdValidity = new System.Windows.Forms.Label();
            this.lblAddPersonDocumentType = new System.Windows.Forms.Label();
            this.lblAddPersonBirthday = new System.Windows.Forms.Label();
            this.lblAddPersonCountry = new System.Windows.Forms.Label();
            this.lblAddPersonNationality = new System.Windows.Forms.Label();
            this.lblAddPersonCity = new System.Windows.Forms.Label();
            this.lblAddPersonRoad = new System.Windows.Forms.Label();
            this.lblAddPersonFirstName = new System.Windows.Forms.Label();
            this.lblAddPersonLastName = new System.Windows.Forms.Label();
            this.lbatestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_NationalityTableAdapter = new LBA.lba_testDataSetTableAdapters.T_NationalityTableAdapter();
            this.addPersonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNationalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbatestDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addPersonPanel
            // 
            this.addPersonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.addPersonPanel.Controls.Add(this.btnAddPersonEmpty);
            this.addPersonPanel.Controls.Add(this.btnAddPersonSave);
            this.addPersonPanel.Controls.Add(this.rtbAddPersonComment);
            this.addPersonPanel.Controls.Add(this.cmbAddPersonDocType);
            this.addPersonPanel.Controls.Add(this.txtAddPersonDocNumber);
            this.addPersonPanel.Controls.Add(this.dtpAddPersonIdValidity);
            this.addPersonPanel.Controls.Add(this.txtAddPersonJob);
            this.addPersonPanel.Controls.Add(this.dtpAddPersonBirthday);
            this.addPersonPanel.Controls.Add(this.cmbAddPersonNationality);
            this.addPersonPanel.Controls.Add(this.txtAddPersonCountry);
            this.addPersonPanel.Controls.Add(this.txtAddPersonCity);
            this.addPersonPanel.Controls.Add(this.txtAddPersonRoad);
            this.addPersonPanel.Controls.Add(this.txtAddPersonOtherName);
            this.addPersonPanel.Controls.Add(this.txtAddPersonFirstName);
            this.addPersonPanel.Controls.Add(this.txtAddPersonLastName);
            this.addPersonPanel.Controls.Add(this.lblAddPersonOtherName);
            this.addPersonPanel.Controls.Add(this.lbAddPersonComment);
            this.addPersonPanel.Controls.Add(this.lblAddPersonJob);
            this.addPersonPanel.Controls.Add(this.lblAddPersonDocNumber);
            this.addPersonPanel.Controls.Add(this.lblAddPersonIdValidity);
            this.addPersonPanel.Controls.Add(this.lblAddPersonDocumentType);
            this.addPersonPanel.Controls.Add(this.lblAddPersonBirthday);
            this.addPersonPanel.Controls.Add(this.lblAddPersonCountry);
            this.addPersonPanel.Controls.Add(this.lblAddPersonNationality);
            this.addPersonPanel.Controls.Add(this.lblAddPersonCity);
            this.addPersonPanel.Controls.Add(this.lblAddPersonRoad);
            this.addPersonPanel.Controls.Add(this.lblAddPersonFirstName);
            this.addPersonPanel.Controls.Add(this.lblAddPersonLastName);
            this.addPersonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPersonPanel.Location = new System.Drawing.Point(0, 0);
            this.addPersonPanel.Name = "addPersonPanel";
            this.addPersonPanel.Size = new System.Drawing.Size(800, 450);
            this.addPersonPanel.TabIndex = 0;
            // 
            // btnAddPersonEmpty
            // 
            this.btnAddPersonEmpty.Location = new System.Drawing.Point(461, 405);
            this.btnAddPersonEmpty.Name = "btnAddPersonEmpty";
            this.btnAddPersonEmpty.Size = new System.Drawing.Size(123, 20);
            this.btnAddPersonEmpty.TabIndex = 28;
            this.btnAddPersonEmpty.Text = "Vider";
            this.btnAddPersonEmpty.UseVisualStyleBackColor = true;
            this.btnAddPersonEmpty.Click += new System.EventHandler(this.btnAddPersonEmpty_Click);
            // 
            // btnAddPersonSave
            // 
            this.btnAddPersonSave.Location = new System.Drawing.Point(626, 405);
            this.btnAddPersonSave.Name = "btnAddPersonSave";
            this.btnAddPersonSave.Size = new System.Drawing.Size(161, 21);
            this.btnAddPersonSave.TabIndex = 27;
            this.btnAddPersonSave.Text = "Sauvegarder";
            this.btnAddPersonSave.UseVisualStyleBackColor = true;
            this.btnAddPersonSave.Click += new System.EventHandler(this.btnAddPersonSave_Click);
            // 
            // rtbAddPersonComment
            // 
            this.rtbAddPersonComment.Location = new System.Drawing.Point(16, 267);
            this.rtbAddPersonComment.Name = "rtbAddPersonComment";
            this.rtbAddPersonComment.Size = new System.Drawing.Size(772, 119);
            this.rtbAddPersonComment.TabIndex = 26;
            this.rtbAddPersonComment.Text = "";
            // 
            // cmbAddPersonDocType
            // 
            this.cmbAddPersonDocType.FormattingEnabled = true;
            this.cmbAddPersonDocType.Items.AddRange(new object[] {
            "Carte d\'identité",
            "Carte d\'identité Suisse",
            "Passeport",
            "Permis de conduire",
            "Permis de conduire Suisse",
            "Permis de légimation Suisse",
            "Titre de séjour Suisse"});
            this.cmbAddPersonDocType.Location = new System.Drawing.Point(453, 73);
            this.cmbAddPersonDocType.Name = "cmbAddPersonDocType";
            this.cmbAddPersonDocType.Size = new System.Drawing.Size(150, 21);
            this.cmbAddPersonDocType.TabIndex = 25;
            // 
            // txtAddPersonDocNumber
            // 
            this.txtAddPersonDocNumber.Location = new System.Drawing.Point(453, 129);
            this.txtAddPersonDocNumber.Name = "txtAddPersonDocNumber";
            this.txtAddPersonDocNumber.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonDocNumber.TabIndex = 24;
            // 
            // dtpAddPersonIdValidity
            // 
            this.dtpAddPersonIdValidity.Location = new System.Drawing.Point(453, 103);
            this.dtpAddPersonIdValidity.Name = "dtpAddPersonIdValidity";
            this.dtpAddPersonIdValidity.Size = new System.Drawing.Size(185, 20);
            this.dtpAddPersonIdValidity.TabIndex = 23;
            // 
            // txtAddPersonJob
            // 
            this.txtAddPersonJob.Location = new System.Drawing.Point(453, 48);
            this.txtAddPersonJob.Name = "txtAddPersonJob";
            this.txtAddPersonJob.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonJob.TabIndex = 21;
            // 
            // dtpAddPersonBirthday
            // 
            this.dtpAddPersonBirthday.Location = new System.Drawing.Point(453, 22);
            this.dtpAddPersonBirthday.Name = "dtpAddPersonBirthday";
            this.dtpAddPersonBirthday.Size = new System.Drawing.Size(185, 20);
            this.dtpAddPersonBirthday.TabIndex = 20;
            // 
            // cmbAddPersonNationality
            // 
            this.cmbAddPersonNationality.DataSource = this.tNationalityBindingSource;
            this.cmbAddPersonNationality.DisplayMember = "countryName";
            this.cmbAddPersonNationality.FormattingEnabled = true;
            this.cmbAddPersonNationality.Location = new System.Drawing.Point(155, 181);
            this.cmbAddPersonNationality.Name = "cmbAddPersonNationality";
            this.cmbAddPersonNationality.Size = new System.Drawing.Size(150, 21);
            this.cmbAddPersonNationality.TabIndex = 19;
            // 
            // tNationalityBindingSource
            // 
            this.tNationalityBindingSource.DataMember = "T_Nationality";
            this.tNationalityBindingSource.DataSource = this.lba_testDataSet;
            // 
            // lba_testDataSet
            // 
            this.lba_testDataSet.DataSetName = "lba_testDataSet";
            this.lba_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAddPersonCountry
            // 
            this.txtAddPersonCountry.Location = new System.Drawing.Point(155, 155);
            this.txtAddPersonCountry.Name = "txtAddPersonCountry";
            this.txtAddPersonCountry.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonCountry.TabIndex = 18;
            // 
            // txtAddPersonCity
            // 
            this.txtAddPersonCity.Location = new System.Drawing.Point(155, 129);
            this.txtAddPersonCity.Name = "txtAddPersonCity";
            this.txtAddPersonCity.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonCity.TabIndex = 17;
            // 
            // txtAddPersonRoad
            // 
            this.txtAddPersonRoad.Location = new System.Drawing.Point(155, 103);
            this.txtAddPersonRoad.Name = "txtAddPersonRoad";
            this.txtAddPersonRoad.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonRoad.TabIndex = 16;
            // 
            // txtAddPersonOtherName
            // 
            this.txtAddPersonOtherName.Location = new System.Drawing.Point(155, 74);
            this.txtAddPersonOtherName.Name = "txtAddPersonOtherName";
            this.txtAddPersonOtherName.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonOtherName.TabIndex = 15;
            // 
            // txtAddPersonFirstName
            // 
            this.txtAddPersonFirstName.Location = new System.Drawing.Point(155, 48);
            this.txtAddPersonFirstName.Name = "txtAddPersonFirstName";
            this.txtAddPersonFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonFirstName.TabIndex = 14;
            // 
            // txtAddPersonLastName
            // 
            this.txtAddPersonLastName.Location = new System.Drawing.Point(155, 22);
            this.txtAddPersonLastName.Name = "txtAddPersonLastName";
            this.txtAddPersonLastName.Size = new System.Drawing.Size(150, 20);
            this.txtAddPersonLastName.TabIndex = 13;
            // 
            // lblAddPersonOtherName
            // 
            this.lblAddPersonOtherName.AutoSize = true;
            this.lblAddPersonOtherName.Location = new System.Drawing.Point(13, 77);
            this.lblAddPersonOtherName.Name = "lblAddPersonOtherName";
            this.lblAddPersonOtherName.Size = new System.Drawing.Size(116, 13);
            this.lblAddPersonOtherName.TabIndex = 12;
            this.lblAddPersonOtherName.Text = "Autre(s) nom et prénom";
            // 
            // lbAddPersonComment
            // 
            this.lbAddPersonComment.AutoSize = true;
            this.lbAddPersonComment.Location = new System.Drawing.Point(13, 251);
            this.lbAddPersonComment.Name = "lbAddPersonComment";
            this.lbAddPersonComment.Size = new System.Drawing.Size(195, 13);
            this.lbAddPersonComment.TabIndex = 11;
            this.lbAddPersonComment.Text = "Remarques et raison de l\'enregistrement";
            // 
            // lblAddPersonJob
            // 
            this.lblAddPersonJob.AutoSize = true;
            this.lblAddPersonJob.Location = new System.Drawing.Point(391, 51);
            this.lblAddPersonJob.Name = "lblAddPersonJob";
            this.lblAddPersonJob.Size = new System.Drawing.Size(56, 13);
            this.lblAddPersonJob.TabIndex = 10;
            this.lblAddPersonJob.Text = "Profession";
            // 
            // lblAddPersonDocNumber
            // 
            this.lblAddPersonDocNumber.AutoSize = true;
            this.lblAddPersonDocNumber.Location = new System.Drawing.Point(338, 129);
            this.lblAddPersonDocNumber.Name = "lblAddPersonDocNumber";
            this.lblAddPersonDocNumber.Size = new System.Drawing.Size(109, 13);
            this.lblAddPersonDocNumber.TabIndex = 9;
            this.lblAddPersonDocNumber.Text = "Numéro de document";
            // 
            // lblAddPersonIdValidity
            // 
            this.lblAddPersonIdValidity.AutoSize = true;
            this.lblAddPersonIdValidity.Location = new System.Drawing.Point(361, 103);
            this.lblAddPersonIdValidity.Name = "lblAddPersonIdValidity";
            this.lblAddPersonIdValidity.Size = new System.Drawing.Size(86, 13);
            this.lblAddPersonIdValidity.TabIndex = 8;
            this.lblAddPersonIdValidity.Text = "Date d\'expiration";
            // 
            // lblAddPersonDocumentType
            // 
            this.lblAddPersonDocumentType.AutoSize = true;
            this.lblAddPersonDocumentType.Location = new System.Drawing.Point(351, 77);
            this.lblAddPersonDocumentType.Name = "lblAddPersonDocumentType";
            this.lblAddPersonDocumentType.Size = new System.Drawing.Size(96, 13);
            this.lblAddPersonDocumentType.TabIndex = 7;
            this.lblAddPersonDocumentType.Text = "Type de document";
            // 
            // lblAddPersonBirthday
            // 
            this.lblAddPersonBirthday.AutoSize = true;
            this.lblAddPersonBirthday.Location = new System.Drawing.Point(351, 25);
            this.lblAddPersonBirthday.Name = "lblAddPersonBirthday";
            this.lblAddPersonBirthday.Size = new System.Drawing.Size(96, 13);
            this.lblAddPersonBirthday.TabIndex = 6;
            this.lblAddPersonBirthday.Text = "Date de naissance";
            // 
            // lblAddPersonCountry
            // 
            this.lblAddPersonCountry.AutoSize = true;
            this.lblAddPersonCountry.Location = new System.Drawing.Point(35, 155);
            this.lblAddPersonCountry.Name = "lblAddPersonCountry";
            this.lblAddPersonCountry.Size = new System.Drawing.Size(94, 13);
            this.lblAddPersonCountry.TabIndex = 5;
            this.lblAddPersonCountry.Text = "Pays de résidence";
            // 
            // lblAddPersonNationality
            // 
            this.lblAddPersonNationality.AutoSize = true;
            this.lblAddPersonNationality.Location = new System.Drawing.Point(72, 181);
            this.lblAddPersonNationality.Name = "lblAddPersonNationality";
            this.lblAddPersonNationality.Size = new System.Drawing.Size(57, 13);
            this.lblAddPersonNationality.TabIndex = 4;
            this.lblAddPersonNationality.Text = "Nationalité";
            // 
            // lblAddPersonCity
            // 
            this.lblAddPersonCity.AutoSize = true;
            this.lblAddPersonCity.Location = new System.Drawing.Point(103, 129);
            this.lblAddPersonCity.Name = "lblAddPersonCity";
            this.lblAddPersonCity.Size = new System.Drawing.Size(26, 13);
            this.lblAddPersonCity.TabIndex = 3;
            this.lblAddPersonCity.Text = "Ville";
            // 
            // lblAddPersonRoad
            // 
            this.lblAddPersonRoad.AutoSize = true;
            this.lblAddPersonRoad.Location = new System.Drawing.Point(77, 103);
            this.lblAddPersonRoad.Name = "lblAddPersonRoad";
            this.lblAddPersonRoad.Size = new System.Drawing.Size(52, 13);
            this.lblAddPersonRoad.TabIndex = 2;
            this.lblAddPersonRoad.Text = "Rue et n°";
            // 
            // lblAddPersonFirstName
            // 
            this.lblAddPersonFirstName.AutoSize = true;
            this.lblAddPersonFirstName.Location = new System.Drawing.Point(86, 51);
            this.lblAddPersonFirstName.Name = "lblAddPersonFirstName";
            this.lblAddPersonFirstName.Size = new System.Drawing.Size(43, 13);
            this.lblAddPersonFirstName.TabIndex = 1;
            this.lblAddPersonFirstName.Text = "Prénom";
            // 
            // lblAddPersonLastName
            // 
            this.lblAddPersonLastName.AutoSize = true;
            this.lblAddPersonLastName.Location = new System.Drawing.Point(100, 25);
            this.lblAddPersonLastName.Name = "lblAddPersonLastName";
            this.lblAddPersonLastName.Size = new System.Drawing.Size(29, 13);
            this.lblAddPersonLastName.TabIndex = 0;
            this.lblAddPersonLastName.Text = "Nom";
            // 
            // lbatestDataSetBindingSource
            // 
            this.lbatestDataSetBindingSource.DataSource = this.lba_testDataSet;
            this.lbatestDataSetBindingSource.Position = 0;
            // 
            // t_NationalityTableAdapter
            // 
            this.t_NationalityTableAdapter.ClearBeforeFill = true;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPersonPanel);
            this.Name = "AddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBA - Ajouter un client";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.addPersonPanel.ResumeLayout(false);
            this.addPersonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNationalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbatestDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPersonPanel;
        private System.Windows.Forms.Label lblAddPersonIdValidity;
        private System.Windows.Forms.Label lblAddPersonDocumentType;
        private System.Windows.Forms.Label lblAddPersonBirthday;
        private System.Windows.Forms.Label lblAddPersonCountry;
        private System.Windows.Forms.Label lblAddPersonNationality;
        private System.Windows.Forms.Label lblAddPersonCity;
        private System.Windows.Forms.Label lblAddPersonRoad;
        private System.Windows.Forms.Label lblAddPersonFirstName;
        private System.Windows.Forms.Label lblAddPersonLastName;
        private System.Windows.Forms.Label lblAddPersonDocNumber;
        private System.Windows.Forms.ComboBox cmbAddPersonDocType;
        private System.Windows.Forms.TextBox txtAddPersonDocNumber;
        private System.Windows.Forms.DateTimePicker dtpAddPersonIdValidity;
        private System.Windows.Forms.TextBox txtAddPersonJob;
        private System.Windows.Forms.DateTimePicker dtpAddPersonBirthday;
        private System.Windows.Forms.ComboBox cmbAddPersonNationality;
        private System.Windows.Forms.TextBox txtAddPersonCountry;
        private System.Windows.Forms.TextBox txtAddPersonCity;
        private System.Windows.Forms.TextBox txtAddPersonRoad;
        private System.Windows.Forms.TextBox txtAddPersonOtherName;
        private System.Windows.Forms.TextBox txtAddPersonFirstName;
        private System.Windows.Forms.TextBox txtAddPersonLastName;
        private System.Windows.Forms.Label lblAddPersonOtherName;
        private System.Windows.Forms.Label lbAddPersonComment;
        private System.Windows.Forms.Label lblAddPersonJob;
        private System.Windows.Forms.Button btnAddPersonSave;
        private System.Windows.Forms.RichTextBox rtbAddPersonComment;
        private System.Windows.Forms.Button btnAddPersonEmpty;
        private System.Windows.Forms.BindingSource lbatestDataSetBindingSource;
        private lba_testDataSet lba_testDataSet;
        private System.Windows.Forms.BindingSource tNationalityBindingSource;
        private lba_testDataSetTableAdapters.T_NationalityTableAdapter t_NationalityTableAdapter;
    }
}