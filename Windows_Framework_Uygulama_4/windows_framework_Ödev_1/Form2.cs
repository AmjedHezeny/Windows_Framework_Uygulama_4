using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windows_framework_Ödev_1
{
    public partial class List_Box_Ödevi : Form
    {
        public List_Box_Ödevi()
        {
            InitializeComponent();
        }

        private void Ekle_Dugmesi_Click(object sender, EventArgs e)
        {
            string metin = Metin_Kutusu.Text;
            if (string.IsNullOrEmpty(metin))
            {
                labla_Bİlgi.Text = "Metin Alanı Boş Bırakılamaz";
            }
            else
            {
                listBox1.Items.Add(metin);
                Metin_Kutusu.Clear();
                labla_Bİlgi.Text = metin + " Listeye Eklendi";
            }
        }

        private void Duzenlem_Dugmesi_Click(object sender, EventArgs e)
        {
            string sehir = Metin_Kutusu_Duzenli.Text;
            if (listBox1.SelectedIndex == -1)
            {
                labla_Bİlgi.Text = "Değiştirelecek İsim Seçiniz !!!";
            }
            else
            {
                if (string.IsNullOrEmpty(sehir))
                {
                    labla_Bİlgi.Text = "Yazı Alanı Boş Bırakılamaz !!!";
                    Metin_Kutusu_Duzenli.Focus();
                }
                else
                {
                    listBox1.Items[listBox1.SelectedIndex] = sehir;
                    listBox1.SelectedIndex = -1;
                    Metin_Kutusu_Duzenli.Clear();
                    labla_Bİlgi.Text = string.Empty;
                }
            }
        }

        private void Sil_Dugmesi_Click(object sender, EventArgs e)
        {
            int seciliIndex = listBox1.SelectedIndex;
            if (seciliIndex == -1)
            {
                labla_Bİlgi.Text = "Herhangi bir İsim Seçmediniz !!!";
            }
            else
            {
                string sehir = listBox1.Items[seciliIndex].ToString();
                listBox1.Items.RemoveAt(seciliIndex);
                labla_Bİlgi.Text = string.Format("{0} İsmini Listenizden Silindi", sehir);
            }
        }

        private void Hepsini_Sil_Dugmesi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labla_Bİlgi.Text = "Tüm İsimleri Silindi";
        }

        private void Sırala_Dugmesi_Click(object sender, EventArgs e)
        {
            var items = listBox1.Items.Cast<string>().OrderBy(x => x).ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(items);
            labla_Bİlgi.Text = "Tüm İsimleri Alfabetik Olarak Sıralanmış";
        }
    }
}
