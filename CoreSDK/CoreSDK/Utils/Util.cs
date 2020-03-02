using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using CoreSDK.Objetos;
using CoreSDK.Enums;
using CoreSDK.Specific;

namespace CoreSDK.Utils
{
    [Descricao("Classe utilitaria", "25/04/2019")]
    public class Util
    {
        #region variaveis globais

        [Funcionalidade("Equipe Ativa", "09/11/2017")]
        public static List<string> Equipe = new List<string>();
        [Funcionalidade("Parametros","15/05/2018")]
        public static Dictionary<Prm, Object> Parametros { get; set; }
        [Funcionalidade("Tipo Autenticacao","01/04/2019")]
        public static Enums.BancoDados.TipoAutenticacao TipoAutenticacao { get; set; }
        public static string Servico { get; set; }
        public static string Banco {get;set;}
        
        #endregion

        public Util()
        {

        }

        public static bool Executar(int instancia, string caminho = null)
        {
            bool retorno = false;
            string nomeproduto = string.Empty;
            string arquivoPadrao = string.Empty;
            string caminhoPadrao = string.Empty;
            string caminhoLOG = string.Empty;
            string caminhoExecutaveis = string.Empty;
            string caminhoConfiguracao = string.Empty;
            string caminhoCustomizacao = string.Empty;
            string caminhoExportador = string.Empty;
            string caminhoFormato = string.Empty;
            string chaveProduto = string.Empty;
            string permiteCustomizacao = string.Empty;
            string criptografado = string.Empty;

            try
            {
                arquivoPadrao = (!string.IsNullOrEmpty(caminho) ? caminho : "C:\\sistematica\\CFG\\mcapl.xml");
                caminhoPadrao = Xml.BuscaTAG("padrao");
                caminhoLOG = Xml.BuscaTAG("log");                
                caminhoExecutaveis = Xml.BuscaTAG("executaveis");
                caminhoConfiguracao = Xml.BuscaTAG("cfg");
                caminhoCustomizacao = Xml.BuscaTAG("customizacao");
                caminhoExportador = Xml.BuscaTAG("exportador");
                caminhoFormato = Xml.BuscaTAG("formatos");
                chaveProduto = Xml.BuscaTAG("chave");
                permiteCustomizacao = Xml.BuscaTAG("customizado");
                criptografado = Xml.BuscaTAG("criptografado");

                nomeproduto = Xml.BuscaNomeInstancia(instancia);

                Parametros = new Dictionary<Prm, object>();                
                Parametros.Add(Prm.CaminhoPadrao, caminhoPadrao);
                Parametros.Add(Prm.LOG, caminhoLOG);
                Parametros.Add(Prm.CaminhoExecutavel, caminhoExecutaveis);
                Parametros.Add(Prm.CaminhoConfiguracao, caminhoConfiguracao);
                Parametros.Add(Prm.CaminhoCustomizacao, new string[] { caminhoCustomizacao + "Forms", caminhoCustomizacao + "Imagens" });
                Parametros.Add(Prm.CaminhoExportador, caminhoExportador);
                Parametros.Add(Prm.CaminhoFormato, caminhoFormato);
                Parametros.Add(Prm.CodigoInstancia, instancia);
                Parametros.Add(Prm.NomeInstancia, nomeproduto);
                Parametros.Add(Prm.Chave, chaveProduto);
                Parametros.Add(Prm.PermiteCustomizacao, permiteCustomizacao);

                Parametros.Add(Prm.Servico, Xml.BuscaAtributo(nomeproduto, "datasource"));                
                Parametros.Add(Prm.TipoAutenticacao, Xml.BuscaAtributo(nomeproduto, "autenticacao"));
                Parametros.Add(Prm.Banco, Xml.BuscaAtributo(nomeproduto, "banco"));
                Parametros.Add(Prm.Criptografado, criptografado);

                if (!String.IsNullOrEmpty(Parametros[Prm.TipoAutenticacao].ToString()))
                {
                    if (Parametros[Prm.TipoAutenticacao].ToString() == "BANCO")
                        TipoAutenticacao = BancoDados.TipoAutenticacao.Banco;
                    else
                        TipoAutenticacao = BancoDados.TipoAutenticacao.AD;
                }
                Servico = Parametros[Prm.Servico].ToString();
                Banco = Parametros[Prm.Banco].ToString();
                
                retorno = validarParametros(Parametros);                
            }
            catch (Exception ex)
            {
                retorno = false;
                LOG.Escrever("Executar", ex.Message);
            }
            return retorno;
        }

