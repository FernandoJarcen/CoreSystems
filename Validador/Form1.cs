using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreMDK.MDKBase;

namespace Validador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonExtends1_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            valor = CoreMDK.MDKBase.VSK.validade(fld_chave.Valor);
            this.fld_data.Valor = valor;
        }

        private void ButtonExtends2_Click(object sender, EventArgs e)
        {
            string data = dte_data.Valor;
            string retorno = string.Empty;
            retorno = CoreMDK.MDKBase.VSK.validadePorChave(data);
            fld_resultado.Valor = retorno;
        }

        //public static string validadePorChave(string chave)
        //{
        //    string retorno = "";
        //    string dia = string.Empty;
        //    string mes = string.Empty;
        //    string ano = string.Empty;

        //    ano = chave.Substring(8, 1);
        //    if (ano == "1") retorno += "J";
        //    else if (ano == "2") retorno += "K";
        //    else if (ano == "3") retorno += "L";
        //    else if (ano == "4") retorno += "M";
        //    else if (ano == "5") retorno += "N";
        //    else if (ano == "6") retorno += "O";
        //    else if (ano == "7") retorno += "P";
        //    else if (ano == "8") retorno += "R";
        //    else if (ano == "9") retorno += "S";
        //    else if (ano == "0") retorno += "T";

        //    ano = chave.Substring(9, 1);
        //    if (ano == "1") retorno += "S";
        //    else if (ano == "2") retorno += "T";
        //    else if (ano == "3") retorno += "U";
        //    else if (ano == "4") retorno += "V";
        //    else if (ano == "5") retorno += "X";
        //    else if (ano == "6") retorno += "Z";
        //    else if (ano == "7") retorno += "A";
        //    else if (ano == "8") retorno += "B";
        //    else if (ano == "9") retorno += "C";
        //    else if (ano == "0") retorno += "D";

        //    retorno += chave.Substring(0,2);

        //    mes = chave.Substring(3, 2);
        //    if (mes == "01") retorno += "F";
        //    else if (mes == "02") retorno += "G";
        //    else if (mes == "03") retorno += "H";
        //    else if (mes == "04") retorno += "I";
        //    else if (mes == "05") retorno += "J";
        //    else if (mes == "06") retorno += "K";
        //    else if (mes == "07") retorno += "L";
        //    else if (mes == "08") retorno += "M";
        //    else if (mes == "09") retorno += "N";
        //    else if (mes == "10") retorno += "O";
        //    else if (mes == "11") retorno += "P";
        //    else if (mes == "12") retorno += "R";

            

            
        //    return retorno;
        //}
    }
}
