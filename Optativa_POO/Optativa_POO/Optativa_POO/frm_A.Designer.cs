using System.ComponentModel;

namespace Optativa_POO
{
    partial class frm_A
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
            this.lbl_A = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_A
            // 
            this.lbl_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_A.Location = new System.Drawing.Point(46, 31);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(277, 129);
            this.lbl_A.TabIndex = 0;
            this.lbl_A.Text = "A";
            this.lbl_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 214);
            this.Controls.Add(this.lbl_A);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_A";
            this.Text = "frm_A";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_A;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}