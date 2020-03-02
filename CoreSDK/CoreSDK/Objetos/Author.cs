using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.Objetos
{
    [System.AttributeUsage(System.AttributeTargets.Field |
        System.AttributeTargets.Property)
    ]
    public class Funcionalidade : System.Attribute
    {
        private string name;
        private string data;

        public Funcionalidade(string name, string data = "")
        {
            this.name = name;
            this.data = Convert.ToString(DateTime.Now.Date);
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class Descricao: System.Attribute
    {
        private string name;
        private string data;
        
        public Descricao(string name, string data = "")
        {
            this.name = name;
            this.data = Convert.ToString(DateTime.Now.Date);
        }
    }
}

