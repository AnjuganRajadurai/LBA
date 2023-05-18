
namespace LBA
{
    partial class PersonProfil
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
            this.t_NationalityTableAdapter = new LBA.lba_testDataSetTableAdapters.T_NationalityTableAdapter();
            this.lbatestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lba_testDataSet = new LBA.lba_testDataSet();
            this.btnPersonProfilEmpty = new System.Windows.Forms.Button();
            this.btnPersonProfilSave = new System.Windows.Forms.Button();
            this.rtbPersonProfilComment = new System.Windows.Forms.RichTextBox();
            this.cmbPersonProfilDocType = new System.Windows.Forms.ComboBox();
            this.txtPersonProfilDocNumber = new System.Windows.Forms.TextBox();
            this.dtpPersonProfilIdValidity = new System.Windows.Forms.DateTimePicker();
            this.txtPersonProfilJob = new System.Windows.Forms.TextBox();
            this.dtpPersonProfilBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbPersonProfilNationality = new System.Windows.Forms.ComboBox();
            this.tNationalityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tNationalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPersonProfilCountry = new System.Windows.Forms.TextBox();
            this.txtPersonProfilCity = new System.Windows.Forms.TextBox();
            this.txtPersonProfilRoad = new System.Windows.Forms.TextBox();
            this.txtPersonProfilOtherName = new System.Windows.Forms.TextBox();
            this.txtPersonProfilFirstName = new System.Windows.Forms.TextBox();
            this.txtPersonProfilLastName = new System.Windows.Forms.TextBox();
            this.lblPersonProfilOtherName = new System.Windows.Forms.Label();
            this.lbPersonProfilComment = new System.Windows.Forms.Label();
            this.lblPersonProfilJob = new System.Windows.Forms.Label();
            this.lblPersonProfilDocNumber = new System.Windows.Forms.Label();
            this.lblPersonProfilIdValidity = new System.Windows.Forms.Label();
            this.lblPersonProfilDocumentType = new System.Windows.Forms.Label();
            this.lblPersonProfilBirthday = new System.Windows.Forms.Label();
            this.lblPersonProfilCountry = new System.Windows.Forms.Label();
            this.lblPersonProfilNationality = new System.Windows.Forms.Label();
            this.lblPersonProfilCity = new System.Windows.Forms.Label();
            this.lblPersonProfilRoad = new System.Windows.Forms.Label();
            this.lblPersonProfilFirstName = new System.Windows.Forms.Label();
            this.lblPersonProfilLastName = new System.Windows.Forms.Label();
            this.personProfilPanel = new System.Windows.Forms.Panel();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lbatestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNationalityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNationalityBindingSource)).BeginInit();
            this.personProfilPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_NationalityTableAdapter
            // 
            this.t_NationalityTableAdapter.ClearBeforeFill = true;
            // 
            // lbatestDataSetBindingSource
            // 
            this.lbatestDataSetBindingSource.DataSource = this.lba_testDataSet;
            this.lbatestDataSetBindingSource.Position = 0;
            // 
            // lba_testDataSet
            // 
            this.lba_testDataSet.DataSetName = "lba_testDataSet";
            this.lba_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPersonProfilEmpty
            // 
            this.btnPersonProfilEmpty.Location = new System.Drawing.Point(461, 405);
            this.btnPersonProfilEmpty.Name = "btnPersonProfilEmpty";
            this.btnPersonProfilEmpty.Size = new System.Drawing.Size(123, 20);
            this.btnPersonProfilEmpty.TabIndex = 28;
            this.btnPersonProfilEmpty.Text = "Vider";
            this.btnPersonProfilEmpty.UseVisualStyleBackColor = true;
            this.btnPersonProfilEmpty.Click += new System.EventHandler(this.btnPersonProfilEmpty_Click);
            // 
            // btnPersonProfilSave
            // 
            this.btnPersonProfilSave.Location = new System.Drawing.Point(626, 405);
            this.btnPersonProfilSave.Name = "btnPersonProfilSave";
            this.btnPersonProfilSave.Size = new System.Drawing.Size(161, 21);
            this.btnPersonProfilSave.TabIndex = 27;
            this.btnPersonProfilSave.Text = "Sauvegarder";
            this.btnPersonProfilSave.UseVisualStyleBackColor = true;
            this.btnPersonProfilSave.Click += new System.EventHandler(this.btnPersonProfilSave_Click);
            // 
            // rtbPersonProfilComment
            // 
            this.rtbPersonProfilComment.Location = new System.Drawing.Point(16, 267);
            this.rtbPersonProfilComment.Name = "rtbPersonProfilComment";
            this.rtbPersonProfilComment.Size = new System.Drawing.Size(772, 119);
            this.rtbPersonProfilComment.TabIndex = 26;
            this.rtbPersonProfilComment.Text = "";
            // 
            // cmbPersonProfilDocType
            // 
            this.cmbPersonProfilDocType.FormattingEnabled = true;
            this.cmbPersonProfilDocType.Items.AddRange(new object[] {
            "Carte d\'identité",
            "Carte d\'identité Suisse",
            "Passeport",
            "Permis de conduire",
            "Permis de conduire Suisse",
            "Permis de légimation Suisse",
            "Titre de séjour Suisse"});
            this.cmbPersonProfilDocType.Location = new System.Drawing.Point(453, 73);
            this.cmbPersonProfilDocType.Name = "cmbPersonProfilDocType";
            this.cmbPersonProfilDocType.Size = new System.Drawing.Size(150, 21);
            this.cmbPersonProfilDocType.TabIndex = 25;
            // 
            // txtPersonProfilDocNumber
            // 
            this.txtPersonProfilDocNumber.Location = new System.Drawing.Point(453, 129);
            this.txtPersonProfilDocNumber.Name = "txtPersonProfilDocNumber";
            this.txtPersonProfilDocNumber.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilDocNumber.TabIndex = 24;
            // 
            // dtpPersonProfilIdValidity
            // 
            this.dtpPersonProfilIdValidity.Location = new System.Drawing.Point(453, 103);
            this.dtpPersonProfilIdValidity.Name = "dtpPersonProfilIdValidity";
            this.dtpPersonProfilIdValidity.Size = new System.Drawing.Size(185, 20);
            this.dtpPersonProfilIdValidity.TabIndex = 23;
            // 
            // txtPersonProfilJob
            // 
            this.txtPersonProfilJob.Location = new System.Drawing.Point(453, 48);
            this.txtPersonProfilJob.Name = "txtPersonProfilJob";
            this.txtPersonProfilJob.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilJob.TabIndex = 21;
            // 
            // dtpPersonProfilBirthday
            // 
            this.dtpPersonProfilBirthday.Location = new System.Drawing.Point(453, 22);
            this.dtpPersonProfilBirthday.Name = "dtpPersonProfilBirthday";
            this.dtpPersonProfilBirthday.Size = new System.Drawing.Size(185, 20);
            this.dtpPersonProfilBirthday.TabIndex = 20;
            // 
            // cmbPersonProfilNationality
            // 
            this.cmbPersonProfilNationality.DataSource = this.tNationalityBindingSource1;
            this.cmbPersonProfilNationality.DisplayMember = "countryName";
            this.cmbPersonProfilNationality.FormattingEnabled = true;
            this.cmbPersonProfilNationality.Location = new System.Drawing.Point(155, 181);
            this.cmbPersonProfilNationality.Name = "cmbPersonProfilNationality";
            this.cmbPersonProfilNationality.Size = new System.Drawing.Size(150, 21);
            this.cmbPersonProfilNationality.TabIndex = 19;
            // 
            // tNationalityBindingSource1
            // 
            this.tNationalityBindingSource1.DataMember = "T_Nationality";
            this.tNationalityBindingSource1.DataSource = this.lbatestDataSetBindingSource;
            // 
            // tNationalityBindingSource
            // 
            this.tNationalityBindingSource.DataMember = "T_Nationality";
            this.tNationalityBindingSource.DataSource = this.lba_testDataSet;
            // 
            // txtPersonProfilCountry
            // 
            this.txtPersonProfilCountry.Location = new System.Drawing.Point(155, 155);
            this.txtPersonProfilCountry.Name = "txtPersonProfilCountry";
            this.txtPersonProfilCountry.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilCountry.TabIndex = 18;
            // 
            // txtPersonProfilCity
            // 
            this.txtPersonProfilCity.Location = new System.Drawing.Point(155, 129);
            this.txtPersonProfilCity.Name = "txtPersonProfilCity";
            this.txtPersonProfilCity.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilCity.TabIndex = 17;
            // 
            // txtPersonProfilRoad
            // 
            this.txtPersonProfilRoad.Location = new System.Drawing.Point(155, 103);
            this.txtPersonProfilRoad.Name = "txtPersonProfilRoad";
            this.txtPersonProfilRoad.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilRoad.TabIndex = 16;
            // 
            // txtPersonProfilOtherName
            // 
            this.txtPersonProfilOtherName.Location = new System.Drawing.Point(155, 74);
            this.txtPersonProfilOtherName.Name = "txtPersonProfilOtherName";
            this.txtPersonProfilOtherName.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilOtherName.TabIndex = 15;
            // 
            // txtPersonProfilFirstName
            // 
            this.txtPersonProfilFirstName.Location = new System.Drawing.Point(155, 48);
            this.txtPersonProfilFirstName.Name = "txtPersonProfilFirstName";
            this.txtPersonProfilFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilFirstName.TabIndex = 14;
            // 
            // txtPersonProfilLastName
            // 
            this.txtPersonProfilLastName.Location = new System.Drawing.Point(155, 22);
            this.txtPersonProfilLastName.Name = "txtPersonProfilLastName";
            this.txtPersonProfilLastName.Size = new System.Drawing.Size(150, 20);
            this.txtPersonProfilLastName.TabIndex = 13;
            // 
            // lblPersonProfilOtherName
            // 
            this.lblPersonProfilOtherName.AutoSize = true;
            this.lblPersonProfilOtherName.Location = new System.Drawing.Point(13, 77);
            this.lblPersonProfilOtherName.Name = "lblPersonProfilOtherName";
            this.lblPersonProfilOtherName.Size = new System.Drawing.Size(116, 13);
            this.lblPersonProfilOtherName.TabIndex = 12;
            this.lblPersonProfilOtherName.Text = "Autre(s) nom et prénom";
            // 
            // lbPersonProfilComment
            // 
            this.lbPersonProfilComment.AutoSize = true;
            this.lbPersonProfilComment.Location = new System.Drawing.Point(13, 251);
            this.lbPersonProfilComment.Name = "lbPersonProfilComment";
            this.lbPersonProfilComment.Size = new System.Drawing.Size(195, 13);
            this.lbPersonProfilComment.TabIndex = 11;
            this.lbPersonProfilComment.Text = "Remarques et raison de l\'enregistrement";
            // 
            // lblPersonProfilJob
            // 
            this.lblPersonProfilJob.AutoSize = true;
            this.lblPersonProfilJob.Location = new System.Drawing.Point(391, 51);
            this.lblPersonProfilJob.Name = "lblPersonProfilJob";
            this.lblPersonProfilJob.Size = new System.Drawing.Size(56, 13);
            this.lblPersonProfilJob.TabIndex = 10;
            this.lblPersonProfilJob.Text = "Profession";
            // 
            // lblPersonProfilDocNumber
            // 
            this.lblPersonProfilDocNumber.AutoSize = true;
            this.lblPersonProfilDocNumber.Location = new System.Drawing.Point(338, 129);
            this.lblPersonProfilDocNumber.Name = "lblPersonProfilDocNumber";
            this.lblPersonProfilDocNumber.Size = new System.Drawing.Size(109, 13);
            this.lblPersonProfilDocNumber.TabIndex = 9;
            this.lblPersonProfilDocNumber.Text = "Numéro de document";
            // 
            // lblPersonProfilIdValidity
            // 
            this.lblPersonProfilIdValidity.AutoSize = true;
            this.lblPersonProfilIdValidity.Location = new System.Drawing.Point(361, 103);
            this.lblPersonProfilIdValidity.Name = "lblPersonProfilIdValidity";
            this.lblPersonProfilIdValidity.Size = new System.Drawing.Size(86, 13);
            this.lblPersonProfilIdValidity.TabIndex = 8;
            this.lblPersonProfilIdValidity.Text = "Date d\'expiration";
            // 
            // lblPersonProfilDocumentType
            // 
            this.lblPersonProfilDocumentType.AutoSize = true;
            this.lblPersonProfilDocumentType.Location = new System.Drawing.Point(351, 77);
            this.lblPersonProfilDocumentType.Name = "lblPersonProfilDocumentType";
            this.lblPersonProfilDocumentType.Size = new System.Drawing.Size(96, 13);
            this.lblPersonProfilDocumentType.TabIndex = 7;
            this.lblPersonProfilDocumentType.Text = "Type de document";
            // 
            // lblPersonProfilBirthday
            // 
            this.lblPersonProfilBirthday.AutoSize = true;
            this.lblPersonProfilBirthday.Location = new System.Drawing.Point(351, 25);
            this.lblPersonProfilBirthday.Name = "lblPersonProfilBirthday";
            this.lblPersonProfilBirthday.Size = new System.Drawing.Size(96, 13);
            this.lblPersonProfilBirthday.TabIndex = 6;
            this.lblPersonProfilBirthday.Text = "Date de naissance";
            // 
            // lblPersonProfilCountry
            // 
            this.lblPersonProfilCountry.AutoSize = true;
            this.lblPersonProfilCountry.Location = new System.Drawing.Point(35, 155);
            this.lblPersonProfilCountry.Name = "lblPersonProfilCountry";
            this.lblPersonProfilCountry.Size = new System.Drawing.Size(94, 13);
            this.lblPersonProfilCountry.TabIndex = 5;
            this.lblPersonProfilCountry.Text = "Pays de résidence";
            // 
            // lblPersonProfilNationality
            // 
            this.lblPersonProfilNationality.AutoSize = true;
            this.lblPersonProfilNationality.Location = new System.Drawing.Point(72, 181);
            this.lblPersonProfilNationality.Name = "lblPersonProfilNationality";
            this.lblPersonProfilNationality.Size = new System.Drawing.Size(57, 13);
            this.lblPersonProfilNationality.TabIndex = 4;
            this.lblPersonProfilNationality.Text = "Nationalité";
            // 
            // lblPersonProfilCity
            // 
            this.lblPersonProfilCity.AutoSize = true;
            this.lblPersonProfilCity.Location = new System.Drawing.Point(103, 129);
            this.lblPersonProfilCity.Name = "lblPersonProfilCity";
            this.lblPersonProfilCity.Size = new System.Drawing.Size(26, 13);
            this.lblPersonProfilCity.TabIndex = 3;
            this.lblPersonProfilCity.Text = "Ville";
            // 
            // lblPersonProfilRoad
            // 
            this.lblPersonProfilRoad.AutoSize = true;
            this.lblPersonProfilRoad.Location = new System.Drawing.Point(77, 103);
            this.lblPersonProfilRoad.Name = "lblPersonProfilRoad";
            this.lblPersonProfilRoad.Size = new System.Drawing.Size(52, 13);
            this.lblPersonProfilRoad.TabIndex = 2;
            this.lblPersonProfilRoad.Text = "Rue et n°";
            // 
            // lblPersonProfilFirstName
            // 
            this.lblPersonProfilFirstName.AutoSize = true;
            this.lblPersonProfilFirstName.Location = new System.Drawing.Point(86, 51);
            this.lblPersonProfilFirstName.Name = "lblPersonProfilFirstName";
            this.lblPersonProfilFirstName.Size = new System.Drawing.Size(43, 13);
            this.lblPersonProfilFirstName.TabIndex = 1;
            this.lblPersonProfilFirstName.Text = "Prénom";
            // 
            // lblPersonProfilLastName
            // 
            this.lblPersonProfilLastName.AutoSize = true;
            this.lblPersonProfilLastName.Location = new System.Drawing.Point(100, 25);
            this.lblPersonProfilLastName.Name = "lblPersonProfilLastName";
            this.lblPersonProfilLastName.Size = new System.Drawing.Size(29, 13);
            this.lblPersonProfilLastName.TabIndex = 0;
            this.lblPersonProfilLastName.Text = "Nom";
            // 
            // personProfilPanel
            // 
            this.personProfilPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.personProfilPanel.Controls.Add(this.btnDeletePerson);
            this.personProfilPanel.Controls.Add(this.btnPersonProfilEmpty);
            this.personProfilPanel.Controls.Add(this.btnPersonProfilSave);
            this.personProfilPanel.Controls.Add(this.rtbPersonProfilComment);
            this.personProfilPanel.Controls.Add(this.cmbPersonProfilDocType);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilDocNumber);
            this.personProfilPanel.Controls.Add(this.dtpPersonProfilIdValidity);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilJob);
            this.personProfilPanel.Controls.Add(this.dtpPersonProfilBirthday);
            this.personProfilPanel.Controls.Add(this.cmbPersonProfilNationality);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilCountry);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilCity);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilRoad);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilOtherName);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilFirstName);
            this.personProfilPanel.Controls.Add(this.txtPersonProfilLastName);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilOtherName);
            this.personProfilPanel.Controls.Add(this.lbPersonProfilComment);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilJob);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilDocNumber);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilIdValidity);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilDocumentType);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilBirthday);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilCountry);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilNationality);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilCity);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilRoad);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilFirstName);
            this.personProfilPanel.Controls.Add(this.lblPersonProfilLastName);
            this.personProfilPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personProfilPanel.Location = new System.Drawing.Point(0, 0);
            this.personProfilPanel.Name = "personProfilPanel";
            this.personProfilPanel.Size = new System.Drawing.Size(800, 450);
            this.personProfilPanel.TabIndex = 1;
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.Color.Red;
            this.btnDeletePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletePerson.FlatAppearance.BorderSize = 0;
            this.btnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePerson.Font = new System.Drawing.Font("Lucien Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePerson.ForeColor = System.Drawing.Color.White;
            this.btnDeletePerson.Location = new System.Drawing.Point(16, 392);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(135, 42);
            this.btnDeletePerson.TabIndex = 29;
            this.btnDeletePerson.Text = "Supprimer le client";
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            // 
            // PersonProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personProfilPanel);
            this.Name = "PersonProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBA - Profil client";
            this.Load += new System.EventHandler(this.PersonProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbatestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lba_testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNationalityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNationalityBindingSource)).EndInit();
            this.personProfilPanel.ResumeLayout(false);
            this.personProfilPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private lba_testDataSetTableAdapters.T_NationalityTableAdapter t_NationalityTableAdapter;
        private System.Windows.Forms.BindingSource lbatestDataSetBindingSource;
        private lba_testDataSet lba_testDataSet;
        private System.Windows.Forms.Button btnPersonProfilEmpty;
        private System.Windows.Forms.Button btnPersonProfilSave;
        public System.Windows.Forms.RichTextBox rtbPersonProfilComment;
        public System.Windows.Forms.ComboBox cmbPersonProfilDocType;
        public System.Windows.Forms.TextBox txtPersonProfilDocNumber;
        public System.Windows.Forms.DateTimePicker dtpPersonProfilIdValidity;
        public System.Windows.Forms.TextBox txtPersonProfilJob;
        public System.Windows.Forms.DateTimePicker dtpPersonProfilBirthday;
        public System.Windows.Forms.ComboBox cmbPersonProfilNationality;
        private System.Windows.Forms.BindingSource tNationalityBindingSource;
        public System.Windows.Forms.TextBox txtPersonProfilCountry;
        public System.Windows.Forms.TextBox txtPersonProfilCity;
        public System.Windows.Forms.TextBox txtPersonProfilRoad;
        public System.Windows.Forms.TextBox txtPersonProfilOtherName;
        public System.Windows.Forms.TextBox txtPersonProfilFirstName;
        public System.Windows.Forms.TextBox txtPersonProfilLastName;
        private System.Windows.Forms.Label lblPersonProfilOtherName;
        private System.Windows.Forms.Label lbPersonProfilComment;
        private System.Windows.Forms.Label lblPersonProfilJob;
        private System.Windows.Forms.Label lblPersonProfilDocNumber;
        private System.Windows.Forms.Label lblPersonProfilIdValidity;
        private System.Windows.Forms.Label lblPersonProfilDocumentType;
        private System.Windows.Forms.Label lblPersonProfilBirthday;
        private System.Windows.Forms.Label lblPersonProfilCountry;
        private System.Windows.Forms.Label lblPersonProfilNationality;
        private System.Windows.Forms.Label lblPersonProfilCity;
        private System.Windows.Forms.Label lblPersonProfilRoad;
        private System.Windows.Forms.Label lblPersonProfilFirstName;
        private System.Windows.Forms.Label lblPersonProfilLastName;
        private System.Windows.Forms.Panel personProfilPanel;
        public int personIdToModify;
        private System.Windows.Forms.BindingSource tNationalityBindingSource1;
        private System.Windows.Forms.Button btnDeletePerson;
    }
}