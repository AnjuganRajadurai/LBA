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
        private PrincipalContext ctx;
        public Login()
        {
            InitializeComponent();
            txtLoginUsername.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            ctx = new PrincipalContext(ContextType.Domain, "172.26.66.130");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public string userGroup = "";

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, username);
            GroupPrincipal group1 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-RW");
            GroupPrincipal group2 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-R");
            GroupPrincipal group3 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-W");
            GroupPrincipal group4 = GroupPrincipal.FindByIdentity(ctx, "G-MONC1-APP-LBA-ADM");

            if (user != null)
            {
                if (user.IsMemberOf(group1))
                {
                    try
                    {
                        if (isValid = ctx.ValidateCredentials(username, password))
                        {
                            username = string.Empty;
                            password = string.Empty;

                            userGroup = "G-MONC1-APP-LBA-RW";
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Problème de connexion avec le contrôleur de domaine");
                    }
                }
                else if (user.IsMemberOf(group2))
                {
                    try
                    {
                        if (isValid = ctx.ValidateCredentials(username, password))
                        {
                            username = string.Empty;
                            password = string.Empty;

                            userGroup = "G-MONC1-APP-LBA-R";
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Problème de connexion avec le contrôleur de domaine");
                    }
                }
                else if (user.IsMemberOf(group3))
                {
                    try
                    {
                        if (isValid = ctx.ValidateCredentials(username, password))
                        {
                            username = string.Empty;
                            password = string.Empty;

                            userGroup = "G-MONC1-APP-LBA-W";
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Problème de connexion avec le contrôleur de domaine");
                    }
                }
                else if (user.IsMemberOf(group4))
                {
                    try
                    {
                        if (isValid = ctx.ValidateCredentials(username, password))
                        {
                            username = string.Empty;
                            password = string.Empty;

                            userGroup = "G-MONC1-APP-LBA-ADM";
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Problème de connexion avec le contrôleur de domaine");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Vous ne possédez pas les autorisations pour vous connecter !");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ces informations de connexion ne correspondent pas à un utilisateur de l'AD");
            }
            return isValid;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();

            txtLoginUsername.Focus();
        }

        private void btnConnect_Click(object sender, EventArgs e)
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
                if (userGroup == "G-MONC1-APP-LBA-RW")
                {
                    System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                    MainPage display2 = new MainPage();
                    display2.Show();
                    this.Close();
                }
                else if (userGroup == "G-MONC1-APP-LBA-RW")
                {
                    System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                    MainPage display2 = new MainPage();
                    display2.Show();
                    this.Close();
                }
                else if (userGroup == "G-MONC1-APP-LBA-W")
                {
                    System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                    MainPage display2 = new MainPage();
                    display2.Show();
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                    MainPage display2 = new MainPage();
                    display2.Show();
                    this.Hide();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Le mot de passe est incorrect ou le nom d'utilisateur si vous l'avez modifié");
            }
        }

        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                    if (userGroup == "G-MONC1-APP-LBA-RW")
                    {
                        System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                        MainPage display2 = new MainPage();
                        display2.Show();
                        this.Hide();
                    }
                    else if (userGroup == "G-MONC1-APP-LBA-RW")
                    {
                        System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                        MainPage display2 = new MainPage();
                        display2.Show();
                        this.Hide();
                    }
                    else if (userGroup == "G-MONC1-APP-LBA-W")
                    {
                        System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                        MainPage display2 = new MainPage();
                        display2.Show();
                        this.Hide();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Connexion réusssie");
                        MainPage display2 = new MainPage();
                        display2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Le mot de passe est incorrect ou le nom d'utilisateur si vous l'avez modifié");
                }
            }
        }
    }
}