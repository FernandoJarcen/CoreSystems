using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSDK.ODB.Domain
{
    [AttributeUsage(AttributeTargets.All)]
    public class Mapa : Attribute
    {
        private string myName;
        public Mapa(string name)
        {
            myName = name;
        }
        public string Name
        {
            get
            {
                return myName;
            }
        }
    }
}
