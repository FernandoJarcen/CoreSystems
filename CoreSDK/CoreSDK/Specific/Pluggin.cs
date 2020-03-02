using CoreSDK.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Specific
{
    public struct pluggin
    {
        public int CodigoFilial;        
        public string NomeFilial;
        public int CodigoUsuario;
        public string NomeUsuario;
        public int CodigoInstancia;
        public string Modulo;
        public string NomeCompleto;
        public string NomeFisico;
        public PlugginStatus Valida;

        public pluggin(string modulo, string nomeFisico, PlugginStatus valida)
        {
            CodigoFilial = 0;
            NomeFilial = string.Empty;
            CodigoUsuario = 0;
            NomeUsuario = string.Empty;
            CodigoInstancia = 0;
            Modulo = modulo;
            NomeCompleto = "Módulo " + modulo;
            NomeFisico = nomeFisico;
            Valida = valida;
        }
    }
}
