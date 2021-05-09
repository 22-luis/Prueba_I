using System.ComponentModel;

namespace Optativa_POO
{
    partial class frm_image
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
            this.pic_mariopistola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pic_mariopistola)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_mariopistola
            // 
            this.pic_mariopistola.Image = global::Optativa_POO.Properties.Resources.Mariopistola;
            this.pic_mariopistola.Location = new System.Drawing.Point(14, 16);
            this.pic_mariopistola.Name = "pic_mariopistola";
            this.pic_mariopistola.Size = new System.Drawing.Size(388, 387);
            this.pic_mariopistola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mariopistola.TabIndex = 0;
            this.pic_mariopistola.TabStop = false;
            // 
            // frm_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.pic_mariopistola);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_image";
            this.Text = "frm_image";
            ((System.ComponentModel.ISupportInitialize) (this.pic_mariopistola)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pic_mariopistola;
        

        #endregion
    }
}