        private static bool validarParametros(Dictionary<Prm, object> Parametros)
        {
            bool retorno = false;
            int indice = 0;
            foreach (var item in Parametros)
            {
                string tipo = item.Value.GetType().Name;
                indice += 1;
                if (indice <= 7)
                {
                    if (tipo == "String")
                    {
                        var existe = CoreSDK.Services.FileService.VerificarCaminho(item.Value.ToString());
                        if (!existe)
                            break;
                        else
                            retorno = true;
                    }
                }
                else
                    break;
            }    
            return retorno;
        }

        public static void CarregarModulo(String executavel, String nomeAmigavel)
        {
            String codigoFilial = Parametros[Prm.CodigoFilial].ToString();
            String nomeFilial = Parametros[Prm.FilialAtiva].ToString();
            int usuarioId = (int)Parametros[Prm.CodigoUsuario];
            String usuario = Parametros[Prm.NomeUsuario].ToString();
            int instancia = (int)Parametros[Prm.CodigoInstancia];

            string mensagem = string.Empty;
            try
            {
                if (CoreSDK.Services.FileService.VerificarArquivo(executavel))
                {
                    mensagem =  Modulo.AbrirModulos(executavel, codigoFilial, nomeFilial, usuarioId, usuario, instancia);
                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        MessageBox.Show(mensagem);
                    }
                }
                else
                    MessageBox.Show(nomeAmigavel.PriMaiuscula() + " não encontrado!", "Sistemática", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(Genericos.PriMaiuscula(nomeAmigavel) + " não encontrado!", "Sistemática", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public static class Formularios
        //{

        //    [Funcionalidade("Nivel Acesso", "28/08/2018")]
        //    public static Enums.Controles.NivelAcesso NivelAcesso { get; set; }

        //    public static void FecharForm(Form formulario)
        //    {
        //        for (Double i = -1; i <= 0; i++)
        //        {
        //            formulario.Opacity = System.Math.Abs(i);
        //        }
        //        formulario.Close();
        //    }

        //    public static void AbrirForm(Form formulario)
        //    {
        //        for (Double i = 0; i <= 1; i = i + 0.05)
        //        {
        //            formulario.Opacity = System.Math.Abs(i);
        //        }
        //    }

        //    public static void FuncaoBotoes(KeyPressEventArgs parametro)
        //    {
        //        int key = 0;
        //        key = (char)parametro.KeyChar;
        //        if (key == 13)
        //        {
        //            SendKeys.Send("{TAB}");
        //            key = 0;
        //        }
        //    }

        //    public static void ControleSelecionado(Object parametro, Color cor)
        //    {
        //        TextBox box = (TextBox)parametro;
        //        box.BackColor = cor;
        //    }

        //    public static void ControleVisivel(Control objeto, bool status)
        //    {
        //        Control c = objeto;
        //        c.Visible = status;
        //    }

        //    public static void ControleVisivel(DevComponents.DotNetBar.RibbonTabItem objeto, bool status)
        //    {
        //        DevComponents.DotNetBar.RibbonTabItem c = objeto;
        //        c.Visible = status;
        //    }

        //    public static void ControleVisivel(DevComponents.DotNetBar.RibbonBar objeto, bool status)
        //    {
        //        DevComponents.DotNetBar.RibbonBar c = objeto;
        //        c.Visible = status;
        //    }

        //    public static void ControleVisivel(DevComponents.DotNetBar.ButtonItem objeto, bool status)
        //    {
        //        DevComponents.DotNetBar.ButtonItem c = objeto;
        //        c.Visible = status;
        //    }

        //    public static void ControleHabilitado(Control controle, bool estado)
        //    {
        //        Control c = controle;
        //        c.Enabled = estado;
        //    }

        //    public static void ControleHabilitado(DevComponents.DotNetBar.RibbonTabItem objeto, bool status)
        //    {
        //        DevComponents.DotNetBar.RibbonTabItem c = objeto;
        //        c.Enabled = status;
        //    }

        //    public static void ControleHabilitado(DevComponents.DotNetBar.RibbonBar objeto, bool status)
        //    {
        //        DevComponents.DotNetBar.RibbonBar c = objeto;
        //        c.Enabled = status;
        //    }

        //    public static void ControleHabilitado(DevComponents.DotNetBar.ButtonItem objeto, bool status)
        //    {
        //        DevComponents.DotNetBar.ButtonItem c = objeto;
        //        c.Enabled = status;
        //    }

        //    public static bool VerificarInstanciaForm(Form formulario)
        //    {
        //        bool retorno = false;
        //        int ativos = Application.OpenForms.Count;
        //        for (int i = 0; i < ativos; i++)
        //        {
        //            if (Application.OpenForms[i].Name == formulario.Name)
        //            {
        //                retorno = true;
        //                break;
        //            }
        //        }
        //        return retorno;
        //    }

        //    public static void AbreFormulario(Form formulario, Enums.Controles.TipoFormulario modo = 0)
        //    {
        //        if (VerificarInstanciaForm(formulario) != true)
        //        {
        //            Form frm = new Form();
        //            frm = formulario;
        //            if (modo == 0)
        //                frm.Show();
        //            else
        //                frm.ShowDialog();

        //        }
        //    }

        //    public static void AbreFormulario(ref Form formulario, Enums.Controles.TipoFormulario modo = 0)
        //    {       
        //        if (VerificarInstanciaForm(formulario) != true)
        //        {
        //            Form frm = new Form();
        //            frm = formulario;
        //            if (modo == 0)
        //                frm.Show();
        //            else
        //                frm.ShowDialog();
                
        //        }                
        //    }

        //    public static object AbreFormularioBase(Form formulario, Enums.Controles.TipoFormulario modo = Enums.Controles.TipoFormulario.Normal, Enums.Controles.NivelAcesso nivel = Enums.Controles.NivelAcesso.Nenhum)
        //    {
        //        Form frm = new Form();
        //        if (VerificarInstanciaForm(formulario) != true)
        //        {
        //            frm = formulario;
        //            NivelAcesso = nivel;

        //            if (modo == Enums.Controles.TipoFormulario.Normal)
        //                frm.Show();
        //            else
        //                frm.ShowDialog();
        //        }
        //        return frm;
        //    }
        //}

        //public static class Genericos
        //{
        //    public static String PriMaiuscula(String nome)
        //    {
        //        string frase = nome;

        //        char primeira = char.ToUpper(frase[0]);
        //        frase = primeira + frase.Substring(1);
        //        return frase;
        //    }

        //    public static String LimparNulo(string valor)
        //    {
        //        string retorno = string.Empty;
        //        retorno = valor == "NULL" ? string.Empty : valor;
        //        return retorno;
        //    }
            
        //    public static String ConvDataHoje()
        //    {
        //        string texto = string.Empty;
        //        string retorno = string.Empty;
        //        texto = DateTime.Now.ToShortDateString();
        //        retorno = texto.Substring(6, 4) + "-" + texto.Substring(3, 2) + "-" + texto.Substring(0, 2);
        //        return retorno;
        //    }

        //    public static String ConvDataHoje(DateTime dia)
        //    {
        //        DateTime valor = dia;
        //        string data = string.Empty;
        //        string hora = string.Empty;
        //        string retorno = string.Empty;

        //        data = valor.ToShortDateString();
        //        hora = valor.ToShortTimeString();
        //        retorno = data.Substring(6, 4) + "-" + data.Substring(3, 2) + "-" + data.Substring(0, 2) + " " + hora;
        //        return retorno;
        //    }

        //public static String ConvData(string data)
        //{
        //    string texto = string.Empty;
        //    string retorno = string.Empty;
        //    if (!String.IsNullOrEmpty(data))
        //    {
        //        texto = data;
        //        retorno = texto.Substring(6, 4) + "-" + texto.Substring(3, 2) + "-" + texto.Substring(0, 2);
        //    }
        //    else
        //        retorno = string.Empty;
        //    return retorno;
        //}

        //    public static String ConvData(string data, Enums.Global.Datas tipo)
        //    {
        //        string retorno = string.Empty;
        //        DateTime dia = Convert.ToDateTime(data);
        //        retorno = dia.ToShortDateString().ToString();
        //        return retorno;
        //    }

        //    public static String Moeda(string valor)
        //    {
        //        string texto = string.Empty;
        //        string retorno = string.Empty;
        //        texto = valor;
        //        retorno = texto.Replace(",", ".");

        //        return retorno;
        //    }

        //    public static String Moeda(string valor, Enums.Global.Formatos formato)
        //    {
        //        string retorno = string.Empty;
        //        if (formato == Enums.Global.Formatos.Padrao)
        //            retorno = String.Format("{0:0.##}", valor);
        //        return retorno;
        //    }

        //    public static String Din(string valor)
        //    {
        //        string moeda = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
        //        return moeda;
        //    }

        //    public static String RetiraAcentuacao(string texto)
        //    {
        //        string retorno = texto;
        //        const string StrComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç'";
        //        const string StrSemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc ";
        //        int i = 0;

        //        foreach (Char c in StrComAcentos)
        //        {
        //            retorno = retorno.Replace(c.ToString().Trim(), StrSemAcentos[i].ToString().Trim());
        //            i++;
        //        }
        //        return retorno;
        //    }

        //    public static string RetirarCaracteres(string palavra)
        //    {
        //        string retorno = string.Empty;
        //        retorno = palavra;

        //        retorno = palavra.Replace(".", "").Replace("-", "").Replace(",", "").Replace("/", "");
        //        return retorno;
        //    }

        //    public static String RetirarMascaras(string palavra)
        //    {
        //        string retorno = string.Empty;
        //        retorno = palavra;
        //        retorno = retorno.Replace(".", "");
        //        retorno = retorno.Replace("-", "");
        //        retorno = retorno.Replace("/", "");
        //        retorno = retorno.Replace(",", "");
        //        retorno = retorno.Replace("(", "");
        //        retorno = retorno.Replace(")", "");
        //        retorno = retorno.Replace(":", "");
        //        retorno = retorno.Replace("_", "");
        //        return retorno;
        //    }

        //    public static string DataExtenso(CoreSDK.Enums.Global.TipoDataExtensa tipo, string local = "")
        //    {
        //        CultureInfo culture = new CultureInfo("pt-BR");
        //        DateTimeFormatInfo dtfi = culture.DateTimeFormat;
        //        string retorno = string.Empty;

        //        int dia = DateTime.Now.Day;
        //        int ano = DateTime.Now.Year;
        //        string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
        //        string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
        //        switch (tipo)
        //        {
        //            case Global.TipoDataExtensa.Local: retorno = local + ", " + dia + " de " + mes + " de " + ano;
        //                break;
        //            case Global.TipoDataExtensa.DiaDaSemana: retorno = diasemana + ", " + dia + " de " + mes + " de " + ano;
        //                break;
        //            case Global.TipoDataExtensa.Dia: retorno = dia + " de " + mes + " de " + ano;
        //                break;
        //            default: retorno = dia + " de " + mes + " de " + ano;
        //                break;
        //        }
        //        return retorno;
        //    }

        //}

    }
}
