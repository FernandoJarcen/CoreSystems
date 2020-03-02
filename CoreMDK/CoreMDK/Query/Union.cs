using CoreSDK.Enums;

namespace CoreMDK.Query
{
    public class Union
    {
        public Operadores.QueryOperator Unario { get; set; }
        public Union(Operadores.QueryOperator p_unario)
        {
            Unario = p_unario;
        }
    }
}
