using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStudio.Objetos
{
        [System.AttributeUsage(System.AttributeTargets.Class |
        System.AttributeTargets.Property)]
    public class Author: System.Attribute
    {
        private string name;
        private string data;
        private string versao;

        public Author(string pName, string pData = "", string pVersao = "1.0")
        {
            this.name = pName;
            this.data = Convert.ToString(DateTime.Now.Date);
            this.versao = pVersao;
        }
    }
}
