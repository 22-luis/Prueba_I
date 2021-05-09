using System.ComponentModel;

namespace Optativa_POO
{
    partial class frm_E
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
            this.lbl_E = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_E
            // 
            this.lbl_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_E.Location = new System.Drawing.Point(45, 43);
            this.lbl_E.Name = "lbl_E";
            this.lbl_E.Size = new System.Drawing.Size(277, 129);
            this.lbl_E.TabIndex = 1;
            this.lbl_E.Text = "E";
            this.lbl_E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 214);
            this.Controls.Add(this.lbl_E);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_E";
            this.Text = "frm_E";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_E;

        #endregion
    }
}