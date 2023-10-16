using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_if_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gunAd=comboBox1.Text;
            int gunNo=comboBox1.SelectedIndex;

            

            if (gunNo == 0 || gunNo == 1 || gunNo == 2)
            {
                label2.Text = "Çıkış saati  16:40 ";
            }
            else if (gunNo==3 || gunNo == 4)
            {
                label2.Text = "Çıkış saati 15:50";
            }
            else 
            {

                label2.Text = "Tatil";
            }



        }
    }
}
