using System.ComponentModel;

namespace MediaPlayer
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(12, 9);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(302, 33);
            this.lbProduct.TabIndex = 0;
            this.lbProduct.Text = "Media Player";
            this.lbProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVersion
            // 
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(12, 42);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(302, 23);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "Version 1.0.0";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCopyright
            // 
            this.lbCopyright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCopyright.Location = new System.Drawing.Point(12, 78);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(302, 93);
            this.lbCopyright.TabIndex = 2;
            // 
            // About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(326, 180);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Media Player";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbVersion;

        private System.Windows.Forms.Label lbCopyright;

        private System.Windows.Forms.Label lbProduct;

        #endregion
    }
}