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
    public partial class windows_framework_Ödev_1 : Form
    {
        public windows_framework_Ödev_1()
        {
            InitializeComponent();
        }

        private void List_Box_Ödevi_Click(object sender, EventArgs e)
        {
            List_Box_Ödevi form = new List_Box_Ödevi();
            form.Show();
        }
    }
}
