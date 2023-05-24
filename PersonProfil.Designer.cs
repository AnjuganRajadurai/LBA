
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonProfil));
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
            this.btnPersonProfilEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonProfilEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.btnPersonProfilEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonProfilEmpty.FlatAppearance.BorderSize = 0;
            this.btnPersonProfilEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonProfilEmpty.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonProfilEmpty.ForeColor = System.Drawing.Color.White;
            this.btnPersonProfilEmpty.Location = new System.Drawing.Point(461, 405);
            this.btnPersonProfilEmpty.Name = "btnPersonProfilEmpty";
            this.btnPersonProfilEmpty.Size = new System.Drawing.Size(123, 29);
            this.btnPersonProfilEmpty.TabIndex = 28;
            this.btnPersonProfilEmpty.Text = "Vider";
            this.btnPersonProfilEmpty.UseVisualStyleBackColor = false;
            this.btnPersonProfilEmpty.Click += new System.EventHandler(this.btnPersonProfilEmpty_Click);
            // 
            // btnPersonProfilSave
            // 
            this.btnPersonProfilSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonProfilSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.btnPersonProfilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonProfilSave.FlatAppearance.BorderSize = 0;
            this.btnPersonProfilSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonProfilSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonProfilSave.ForeColor = System.Drawing.Color.White;
            this.btnPersonProfilSave.Location = new System.Drawing.Point(626, 405);
            this.btnPersonProfilSave.Name = "btnPersonProfilSave";
            this.btnPersonProfilSave.Size = new System.Drawing.Size(161, 29);
            this.btnPersonProfilSave.TabIndex = 27;
            this.btnPersonProfilSave.Text = "Sauvegarder";
            this.btnPersonProfilSave.UseVisualStyleBackColor = false;
            this.btnPersonProfilSave.Click += new System.EventHandler(this.btnPersonProfilSave_Click);
            // 
            // rtbPersonProfilComment
            // 
            this.rtbPersonProfilComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPersonProfilComment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPersonProfilComment.Location = new System.Drawing.Point(16, 267);
            this.rtbPersonProfilComment.Name = "rtbPersonProfilComment";
            this.rtbPersonProfilComment.Size = new System.Drawing.Size(772, 119);
            this.rtbPersonProfilComment.TabIndex = 26;
            this.rtbPersonProfilComment.Text = "";
            // 
            // cmbPersonProfilDocType
            // 
            this.cmbPersonProfilDocType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPersonProfilDocType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonProfilDocType.FormattingEnabled = true;
            this.cmbPersonProfilDocType.Items.AddRange(new object[] {
            "Carte d\'identité",
            "Carte d\'identité Suisse",
            "Passeport",
            "Permis de conduire",
            "Permis de conduire Suisse",
            "Permis de légimation Suisse",
            "Titre de séjour Suisse"});
            this.cmbPersonProfilDocType.Location = new System.Drawing.Point(467, 72);
            this.cmbPersonProfilDocType.Name = "cmbPersonProfilDocType";
            this.cmbPersonProfilDocType.Size = new System.Drawing.Size(150, 24);
            this.cmbPersonProfilDocType.TabIndex = 25;
            // 
            // txtPersonProfilDocNumber
            // 
            this.txtPersonProfilDocNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilDocNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilDocNumber.Location = new System.Drawing.Point(467, 128);
            this.txtPersonProfilDocNumber.Name = "txtPersonProfilDocNumber";
            this.txtPersonProfilDocNumber.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilDocNumber.TabIndex = 24;
            // 
            // dtpPersonProfilIdValidity
            // 
            this.dtpPersonProfilIdValidity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPersonProfilIdValidity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPersonProfilIdValidity.Location = new System.Drawing.Point(467, 102);
            this.dtpPersonProfilIdValidity.Name = "dtpPersonProfilIdValidity";
            this.dtpPersonProfilIdValidity.Size = new System.Drawing.Size(185, 21);
            this.dtpPersonProfilIdValidity.TabIndex = 23;
            // 
            // txtPersonProfilJob
            // 
            this.txtPersonProfilJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilJob.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilJob.Location = new System.Drawing.Point(467, 47);
            this.txtPersonProfilJob.Name = "txtPersonProfilJob";
            this.txtPersonProfilJob.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilJob.TabIndex = 21;
            // 
            // dtpPersonProfilBirthday
            // 
            this.dtpPersonProfilBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPersonProfilBirthday.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPersonProfilBirthday.Location = new System.Drawing.Point(467, 21);
            this.dtpPersonProfilBirthday.Name = "dtpPersonProfilBirthday";
            this.dtpPersonProfilBirthday.Size = new System.Drawing.Size(185, 21);
            this.dtpPersonProfilBirthday.TabIndex = 20;
            // 
            // cmbPersonProfilNationality
            // 
            this.cmbPersonProfilNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPersonProfilNationality.DataSource = this.tNationalityBindingSource1;
            this.cmbPersonProfilNationality.DisplayMember = "countryName";
            this.cmbPersonProfilNationality.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonProfilNationality.FormattingEnabled = true;
            this.cmbPersonProfilNationality.Location = new System.Drawing.Point(155, 181);
            this.cmbPersonProfilNationality.Name = "cmbPersonProfilNationality";
            this.cmbPersonProfilNationality.Size = new System.Drawing.Size(150, 24);
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
            this.txtPersonProfilCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilCountry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilCountry.Location = new System.Drawing.Point(155, 155);
            this.txtPersonProfilCountry.Name = "txtPersonProfilCountry";
            this.txtPersonProfilCountry.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilCountry.TabIndex = 18;
            // 
            // txtPersonProfilCity
            // 
            this.txtPersonProfilCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilCity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilCity.Location = new System.Drawing.Point(155, 129);
            this.txtPersonProfilCity.Name = "txtPersonProfilCity";
            this.txtPersonProfilCity.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilCity.TabIndex = 17;
            // 
            // txtPersonProfilRoad
            // 
            this.txtPersonProfilRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilRoad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilRoad.Location = new System.Drawing.Point(155, 103);
            this.txtPersonProfilRoad.Name = "txtPersonProfilRoad";
            this.txtPersonProfilRoad.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilRoad.TabIndex = 16;
            // 
            // txtPersonProfilOtherName
            // 
            this.txtPersonProfilOtherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilOtherName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilOtherName.Location = new System.Drawing.Point(155, 74);
            this.txtPersonProfilOtherName.Name = "txtPersonProfilOtherName";
            this.txtPersonProfilOtherName.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilOtherName.TabIndex = 15;
            // 
            // txtPersonProfilFirstName
            // 
            this.txtPersonProfilFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilFirstName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilFirstName.Location = new System.Drawing.Point(155, 48);
            this.txtPersonProfilFirstName.Name = "txtPersonProfilFirstName";
            this.txtPersonProfilFirstName.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilFirstName.TabIndex = 14;
            // 
            // txtPersonProfilLastName
            // 
            this.txtPersonProfilLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonProfilLastName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonProfilLastName.Location = new System.Drawing.Point(155, 22);
            this.txtPersonProfilLastName.Name = "txtPersonProfilLastName";
            this.txtPersonProfilLastName.Size = new System.Drawing.Size(150, 21);
            this.txtPersonProfilLastName.TabIndex = 13;
            // 
            // lblPersonProfilOtherName
            // 
            this.lblPersonProfilOtherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilOtherName.AutoSize = true;
            this.lblPersonProfilOtherName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilOtherName.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilOtherName.Location = new System.Drawing.Point(13, 77);
            this.lblPersonProfilOtherName.Name = "lblPersonProfilOtherName";
            this.lblPersonProfilOtherName.Size = new System.Drawing.Size(132, 15);
            this.lblPersonProfilOtherName.TabIndex = 12;
            this.lblPersonProfilOtherName.Text = "Autre(s) nom et prénom";
            // 
            // lbPersonProfilComment
            // 
            this.lbPersonProfilComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPersonProfilComment.AutoSize = true;
            this.lbPersonProfilComment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonProfilComment.ForeColor = System.Drawing.Color.White;
            this.lbPersonProfilComment.Location = new System.Drawing.Point(13, 251);
            this.lbPersonProfilComment.Name = "lbPersonProfilComment";
            this.lbPersonProfilComment.Size = new System.Drawing.Size(221, 15);
            this.lbPersonProfilComment.TabIndex = 11;
            this.lbPersonProfilComment.Text = "Remarques et raison de l\'enregistrement";
            // 
            // lblPersonProfilJob
            // 
            this.lblPersonProfilJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilJob.AutoSize = true;
            this.lblPersonProfilJob.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilJob.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilJob.Location = new System.Drawing.Point(391, 51);
            this.lblPersonProfilJob.Name = "lblPersonProfilJob";
            this.lblPersonProfilJob.Size = new System.Drawing.Size(62, 15);
            this.lblPersonProfilJob.TabIndex = 10;
            this.lblPersonProfilJob.Text = "Profession";
            // 
            // lblPersonProfilDocNumber
            // 
            this.lblPersonProfilDocNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilDocNumber.AutoSize = true;
            this.lblPersonProfilDocNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilDocNumber.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilDocNumber.Location = new System.Drawing.Point(329, 129);
            this.lblPersonProfilDocNumber.Name = "lblPersonProfilDocNumber";
            this.lblPersonProfilDocNumber.Size = new System.Drawing.Size(124, 15);
            this.lblPersonProfilDocNumber.TabIndex = 9;
            this.lblPersonProfilDocNumber.Text = "Numéro de document";
            // 
            // lblPersonProfilIdValidity
            // 
            this.lblPersonProfilIdValidity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilIdValidity.AutoSize = true;
            this.lblPersonProfilIdValidity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilIdValidity.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilIdValidity.Location = new System.Drawing.Point(355, 103);
            this.lblPersonProfilIdValidity.Name = "lblPersonProfilIdValidity";
            this.lblPersonProfilIdValidity.Size = new System.Drawing.Size(98, 15);
            this.lblPersonProfilIdValidity.TabIndex = 8;
            this.lblPersonProfilIdValidity.Text = "Date d\'expiration";
            // 
            // lblPersonProfilDocumentType
            // 
            this.lblPersonProfilDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilDocumentType.AutoSize = true;
            this.lblPersonProfilDocumentType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilDocumentType.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilDocumentType.Location = new System.Drawing.Point(347, 77);
            this.lblPersonProfilDocumentType.Name = "lblPersonProfilDocumentType";
            this.lblPersonProfilDocumentType.Size = new System.Drawing.Size(106, 15);
            this.lblPersonProfilDocumentType.TabIndex = 7;
            this.lblPersonProfilDocumentType.Text = "Type de document";
            // 
            // lblPersonProfilBirthday
            // 
            this.lblPersonProfilBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilBirthday.AutoSize = true;
            this.lblPersonProfilBirthday.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilBirthday.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilBirthday.Location = new System.Drawing.Point(346, 25);
            this.lblPersonProfilBirthday.Name = "lblPersonProfilBirthday";
            this.lblPersonProfilBirthday.Size = new System.Drawing.Size(107, 15);
            this.lblPersonProfilBirthday.TabIndex = 6;
            this.lblPersonProfilBirthday.Text = "Date de naissance";
            // 
            // lblPersonProfilCountry
            // 
            this.lblPersonProfilCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilCountry.AutoSize = true;
            this.lblPersonProfilCountry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilCountry.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilCountry.Location = new System.Drawing.Point(39, 155);
            this.lblPersonProfilCountry.Name = "lblPersonProfilCountry";
            this.lblPersonProfilCountry.Size = new System.Drawing.Size(106, 15);
            this.lblPersonProfilCountry.TabIndex = 5;
            this.lblPersonProfilCountry.Text = "Pays de résidence";
            // 
            // lblPersonProfilNationality
            // 
            this.lblPersonProfilNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilNationality.AutoSize = true;
            this.lblPersonProfilNationality.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilNationality.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilNationality.Location = new System.Drawing.Point(79, 181);
            this.lblPersonProfilNationality.Name = "lblPersonProfilNationality";
            this.lblPersonProfilNationality.Size = new System.Drawing.Size(66, 15);
            this.lblPersonProfilNationality.TabIndex = 4;
            this.lblPersonProfilNationality.Text = "Nationalité";
            // 
            // lblPersonProfilCity
            // 
            this.lblPersonProfilCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilCity.AutoSize = true;
            this.lblPersonProfilCity.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilCity.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilCity.Location = new System.Drawing.Point(114, 129);
            this.lblPersonProfilCity.Name = "lblPersonProfilCity";
            this.lblPersonProfilCity.Size = new System.Drawing.Size(31, 15);
            this.lblPersonProfilCity.TabIndex = 3;
            this.lblPersonProfilCity.Text = "Ville";
            // 
            // lblPersonProfilRoad
            // 
            this.lblPersonProfilRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilRoad.AutoSize = true;
            this.lblPersonProfilRoad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilRoad.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilRoad.Location = new System.Drawing.Point(90, 103);
            this.lblPersonProfilRoad.Name = "lblPersonProfilRoad";
            this.lblPersonProfilRoad.Size = new System.Drawing.Size(55, 15);
            this.lblPersonProfilRoad.TabIndex = 2;
            this.lblPersonProfilRoad.Text = "Rue et n°";
            // 
            // lblPersonProfilFirstName
            // 
            this.lblPersonProfilFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilFirstName.AutoSize = true;
            this.lblPersonProfilFirstName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilFirstName.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilFirstName.Location = new System.Drawing.Point(97, 51);
            this.lblPersonProfilFirstName.Name = "lblPersonProfilFirstName";
            this.lblPersonProfilFirstName.Size = new System.Drawing.Size(48, 15);
            this.lblPersonProfilFirstName.TabIndex = 1;
            this.lblPersonProfilFirstName.Text = "Prénom";
            // 
            // lblPersonProfilLastName
            // 
            this.lblPersonProfilLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonProfilLastName.AutoSize = true;
            this.lblPersonProfilLastName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonProfilLastName.ForeColor = System.Drawing.Color.White;
            this.lblPersonProfilLastName.Location = new System.Drawing.Point(113, 25);
            this.lblPersonProfilLastName.Name = "lblPersonProfilLastName";
            this.lblPersonProfilLastName.Size = new System.Drawing.Size(32, 15);
            this.lblPersonProfilLastName.TabIndex = 0;
            this.lblPersonProfilLastName.Text = "Nom";
            // 
            // personProfilPanel
            // 
            this.personProfilPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
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
            this.btnDeletePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.btnDeletePerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletePerson.FlatAppearance.BorderSize = 0;
            this.btnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePerson.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePerson.ForeColor = System.Drawing.Color.White;
            this.btnDeletePerson.Location = new System.Drawing.Point(16, 405);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(135, 29);
            this.btnDeletePerson.TabIndex = 29;
            this.btnDeletePerson.Text = "Supprimer le client";
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // PersonProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personProfilPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        public System.Windows.Forms.Button btnPersonProfilEmpty;
        public System.Windows.Forms.Button btnPersonProfilSave;
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
        public System.Windows.Forms.Button btnDeletePerson;
    }
}