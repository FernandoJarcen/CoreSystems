using System;
using System.ComponentModel;
using System.IO;
using CoreSDK.Utils;
using CoreSDK.Enums;
using System.Configuration;
using CoreFramework.Objetos;

namespace CoreFramework.Componentes.Componente
{
    [Author("Fernando","10/06/2018","1.0")]
    public partial class ConnectionComponent : Component
    {
        bool conectar = false;

        public ConnectionComponent()
        {
            InitializeComponent();
        }

        public ConnectionComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Category("Custom")]
        [Description("ativar o controle")]
        public bool Conectado
        {
            get { return conectar; }
            set
            {
                conectar = value;
                if (conectar)                
                    configuracaoPadrao();
            }
        }

        private void configuracaoPadrao()
        {
            string caminho = ConfigurationManager.AppSettings.Get("Padrao");
            string id = ConfigurationManager.AppSettings.Get("ID");
            string log = @"c:\Sistematica\Log\log.txt";

            try
            {
                Util.Parametros[CoreSDK.Enums.Prm.CaminhoPadrao] = String.IsNullOrEmpty(caminho) ? "c:\\\\sistematica\\\\CFG\\\\mcapl.xml" : caminho;
                Util.Parametros[Prm.CodigoInstancia] = Xml.BuscaCodigoInstancia();
                Util.Parametros[Prm.Banco] = Xml.BuscaAtributo(Util.Parametros[Prm.CodigoInstancia].ToString(), "banco");
                Util.Parametros[Prm.TipoAutenticacao] = Xml.BuscaAtributo(Util.Parametros[Prm.CodigoInstancia].ToString(), "autenticacao");
                Util.Parametros[Prm.Servico] = Xml.BuscaAtributo(Util.Parametros[Prm.CodigoInstancia].ToString(), "datasource");
            }
            catch (System.Exception ex)
            {
                if (System.IO.File.Exists(log))
                {
                    try
                    {
                        System.IO.File.Delete(log);
                        using (StreamWriter writer = new StreamWriter(log, true))
                        {
                            writer.WriteLine(ex.Message);
                        }
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
                else
                    using (StreamWriter writer = new StreamWriter(log, true))
                    {
                        writer.WriteLine(ex.Message);
                    }
            }
        }
    }
}
