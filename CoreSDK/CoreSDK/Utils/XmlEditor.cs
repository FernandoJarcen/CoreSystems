/* VERSÃO OFICIAL - 08/03/2019 */

using CoreSDK.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace CoreSDK.Utils
{
    [Descricao("Edicao de xml", "08/03/2019")]
    public class XmlEditor : CustomDispose
    {
        public XmlDocument root { get; set; }
        public string caminho { get; set; }
        public XmlEditor(string caminhoPadrao)
        {
            root = new XmlDocument();
            root.Load(caminhoPadrao);
            caminho = caminhoPadrao;
        }

        public string AlteraTAG(String busca, string valor)
        {
            String retorno = string.Empty;
            try
            {
                if (!String.IsNullOrEmpty(busca))
                {
                    XmlNodeList e = root.GetElementsByTagName(busca);
                    if (e.Count > 0)
                    {
                        e[0].InnerText = valor;
                        root.Save(caminho);
                        retorno = "Alterado com sucesso!";
                    }
                }
                else
                    retorno = "Falta Parâmetros!";
            }
            catch (Exception ex)
            {
                Msg.Exclamation(ex.Message, System.Windows.Forms.MessageBoxButtons.OK);
                retorno = "Erro no processo, " + ex.Message;
            }
            return retorno;
        }

        public string AlteraAtributo(string tag, string atributo, string valor)
        {
            string retorno = string.Empty;
            try
            {
                if ((!String.IsNullOrEmpty(tag)) && (!String.IsNullOrEmpty(atributo) && (!String.IsNullOrEmpty(valor))))
                {
                    XmlNodeList e = root.GetElementsByTagName(tag);
                    if (e.Count > 0)
                    {
                        e[0].Attributes[atributo].InnerText = valor;
                        root.Save(caminho);
                        retorno = "Alterado com sucesso!";
                    }
                }
                else
                    retorno = "Falta Parâmetros!";

            }
            catch (Exception ex)
            {
                Msg.Exclamation(ex.Message, System.Windows.Forms.MessageBoxButtons.OK); 
                retorno = "Erro no processo, " + ex.Message;
            }
            return retorno;
        }

        public string AdicionarTAG(string busca, string tag, Dictionary<string, string> atributos)
        {
            string retorno = string.Empty;
            try
            {
                if ((!String.IsNullOrEmpty(busca)) && (!String.IsNullOrEmpty(tag)))
                {
                    XDocument doc = XDocument.Load(caminho);
                    if (atributos.Count > 0)
                    {
                        XElement elm = new XElement(tag);

                        foreach (KeyValuePair<string, string> entry in atributos)
                        {
                            string att = entry.Key.Replace(" ", "");
                            XAttribute attribute = new XAttribute(att, entry.Value);
                            elm.Add(attribute);
                        }
                        doc.Descendants(busca).First().Add(elm);

                        doc.Save(caminho);
                        retorno = "Alterado com sucesso!";
                    }
                    else
                        retorno = "Atributos não encontrados";
                }
                else
                    retorno = "Falta Parâmetros";
            }
            catch (Exception ex)
            {
                Msg.Exclamation(ex.Message, System.Windows.Forms.MessageBoxButtons.OK);
                retorno = "Erro no processo, " + ex.Message;
            }
            return retorno; 
        }

        public string AdicionarTAG(string busca, string tag, string valor)
        {
            string retorno = string.Empty;
            XDocument doc = XDocument.Load(caminho);
            try
            {
                if ((!string.IsNullOrEmpty(busca)) && (!string.IsNullOrEmpty(tag)) && (!string.IsNullOrEmpty(valor)))
                {
                    XElement newElement2 = new XElement(tag, valor);
                    doc.Descendants(busca).First().Add(newElement2);

                    doc.Save(caminho);
                }
                else
                    retorno = "Falta Parâmetros!";
            }
            catch (Exception ex)
            {
                Msg.Exclamation(ex.Message, System.Windows.Forms.MessageBoxButtons.OK);
                retorno = "Erro no processo, " + ex.Message;
            }
            return retorno;
        }

    }
}
