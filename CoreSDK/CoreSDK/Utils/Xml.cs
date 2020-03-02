/* VERSÃO OFICIAL - 13/11/2017 */
/* NOVA VERSAO 2.0 - CRYPTOGRAFIA - 08-08-2018 */

using CoreSDK.Objetos;
using CoreSDK.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;

namespace CoreSDK.Utils
{
    [Descricao("Criptografia xml", "08/03/2019")]
    public static class Xml
    {
        private static XmlDocument xmlDoc;
        private static CspParameters cspParams;
        private static RSACryptoServiceProvider rsaKey;
        private static string caminhoPadrao = @"c:\sistematica\CFG\mcapl.xml";

        #region propriedades privadas

        private static void inicializarParametros(string caminho)
        {
            if (xmlDoc == null)
                xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.Load(caminho);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                LOG.Escrever("InicializarParametros", ex.Message);
            }

            cspParams = new CspParameters();
            cspParams.KeyContainerName = "XML_ENC_RSA_KEY";

            rsaKey = new RSACryptoServiceProvider(cspParams);
        }

        private static Enums.Arquivos.Criptografia verificarCriptografado(XmlDocument Doc, string ElementToEncrypt)
        {
            Enums.Arquivos.Criptografia modoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;
            XmlElement elementToEncrypt = Doc.GetElementsByTagName(ElementToEncrypt)[0] as XmlElement;

            if (elementToEncrypt == null)
                modoArquivo = Enums.Arquivos.Criptografia.Criptografado;
            else
                modoArquivo = Enums.Arquivos.Criptografia.Descriptografado;
            return modoArquivo;
        }

        private static bool validarEncriptacao(XmlDocument Doc, string elementToEncrypt, string EncryptionElementID, RSA Alg, string KeyName)
        {
            bool retorno = false;
            if (Doc != null)
                if (elementToEncrypt != null)
                    if (EncryptionElementID != null)
                        if (Alg != null)
                            if (KeyName != null)
                                retorno = true;
            return retorno;
        }

        private static bool validarDecriptacao(XmlDocument Doc, RSA Alg, string KeyName)
        {
            bool retorno = false;
            if (Doc != null)
                if (Alg != null)
                    if (KeyName != null)
                        retorno = true;
            return retorno;
        }

