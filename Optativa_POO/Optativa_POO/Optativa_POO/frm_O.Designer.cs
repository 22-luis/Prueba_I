using System.ComponentModel;

namespace Optativa_POO
{
    partial class frm_O
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
            this.lbl_O = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_O
            // 
            this.lbl_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_O.Location = new System.Drawing.Point(47, 40);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(285, 152);
            this.lbl_O.TabIndex = 0;
            this.lbl_O.Text = "O";
            this.lbl_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_O
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 214);
            this.Controls.Add(this.lbl_O);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_O";
            this.Text = "frm_O";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbl_O;

        #endregion
    }
}