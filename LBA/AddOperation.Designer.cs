
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
            this.addOperationPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addOperationPanel
            // 
            this.addOperationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.addOperationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOperationPanel.Location = new System.Drawing.Point(0, 0);
            this.addOperationPanel.Name = "addOperationPanel";
            this.addOperationPanel.Size = new System.Drawing.Size(800, 450);
            this.addOperationPanel.TabIndex = 0;
            // 
            // AddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addOperationPanel);
            this.Name = "AddOperation";
            this.Text = "LBA - Ajout d\'une transaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addOperationPanel;
    }
}