        private static Enums.Arquivos.Criptografia Encrypt(XmlDocument Doc, string elementToEncrypt, string EncryptionElementID, RSA Alg, string KeyName)
        {
            Enums.Arquivos.Criptografia retorno = Enums.Arquivos.Criptografia.NaoDefinido;

            if (validarEncriptacao(Doc, elementToEncrypt, EncryptionElementID, Alg, KeyName))
            {
                XmlElement element = Doc.GetElementsByTagName(elementToEncrypt)[0] as XmlElement;
                retorno = verificarCriptografado(Doc, elementToEncrypt);

                if (retorno == Enums.Arquivos.Criptografia.Descriptografado)
                {
                    RijndaelManaged sessionKey = null;

                    try
                    {
                        sessionKey = new RijndaelManaged();
                        sessionKey.KeySize = 256;

                        EncryptedXml eXml = new EncryptedXml();

                        byte[] encryptedElement = eXml.EncryptData(element, sessionKey, false);

                        EncryptedData edElement = new EncryptedData();
                        edElement.Type = EncryptedXml.XmlEncElementUrl;
                        edElement.Id = EncryptionElementID;
                        edElement.EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncAES256Url);

                        EncryptedKey ek = new EncryptedKey();
                        byte[] encryptedKey = EncryptedXml.EncryptKey(sessionKey.Key, Alg, false);
                        ek.CipherData = new CipherData(encryptedKey);
                        ek.EncryptionMethod = new EncryptionMethod(EncryptedXml.XmlEncRSA15Url);

                        DataReference dRef = new DataReference();
                        dRef.Uri = "#" + EncryptionElementID;
                        ek.AddReference(dRef);
                        edElement.KeyInfo.AddClause(new KeyInfoEncryptedKey(ek));

                        KeyInfoName kin = new KeyInfoName();
                        kin.Value = KeyName;
                        ek.KeyInfo.AddClause(kin);
                        edElement.CipherData.CipherValue = encryptedElement;
                        EncryptedXml.ReplaceElement(element, edElement, false);
                        retorno = Enums.Arquivos.Criptografia.Criptografado;
                    }
                    catch (Exception ex)
                    {
                        LOG.Escrever("Encrypt", ex.Message);
                    }
                    finally
                    {
                        if (sessionKey != null)
                            sessionKey.Clear();
                    }
                }
            }
            else
            {
                retorno = Enums.Arquivos.Criptografia.NaoDefinido;
                LOG.Escrever("Encrypt", "Parametros faltantes");
            }
            return retorno;
        }

        private static Enums.Arquivos.Criptografia Decrypt(XmlDocument Doc, RSA Alg, string KeyName)
        {
            Enums.Arquivos.Criptografia retorno = Enums.Arquivos.Criptografia.NaoDefinido;

            if (validarDecriptacao(Doc, Alg, KeyName))
            {
                EncryptedXml exml = new EncryptedXml(Doc);
                exml.AddKeyNameMapping(KeyName, Alg);
                exml.DecryptDocument();
                retorno = Enums.Arquivos.Criptografia.Descriptografado;
            }
            else
            {
                LOG.Escrever("Decrypt", "Parametros faltantes");
                retorno = Enums.Arquivos.Criptografia.NaoDefinido;
            }
            return retorno;
        }

        private static string retornaXml(string caminho, String busca)
        {
            String retorno = string.Empty;
            int qtd = 0;

            try
            {
                if (!string.IsNullOrEmpty(caminho))
                {
                    XElement root = XElement.Load(caminho);
                    IEnumerable<string> textSegs =
                        from seg in root.Descendants(busca)
                        select (string)seg;
                    qtd = textSegs.Count();

                    retorno = qtd > 0 ? textSegs.FirstOrDefault() : "";
                }
                else
                    retorno = null;
            }
            catch (Exception ex)
            {
                Msg.Exclamation(ex.Message, System.Windows.Forms.MessageBoxButtons.OK);
                retorno = null;
            }

            return retorno;
        }

        private static string retornaAtributos(string caminho, String node, String atributo)
        {
            string retorno = string.Empty;

            try
            {

                XmlDocument xmlDocument = new XmlDocument();
                if (!string.IsNullOrEmpty(caminho))
                {
                    xmlDocument.Load(caminho);
                    XmlNodeList lista = xmlDocument.GetElementsByTagName(node);
                    retorno = lista.Item(0).Attributes[atributo].Value;
                }
                else
                    retorno = null;
            }
            catch (Exception)
            {
                retorno = null;
            }

            return retorno;
        }


        #endregion

        #region propriedades publicas

        public static void Criptografar(string caminho)
        {
            inicializarParametros(caminho);

            try
            {
                if (xmlDoc == null)
                    xmlDoc.Load(caminho);
                string rootPrincipal = xmlDoc.DocumentElement.Name.ToString();

                Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;
                tipoArquivo = Encrypt(xmlDoc, rootPrincipal, "EncryptedElement1", rsaKey, "rsaKey");
                if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    xmlDoc.Save(caminho);
            }
            catch (Exception ex)
            {
                LOG.Escrever("Criptografar", ex.Message);
            }
            finally
            {
                rsaKey.Clear();
            }
        }

        public static void Criptografar(string caminho, string tagPrincipal)
        {
            inicializarParametros(caminho);

            try
            {
                Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;
                tipoArquivo = Encrypt(xmlDoc, tagPrincipal, "EncryptedElement1", rsaKey, "rsaKey");
                if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    xmlDoc.Save(caminho);
            }
            catch (Exception ex)
            {
                LOG.Escrever("Criptografar", ex.Message);
            }
            finally
            {
                rsaKey.Clear();
            }
        }

        public static void Descriptografar(string caminho)
        {
            inicializarParametros(caminho);

            try
            {
                Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;
                tipoArquivo = Decrypt(xmlDoc, rsaKey, "rsaKey");
                if (tipoArquivo == Enums.Arquivos.Criptografia.Descriptografado)
                    xmlDoc.Save(caminho);
            }
            catch (Exception ex)
            {
                LOG.Escrever("Descriptografar", ex.Message);
            }
            finally
            {
                rsaKey.Clear();
            }
        }

        public static string BuscaTAG(string busca)
        {
            string retorno = string.Empty;
            string rootPrincipal = string.Empty;
            string pArquivo = string.Empty;
            Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;

            try
            {
                if (System.IO.File.Exists(caminhoPadrao))
                {
                    if (xmlDoc == null)
                        xmlDoc = new XmlDocument();
                    xmlDoc.Load(caminhoPadrao);
                    tipoArquivo = verificarCriptografado(xmlDoc, busca);
                    if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    {
                        Descriptografar(caminhoPadrao);
                        xmlDoc.Load(caminhoPadrao);
                        tipoArquivo = verificarCriptografado(xmlDoc, busca);
                        rootPrincipal = xmlDoc.DocumentElement.Name.ToString();
                        retorno = retornaXml(caminhoPadrao, busca);
                        Criptografar(caminhoPadrao, rootPrincipal);
                    }
                    else
                    {
                        rootPrincipal = xmlDoc.DocumentElement.Name.ToString();
                        retorno = retornaXml(caminhoPadrao, busca);
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("BuscaXML", ex.Message);
            }
            return retorno;
        }

        public static string BuscaTAG(string caminho, string busca)
        {
            string retorno = string.Empty;
            string rootPrincipal = string.Empty;
            Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;

            try
            {
                if (System.IO.File.Exists(caminho))
                {
                    if (xmlDoc == null)
                        xmlDoc = new XmlDocument();
                    xmlDoc.Load(caminho);
                    tipoArquivo = verificarCriptografado(xmlDoc, busca);
                    if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    {
                        Descriptografar(caminho);
                        xmlDoc.Load(caminho);
                        tipoArquivo = verificarCriptografado(xmlDoc, busca);
                        rootPrincipal = xmlDoc.DocumentElement.Name.ToString();
                        retorno = retornaXml(caminho, busca);
                        Criptografar(caminho, rootPrincipal);
                    }
                    else
                    {
                        rootPrincipal = xmlDoc.DocumentElement.Name.ToString();
                        retorno = retornaXml(caminho, busca);
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("BuscaXML", ex.Message);
            }
            return retorno;
        }

        public static string BuscaAtributo(string busca, string atributo)
        {
            string retorno = string.Empty;
            string rootPrincipal = string.Empty;
            Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;

            try
            {
                if (System.IO.File.Exists(caminhoPadrao))
                {
                    if (xmlDoc == null)
                        xmlDoc = new XmlDocument();
                    xmlDoc.Load(caminhoPadrao);
                    tipoArquivo = verificarCriptografado(xmlDoc, busca);
                    if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    {
                        Descriptografar(caminhoPadrao);
                        xmlDoc.Load(caminhoPadrao);
                        tipoArquivo = verificarCriptografado(xmlDoc, busca);
                        rootPrincipal = xmlDoc.DocumentElement.Name.ToString();
                        retorno = retornaAtributos(caminhoPadrao, busca, atributo);
                        Criptografar(caminhoPadrao, rootPrincipal);
                    }
                    else
                    {
                        retorno = retornaAtributos(caminhoPadrao, busca, atributo);
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("BuscaXML", ex.Message);
            }
            return retorno;
        }

        public static string BuscaAtributo(string caminho, string busca, string atributo)
        {
            string retorno = string.Empty;
            string rootPrincipal = string.Empty;
            Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;

            try
            {
                if (System.IO.File.Exists(caminho))
                {
                    if (xmlDoc == null)
                        xmlDoc = new XmlDocument();
                    xmlDoc.Load(caminho);
                    tipoArquivo = verificarCriptografado(xmlDoc, busca);
                    if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    {
                        Descriptografar(caminho);
                        xmlDoc.Load(caminho);
                        tipoArquivo = verificarCriptografado(xmlDoc, busca);
                        rootPrincipal = xmlDoc.DocumentElement.Name.ToString();
                        retorno = retornaAtributos(caminho, busca, atributo);
                        Criptografar(caminho, rootPrincipal);
                    }
                    else
                    {
                        retorno = retornaAtributos(caminho, busca, atributo);
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("BuscaXML", ex.Message);
            }
            return retorno;

        }
        
        public static List<string> BuscaListaTAGS(string caminho, string busca)
        {
            List<string> retorno = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                if (!String.IsNullOrEmpty(caminho))
                {
                    xmlDoc.Load(caminho);
                    XmlNodeList node = xmlDoc.GetElementsByTagName(busca);
                    for (int linha = 0; linha < node.Item(0).ChildNodes.Count; linha++)
                    {
                        string nome = node.Item(0).ChildNodes[linha].Name;
                        retorno.Add(nome);
                    }
                }
                else
                    retorno = null;
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }

        public static List<string> BuscaListaAtributos(string caminho, string busca)
        {
            List<string> retorno = new List<string>();

            try
            {
                if (!string.IsNullOrEmpty(caminho))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(caminho);
                    XmlNodeList node = xmlDoc.GetElementsByTagName(busca);
                    for (int linha = 0; linha < node.Item(0).Attributes.Count; linha++)
                    {
                        string nome = node.Item(0).Attributes[linha].Value;
                        retorno.Add(nome);
                    }
                }
                else
                    retorno = null;
            }
            catch (Exception)
            {
                retorno = null;
            }
            return retorno;
        }

        public static Dictionary<string, object> BuscaDictionaryAtributos(string caminho, string busca)
        {
            Dictionary<string, object> retorno = new Dictionary<string, object>();
            try
            {
                if (!string.IsNullOrEmpty(caminho))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(caminho);
                    XmlNodeList node = xmlDoc.GetElementsByTagName(busca);
                    for (int linha = 0; linha < node.Item(0).Attributes.Count; linha++)
                    {
                        string nome = node.Item(0).Attributes[linha].Name;
                        string valor = node.Item(0).Attributes[linha].Value;
                        retorno.Add(nome, valor);
                    }
                }
                else
                    retorno = null;
            }
            catch (Exception)
            {
                retorno = null;
            }

            return retorno;
        }

        public static bool VerificarCriptografia(string caminho)
        {
            bool retorno = false;
            XmlDocument Doc = new XmlDocument();

            if (System.IO.File.Exists(caminho))
            {
                Doc.Load(caminho);
                var elementos = Doc.SelectNodes("//*");

                for (int indice = 0; indice < elementos.Count; indice++)
                {
                    var element = elementos[indice];
                    if (element.Name == "EncryptedData")
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            else
                retorno = false;
            return retorno;
        }
        #endregion

        #region propriedades especificas

        public static string BuscaCodigoInstancia()
        {
            string retorno = BuscaTAG(caminhoPadrao, "instancia");
            return retorno;
        }

        public static string BuscaNomeInstancia(int codigo)
        {
            String retorno = string.Empty;
            Enums.Arquivos.Criptografia tipoArquivo = Enums.Arquivos.Criptografia.NaoDefinido;

            try
            {
                if (System.IO.File.Exists(caminhoPadrao))
                {
                    if (xmlDoc == null)
                        xmlDoc = new XmlDocument();

                    xmlDoc.Load(caminhoPadrao);

                    tipoArquivo = verificarCriptografado(xmlDoc, "GlobalDefinitions");
                    if (tipoArquivo == Enums.Arquivos.Criptografia.Criptografado)
                    {
                        Descriptografar(caminhoPadrao);

                        XmlNodeList node = xmlDoc.GetElementsByTagName("conectividade");
                        for (int linha = 0; linha < node.Item(0).ChildNodes.Count; linha++)
                        {
                            if (node.Item(0).ChildNodes[linha].Attributes != null)
                            {
                                int codigoBusca = Convert.ToInt16(node.Item(0).ChildNodes[linha].Attributes["id"].Value);
                                if (codigoBusca == codigo)
                                {
                                    retorno = node.Item(0).ChildNodes[linha].Name;
                                    break;
                                }
                            }
                        }

                        Criptografar(caminhoPadrao);
                    }
                    else
                    {
                        XmlNodeList node = xmlDoc.GetElementsByTagName("conectividade");
                        for (int linha = 0; linha < node.Item(0).ChildNodes.Count; linha++)
                        {
                            if (node.Item(0).ChildNodes[linha].Attributes != null)
                            {
                                int codigoBusca = Convert.ToInt16(node.Item(0).ChildNodes[linha].Attributes["id"].Value);
                                if (codigoBusca == codigo)
                                {
                                    retorno = node.Item(0).ChildNodes[linha].Name;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Escrever("BuscaNomeInstancia", ex.Message);
                Criptografar(caminhoPadrao);
            }
            return retorno;
        }

        #endregion
    }
}
