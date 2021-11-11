using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form2 : Form
    {
        Random x = new Random();





        string sehir;


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
            string[] sehirler = { "İzmir","Adana","Ankara","Giresun","Kars","Kastamonu","Sinop","Trabzon","Van" };

            int rastgele = x.Next(0, 8);
            sehir = sehirler[rastgele];


            for (int i = 1; i < alfabe.Length; i++)
            {
                Button btn = new Button();
                btn.Text = alfabe[i].ToString();
                btn.Width = 35;
                btn.Height = 35;
                flowLayoutPanel1.Controls.Add(btn);
            }

            for (int a = 0; a < sehir.Length; a++)
            {
                TextBox txtbx = new TextBox();
                txtbx.Width = 35;
                txtbx.Height = 35;
                flowLayoutPanel2.Controls.Add(txtbx);
            }


        }
    }
}
