using CoreSDK.Enums;
using CoreSDK.Utils;
using CoreSDK.Objetos;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace CoreCustom.Customizacao
{
    [Descricao("Classe de customização de módulos","02/08/2019")]
    public class Sistema
    {
        RibbonControl controle;
        public Sistema() { }
        public Sistema(RibbonControl pControle)
        {
            controle = pControle;
        }

        public void BuscaCustomizacao(RibbonControl pControle)
        {
            string caminho = Xml.BuscaTAG("customizacao", Util.Parametros[Prm.CaminhoPadrao].ToString());
            RibbonTabItem[] tbiItem;
            RibbonBar[] barItem;
            XmlDocument documento = new XmlDocument();

            controle = pControle;
            documento.Load(caminho);

            List<string> area = new List<string>();
            List<ModuloCustom> modulo = new List<ModuloCustom>();
            List<RotinaCustom> rotina = new List<RotinaCustom>();

            XmlNodeList elem1 = documento.GetElementsByTagName("Area");
            for (int indice1 = 0; indice1 < elem1.Count; indice1++)
            {
                area.Add(elem1[indice1].Attributes["value"].Value);

                XmlNodeList elem2 = documento.GetElementsByTagName("Modulo");
                for (int indice2 = 0; indice2 < elem2.Count; indice2++)
                {
                    if (area[indice1] == elem2[indice2].ParentNode.Attributes[0].Value)
                    {
                        modulo.Add(new ModuloCustom(area[indice1].ToString(), elem2[indice2].Attributes["value"].Value));

                        XmlNodeList elem3 = elem2[indice2].ChildNodes;
                        for (int indice3 = 0; indice3 < elem3.Count; indice3++)
                        {
                            if (elem3[indice3].Attributes["formulario"] == null)
                                rotina.Add(new RotinaCustom(modulo[indice2].aplicacao, modulo[indice2].modulo, elem3[indice3].Attributes["value"].Value, elem3[indice3].Attributes["icone"].Value));
                            else
                                rotina.Add(new RotinaCustom(modulo[indice2].aplicacao, modulo[indice2].modulo, elem3[indice3].Attributes["value"].Value, elem3[indice3].Attributes["icone"].Value, elem3[indice3].Attributes["formulario"].Value));
                        }
                    }
                }
            }

            tbiItem = new RibbonTabItem[] { };
            for (int indice = 0; indice < area.Count; indice++)
            {
                Aplicacao(area[indice]);
            }

            List<ButtonItem> item = new List<ButtonItem>();

            barItem = new RibbonBar[] { };
            for (int indice2 = 0; indice2 < modulo.Count; indice2++)
            {
                if (item.Count > 0)
                    item.Clear();
                item = listarItens(modulo[indice2].modulo, CustomAction.ActionForms.SemAcao, rotina);
                Modulo(modulo[indice2].modulo, modulo[indice2].aplicacao, item);
            };
        }

        public RibbonTabItem Aplicacao(string nome)
        {
            RibbonTabItem tabItem = new RibbonTabItem();
            RibbonPanel painel = new RibbonPanel();
            tabItem.Name = "rtb_" + nome;
            tabItem.Text = nome;
            tabItem.Visible = true;
            controle.Items.AddRange(new BaseItem[] { tabItem });
            painel = criarPanelItem(nome);
            tabItem.Panel = painel;
            return tabItem;
        }

        public RibbonBar Modulo(string nomeModulo, string aplicacao, List<ButtonItem> botoes)
        {
            DevComponents.DotNetBar.RibbonBar bar = new RibbonBar();
            bar.AutoOverflowEnabled = true;
            bar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            bar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            bar.ContainerControlProcessDialogKey = true;
            bar.Dock = System.Windows.Forms.DockStyle.Left;
            bar.DragDropSupport = true;

            for (int indice = 0; indice < botoes.Count; indice++)
            {
                bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { botoes[indice] });
            }
            bar.Location = new System.Drawing.Point(3, 0);
            bar.Name = "rba_" + nomeModulo;
            bar.Size = new System.Drawing.Size(714, 103);
            bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            bar.Text = nomeModulo;
            bar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            bar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            bar.Visible = true;

            int indiceAplicacao = 0;
            for (int indice = 0; indice < controle.Items.Count; indice++)
            {
                if (controle.Items[indice].Name == "rtb_" + aplicacao)
                {
                    indiceAplicacao = indice;
                    break;
                }
            }

            RibbonTabItem app = new RibbonTabItem();
            RibbonPanel panel = new RibbonPanel();
            app = (RibbonTabItem)controle.Items[indiceAplicacao];
            panel = app.Panel;
            panel.Controls.Add(bar);
            return bar;
        }

        public ButtonItem Rotina(string nome, string icone, CustomAction.ActionForms custom, string formulario = "")
        {
            DevComponents.DotNetBar.ButtonItem button = new ButtonItem();
            button.FixedSize = new System.Drawing.Size(100, 80);
            button.GlobalName = nome;
            button.Image = buscarImagem(icone);
            button.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            button.Name = "rbt_" + nome;
            button.SubItemsExpandWidth = 14;
            button.Text = nome;
            button.Visible = true;
            button.Tag = nome.ToLower();
            if (!string.IsNullOrEmpty(formulario))
                button.Click += (sender, EventArgs) => { button_Click(sender, EventArgs, custom,formulario); };
            else
                button.Click += (sender, EventArgs) => { button_Click(sender, EventArgs); };
            return button;
        }

        private List<ButtonItem> listarItens(string nome, CustomAction.ActionForms custom, List<RotinaCustom> rotinas)
        {
            List<ButtonItem> itens = new List<ButtonItem>();
            List<RotinaCustom> lista = rotinas.Where(x => x.modulo.Equals(nome)).ToList();

            for (int indice = 0; indice < lista.Count; indice++)
            {
                itens.Add(Rotina(lista[indice].nome,lista[indice].icone,custom,lista[indice].formulario));
            }

            return itens;
        }

        private Image buscarImagem(string nomeImagem)
        {
            String caminhoImagens = ((string[])(Util.Parametros[Prm.CaminhoCustomizacao]))[1];
            string[] arquivos = Directory.GetFiles(caminhoImagens, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".png")
                || s.EndsWith(".gif")
                || s.EndsWith(".jpg")
                || s.EndsWith(".jpeg")).ToArray();

            string valor = arquivos.Where(x => x.Contains(nomeImagem)).First();

            Image Imagem = Image.FromFile(valor);
            return Imagem;
        }

        private RibbonPanel criarPanelItem(string nomePanel)
        {
            RibbonPanel pnlItem = new RibbonPanel();
            pnlItem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            pnlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlItem.Location = new System.Drawing.Point(0, 25);
            pnlItem.Name = "rpn_" + nomePanel;
            pnlItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            pnlItem.Size = new System.Drawing.Size(1156, 106);
            pnlItem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            pnlItem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            pnlItem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            pnlItem.Visible = true;
            controle.Controls.Add(pnlItem);
            return pnlItem;
        }

        private void button_Click(object sender, EventArgs e, CoreSDK.Enums.CustomAction.ActionForms custom = CustomAction.ActionForms.SemAcao, string parametro = "")
        {
            string retorno = Util.Parametros[Prm.CaminhoExecutavel].ToString();
            string acao = custom.ToString();

            if (custom == CustomAction.ActionForms.SemAcao)
            {
                retorno += @"sistematica." + sender.ToString().ToLower() + ".exe";
                if (System.IO.File.Exists(retorno))
                {
                    MessageBox.Show(parametro);
                    Process.Start(retorno);
                }
                else
                    MessageBox.Show("Não foi possível encontrar o caminho solicitado!");
            }
        }
        
    }
}
