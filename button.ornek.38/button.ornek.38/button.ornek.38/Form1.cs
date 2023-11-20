using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ara = txtAranan.Text;
            bool kontrol = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (ara == listBox1.Items[i].ToString())
                {
                    kontrol = true;
                    break;

                }
            }
                if(kontrol==true)
                {
                    MessageBox.Show("Öğrenci bulundu.");

                }
                else
                {
                    MessageBox.Show("listede böyle biri yok");
                }
        
        }
    }
}
