using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seg = CoreFramework.Utils.Seguranca;

namespace Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criptografar_Click(object sender, EventArgs e)
        {
            tbx_para.Text = seg.MD5Crypt.Criptografar(tbx_de.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbx_para.Text = seg.MD5Crypt.Descriptografar(tbx_de.Text);
        }
    }
}
