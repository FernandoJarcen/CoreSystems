using CoreSDK.Objetos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoreSDK.Utils
{
    public static class Forms
    {

        [Funcionalidade("Comandos de formularios", "12/08/2019")]
        public static Enums.Controles.NivelAcesso NivelAcesso { get; set; }

        public static void FecharForm(Form formulario)
        {
            for (Double i = -1; i <= 0; i++)
            {
                formulario.Opacity = System.Math.Abs(i);
            }
            formulario.Close();
        }

        public static void AbrirForm(Form formulario)
        {
            for (Double i = 0; i <= 1; i = i + 0.05)
            {
                formulario.Opacity = System.Math.Abs(i);
            }
        }

        public static void FuncaoBotoes(KeyPressEventArgs parametro)
        {
            int key = 0;
            key = (char)parametro.KeyChar;
            if (key == 13)
            {
                SendKeys.Send("{TAB}");
                key = 0;
            }
        }

        public static void ControleSelecionado(Object parametro, Color cor)
        {
            TextBox box = (TextBox)parametro;
            box.BackColor = cor;
        }

        public static void ControleVisivel(Control objeto, bool status)
        {
            Control c = objeto;
            c.Visible = status;
        }

        public static void ControleVisivel(DevComponents.DotNetBar.RibbonTabItem objeto, bool status)
        {
            DevComponents.DotNetBar.RibbonTabItem c = objeto;
            c.Visible = status;
        }

        public static void ControleVisivel(DevComponents.DotNetBar.RibbonBar objeto, bool status)
        {
            DevComponents.DotNetBar.RibbonBar c = objeto;
            c.Visible = status;
        }

        public static void ControleVisivel(DevComponents.DotNetBar.ButtonItem objeto, bool status)
        {
            DevComponents.DotNetBar.ButtonItem c = objeto;
            c.Visible = status;
        }

        public static void ControleHabilitado(Control controle, bool estado)
        {
            Control c = controle;
            c.Enabled = estado;
        }

        public static void ControleHabilitado(DevComponents.DotNetBar.RibbonTabItem objeto, bool status)
        {
            DevComponents.DotNetBar.RibbonTabItem c = objeto;
            c.Enabled = status;
        }

        public static void ControleHabilitado(DevComponents.DotNetBar.RibbonBar objeto, bool status)
        {
            DevComponents.DotNetBar.RibbonBar c = objeto;
            c.Enabled = status;
        }

        public static void ControleHabilitado(DevComponents.DotNetBar.ButtonItem objeto, bool status)
        {
            DevComponents.DotNetBar.ButtonItem c = objeto;
            c.Enabled = status;
        }

        public static bool VerificarInstanciaForm(Form formulario)
        {
            bool retorno = false;
            int ativos = Application.OpenForms.Count;
            for (int i = 0; i < ativos; i++)
            {
                if (Application.OpenForms[i].Name == formulario.Name)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static void AbreFormulario(Form formulario, Enums.Controles.TipoFormulario modo = 0)
        {
            if (VerificarInstanciaForm(formulario) != true)
            {
                Form frm = new Form();
                frm = formulario;
                if (modo == 0)
                    frm.Show();
                else
                    frm.ShowDialog();

            }
        }

        public static object AbreFormularioBase(Form formulario, Enums.Controles.TipoFormulario modo = Enums.Controles.TipoFormulario.Normal, Enums.Controles.NivelAcesso nivel = Enums.Controles.NivelAcesso.Nenhum)
        {
            var frm = new Form();
            if (VerificarInstanciaForm(formulario) != true)
            {
                frm = formulario;
                NivelAcesso = nivel;

                if (modo == Enums.Controles.TipoFormulario.Normal)
                    frm.Show();
                else
                    frm.ShowDialog();
            }
            return frm;
        }
    }

}
