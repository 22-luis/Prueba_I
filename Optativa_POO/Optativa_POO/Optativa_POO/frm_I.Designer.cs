using System.ComponentModel;

namespace Optativa_POO
{
    partial class frm_I
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
            this.lbl_I = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_I
            // 
            this.lbl_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_I.Location = new System.Drawing.Point(45, 43);
            this.lbl_I.Name = "lbl_I";
            this.lbl_I.Size = new System.Drawing.Size(277, 129);
            this.lbl_I.TabIndex = 1;
            this.lbl_I.Text = "I";
            this.lbl_I.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 214);
            this.Controls.Add(this.lbl_I);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_I";
            this.Text = "frm_I";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_I;

        #endregion
    }
}