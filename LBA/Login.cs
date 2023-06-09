﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBA
{
    public partial class Login : Form
    {
        public MainPage mainPage;
        public string userGroup;
        private PrincipalContext ctx;
        public Login()
        {
            InitializeComponent();
            mainPage = new MainPage();
            //To get the actual connect user
            txtLoginUsername.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            //Connection to the Domain Controller
            ctx = new PrincipalContext(ContextType.Domain, "172.26.66.130");
        }

        //To be enabled to drag the Login Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtLoginPassword.Focus();
        }

        //Function to validate if user if from Active Directory
        public bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            //Find the user's group
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, username);
            GroupPrincipal group1 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-RW");
            GroupPrincipal group2 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-R");
            GroupPrincipal group3 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-W");
            GroupPrincipal group4 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-ADM");

            try
            {
                if (isValid = ctx.ValidateCredentials(username, password))
                {
                    username = string.Empty;
                    password = string.Empty;

                    if (user.IsMemberOf(group1))
                    {
                        mainPage.userGroup = "G-MONC1-APP-LBA-RW";
                    }
                    else if (user.IsMemberOf(group2))
                    {
                        mainPage.userGroup = "G-MONC1-APP-LBA-R";
                    }
                    else if (user.IsMemberOf(group3))
                    {
                        mainPage.userGroup = "G-MONC1-APP-LBA-W";
                    }
                    else if (user.IsMemberOf(group4))
                    {
                        mainPage.userGroup = "G-MONC1-APP-LBA-ADM";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Problème de connexion avec le contrôleur de domaine");
            }
            return isValid;
        }

        private void displayMainPage()
        {
            mainPage.Show();
            this.Hide();
        }

        //Function to connect to the main Page
        private void connect()
        {
            if (string.IsNullOrEmpty(txtLoginUsername.Text))
            {
                System.Windows.Forms.MessageBox.Show("Le nom d'utilisateur est vide !");
            }
            else if (string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                System.Windows.Forms.MessageBox.Show("Le champ mot de passe est vide !");
            }
            else if (ValidateLogin(txtLoginUsername.Text, txtLoginPassword.Text))
            {
                if (mainPage.userGroup == "G-MONC1-APP-LBA-R")
                {
                    displayMainPage();
                }
                else if (mainPage.userGroup == "G-MONC1-APP-LBA-RW")
                {
                    displayMainPage();
                }
                else if (mainPage.userGroup == "G-MONC1-APP-LBA-W")
                {
                    displayMainPage();
                }
                else
                {
                    displayMainPage();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Le mot de passe est incorrect ou le nom d'utilisateur si vous l'avez modifié");
            }
        }

        //Button to close the app
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button to empty the fields
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();

            txtLoginUsername.Focus();
        }

        //Button to try connecting
        private void btnConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        //Keydown to try connecting
        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connect();
            }
        }
    }
}
