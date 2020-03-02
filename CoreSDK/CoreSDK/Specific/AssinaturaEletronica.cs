using CoreSDK.Objetos;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace CoreSDK.Specific
{
    [Descricao("Assinatura eletronica", "08/03/2019")]
    public class AssinaturaEletronica
    {
        public string AssinarNFe(string caminho, string certificado, string senha)
        {
            string retorno = string.Empty;
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = false;

            try
            {
                doc.Load(caminho);
                SignedXml signedXml;
                XmlNodeList ListInfNFe = doc.GetElementsByTagName("infNFe");
                X509Certificate2 xCert;
                xCert = new X509Certificate2(certificado, senha);

                foreach (XmlElement infNFe in ListInfNFe)
                {

                    string id = infNFe.Attributes.GetNamedItem("Id").InnerText;
                    signedXml = new SignedXml(infNFe);
                    signedXml.SigningKey = xCert.PrivateKey;

                    Reference reference = new Reference("#" + id);
                    reference.AddTransform(new XmlDsigEnvelopedSignatureTransform());
                    reference.AddTransform(new XmlDsigC14NTransform());
                    signedXml.AddReference(reference);

                    KeyInfo keyInfo = new KeyInfo();
                    keyInfo.AddClause(new KeyInfoX509Data(xCert));

                    signedXml.KeyInfo = keyInfo;

                    signedXml.ComputeSignature();

                    XmlElement xmlSignature = doc.CreateElement("Signature", "http://www.w3.org/2000/09/xmldsig#");
                    XmlElement xmlSignedInfo = signedXml.SignedInfo.GetXml();
                    XmlElement xmlKeyInfo = signedXml.KeyInfo.GetXml();

                    XmlElement xmlSignatureValue = doc.CreateElement("SignatureValue", xmlSignature.NamespaceURI);
                    string signBase64 = Convert.ToBase64String(signedXml.Signature.SignatureValue);
                    XmlText text = doc.CreateTextNode(signBase64);
                    xmlSignatureValue.AppendChild(text);

                    xmlSignature.AppendChild(doc.ImportNode(xmlSignedInfo, true));
                    xmlSignature.AppendChild(xmlSignatureValue);
                    xmlSignature.AppendChild(doc.ImportNode(xmlKeyInfo, true));

                    var evento = doc.GetElementsByTagName("NFe");
                    evento[0].AppendChild(xmlSignature);
                }
                doc.PreserveWhitespace = true;
                doc.Save(caminho);
                retorno = "arquivo assinado com sucesso!";
                return retorno;
            }
            catch (Exception e)
            {
                retorno = e.Message;
                return retorno;
            }
        }
    }
}
