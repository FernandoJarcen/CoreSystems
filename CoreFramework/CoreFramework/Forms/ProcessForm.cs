using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreFramework.Forms
{
    public partial class ProcessForm : Form
    {
        public ProcessForm(string mensagem)
        {
            InitializeComponent();
            lbl_mensagem.Text = mensagem;
        }

        private void lbl_mensagem_SizeChanged(object sender, EventArgs e)
        {
            int largura = 0;
            largura = 70 + lbl_mensagem.Size.Width + 106;
            this.Size = new Size(largura, 102);
        }
    }
}
