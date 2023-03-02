using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesaplama_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 Form2 = new Form2();
        Form3 Form3 = new Form3();
        Form4 Form4 = new Form4();
        Form5 Form5 = new Form5();
        Form6 Form6 = new Form6();
        int alisFiyat, satisFiyat;
        private void button1_Click(object sender, EventArgs e)
        {
            //KAR HESAPLAMA KODLARI form1 i kapayamadın hatayı sor. formu kapattıktan sonra aynı formu tekrar açabilmek için ne yazmak gerekiyo. çünkü açınca hata verio
            // sor
            Form2.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ZARAR HESAPLAMA KODLARI tointin icine textbox1 yazamıyorum
            Form3.Show();
            alisFiyat = Convert.ToInt32();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ÜS HESAPLAMA KODLARI
            Form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FAKTÖRİYEL HESAPLAMA KODLARI
            Form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ÇEVRE HESAPLAMA KODLARI
            Form6.Show();
        }
    }
}
