using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optativa_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void Vowels();

        private void btn_color1_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.Red; 
        }
        private void btn_color1_MouseLeave(object sender, EventArgs e)
        {
            btn_color1.BackColor = Color.Gainsboro;
        }
        private void btn_color1_MouseEnter(object sender, EventArgs e)
        {
            btn_color1.BackColor = Color.Red;
        }

        private void btn_color2_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.Blue; 
        }
        private void btn_color2_MouseLeave_1(object sender, EventArgs e)
        {
            btn_color2.BackColor = Color.Gainsboro;
        }
        private void btn_color2_MouseEnter_1(object sender, EventArgs e)
        {
            btn_color2.BackColor = Color.Blue;
        }
        
        private void btn_color3_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.ForestGreen; 
        }
        private void btn_color3_MouseLeave_2(object sender, EventArgs e)
        {
            btn_color3.BackColor = Color.Gainsboro;
        }
        private void btn_color3_MouseEnter_2(object sender, EventArgs e)
        {
            btn_color3.BackColor = Color.ForestGreen;
        }

        private void btn_color4_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.Yellow; 
        }
        private void btn_color4_MouseLeave_3(object sender, EventArgs e)
        {
            btn_color4.BackColor = Color.Gainsboro;
        }
        private void btn_color4_MouseEnter_3(object sender, EventArgs e)
        {
            btn_color4.BackColor = Color.Yellow;
        }

        private void btn_color5_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.HotPink; 
        }
        private void btn_color5_MouseLeave(object sender, EventArgs e)
        {
            btn_color5.BackColor = Color.Gainsboro;
        }
        private void btn_color5_MouseEnter(object sender, EventArgs e)
        {
            btn_color5.BackColor = Color.HotPink;
        }

        private void btn_color6_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.DarkGray; 
        }
        private void btn_color6_MouseLeave(object sender, EventArgs e)
        {
            btn_color6.BackColor = Color.Gainsboro;
        }
        private void btn_color6_MouseEnter(object sender, EventArgs e)
        {
            btn_color6.BackColor = Color.DarkGray;
        }

        private void btn_color7_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.Brown; 
        }
        private void btn_color7_MouseLeave(object sender, EventArgs e)
        {
            btn_color7.BackColor = Color.Gainsboro;
        }
        private void btn_color7_MouseEnter(object sender, EventArgs e)
        {
            btn_color7.BackColor = Color.Brown;
        }

        private void btn_color8_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.SandyBrown; 
        }
        private void btn_color8_MouseLeave(object sender, EventArgs e)
        {
            btn_color8.BackColor = Color.Gainsboro;
        }
        private void btn_color8_MouseEnter(object sender, EventArgs e)
        {
            btn_color8.BackColor = Color.SandyBrown;
        }

        private void btn_color9_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.Crimson; 
        }
        private void btn_color9_MouseLeave(object sender, EventArgs e)
        {
            btn_color9.BackColor = Color.Gainsboro;
        }
        private void btn_color9_MouseEnter(object sender, EventArgs e)
        {
            btn_color9.BackColor = Color.Crimson;
        }

        private void btn_color10_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.CornflowerBlue;
        }
        private void btn_color10_MouseLeave(object sender, EventArgs e)
        {
            btn_color10.BackColor = Color.Gainsboro;
        }
        private void btn_color10_MouseEnter(object sender, EventArgs e)
        {
            btn_color10.BackColor = Color.CornflowerBlue;
        }

        private void btn_color111_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.Plum;
        }
        private void btn_color111_MouseLeave(object sender, EventArgs e)
        {
            btn_color111.BackColor = Color.Gainsboro;
        }
        private void btn_color111_MouseEnter(object sender, EventArgs e)
        {
            btn_color111.BackColor = Color.Plum;
        }

        private void btn_color222_Click(object sender, EventArgs e)
        {
            lbl_top.BackColor = Color.DodgerBlue;
        }
        private void btn_color222_MouseLeave(object sender, EventArgs e)
        {
            btn_color222.BackColor = Color.Gainsboro;
        }
        private void btn_color222_MouseEnter(object sender, EventArgs e)
        {
            btn_color222.BackColor = Color.DodgerBlue;
        }

        private void btn_gualterpistola_Click(object sender, EventArgs e)
        {
            frm_image otherForm = new frm_image();
            
            otherForm.ShowDialog();
        }

        
        public void VowelA()
        {
            frm_A A = new frm_A();
            A.ShowDialog();
        }
        public void VowelE()
        {
            frm_E E = new frm_E();
            E.ShowDialog();
        }
        public void VowelI()
        {
            frm_I I = new frm_I();
            I.ShowDialog();
        }
        public void VowelO()
        {
            frm_O O = new frm_O();
            O.ShowDialog();
        }
        public void VowelU()
        {
            frm_U U = new frm_U();
            U.ShowDialog();
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            Vowels vowel;

            vowel = VowelA;
            vowel += VowelE;
            vowel += VowelI;
            vowel += VowelO;
            vowel += VowelU;

            vowel.Invoke();
        }
    }
}