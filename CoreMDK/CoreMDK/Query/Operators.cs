using CoreSDK.Enums;
using System.ComponentModel;

namespace CoreMDK.Query
{
    public class Operators
    {
        private Operadores.QueryOperator operador;

        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Operadores.QueryOperator Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public Operators(Operadores.QueryOperator pOperador)
        {
            this.operador = pOperador;
        }
    }
}
