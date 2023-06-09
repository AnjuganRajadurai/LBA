﻿
namespace LBA
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.windowBar = new System.Windows.Forms.Panel();
            this.lblLBALogin = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.windowBar.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowBar
            // 
            this.windowBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowBar.Controls.Add(this.lblLBALogin);
            this.windowBar.Controls.Add(this.btnCloseApp);
            this.windowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBar.Location = new System.Drawing.Point(0, 0);
            this.windowBar.Name = "windowBar";
            this.windowBar.Size = new System.Drawing.Size(400, 24);
            this.windowBar.TabIndex = 0;
            this.windowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowBar_MouseDown);
            // 
            // lblLBALogin
            // 
            this.lblLBALogin.AutoSize = true;
            this.lblLBALogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBALogin.ForeColor = System.Drawing.Color.White;
            this.lblLBALogin.Location = new System.Drawing.Point(3, 5);
            this.lblLBALogin.Name = "lblLBALogin";
            this.lblLBALogin.Size = new System.Drawing.Size(80, 16);
            this.lblLBALogin.TabIndex = 2;
            this.lblLBALogin.Text = "LBA - Login";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.btnCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.Location = new System.Drawing.Point(329, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(71, 24);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.Text = "Fermer";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.loginPanel.Controls.Add(this.btnConnect);
            this.loginPanel.Controls.Add(this.btnEmpty);
            this.loginPanel.Controls.Add(this.txtLoginPassword);
            this.loginPanel.Controls.Add(this.txtLoginUsername);
            this.loginPanel.Controls.Add(this.lblPassword);
            this.loginPanel.Controls.Add(this.lblUsername);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 24);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(400, 176);
            this.loginPanel.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(210, 123);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 28);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connexion";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.btnEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpty.FlatAppearance.BorderSize = 0;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.White;
            this.btnEmpty.Location = new System.Drawing.Point(125, 123);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(57, 28);
            this.btnEmpty.TabIndex = 4;
            this.btnEmpty.Text = "Vider";
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(125, 83);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(178, 21);
            this.txtLoginPassword.TabIndex = 3;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginPassword_KeyDown);
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.Location = new System.Drawing.Point(125, 38);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(178, 21);
            this.txtLoginUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(37, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mot de passe";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(23, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nom d\'utilisateur";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.ControlBox = false;
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.windowBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.windowBar.ResumeLayout(false);
            this.windowBar.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowBar;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Label lblLBALogin;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}

