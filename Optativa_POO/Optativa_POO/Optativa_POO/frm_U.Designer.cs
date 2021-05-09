using System.ComponentModel;

namespace Optativa_POO
{
    partial class frm_U
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
            this.lbl_U = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_U
            // 
            this.lbl_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_U.Location = new System.Drawing.Point(45, 43);
            this.lbl_U.Name = "lbl_U";
            this.lbl_U.Size = new System.Drawing.Size(277, 129);
            this.lbl_U.TabIndex = 1;
            this.lbl_U.Text = "U";
            this.lbl_U.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_U
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 214);
            this.Controls.Add(this.lbl_U);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_U";
            this.Text = "frm_U";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_U;

        #endregion
    }
}