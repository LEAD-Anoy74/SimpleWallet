﻿namespace SimpleWallet
{
    partial class SendingCoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendingCoin));
            this.lbChecking = new System.Windows.Forms.Label();
            this.pbTransaction = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbChecking
            // 
            this.lbChecking.AutoSize = true;
            this.lbChecking.ForeColor = System.Drawing.Color.Gold;
            this.lbChecking.Location = new System.Drawing.Point(17, 16);
            this.lbChecking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChecking.Name = "lbChecking";
            this.lbChecking.Size = new System.Drawing.Size(121, 15);
            this.lbChecking.TabIndex = 0;
            this.lbChecking.Text = "Checking transaction";
            // 
            // pbTransaction
            // 
            this.pbTransaction.Location = new System.Drawing.Point(16, 46);
            this.pbTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.pbTransaction.Name = "pbTransaction";
            this.pbTransaction.Size = new System.Drawing.Size(347, 15);
            this.pbTransaction.Step = 1;
            this.pbTransaction.TabIndex = 1;
            // 
            // SendingCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(379, 75);
            this.Controls.Add(this.pbTransaction);
            this.Controls.Add(this.lbChecking);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendingCoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SendingCoin";
            this.Load += new System.EventHandler(this.SendingCoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChecking;
        private System.Windows.Forms.ProgressBar pbTransaction;
    }
}