using CoreSDK.Enums;


namespace CoreMDK.Query
{
    public class Order
    {
        public string Campo { get; set; }
        public Operadores.OrderByOperator OrderBy { get; set; }

        public Order(string p_campo, Operadores.OrderByOperator p_orderby = Operadores.OrderByOperator.Nenhum)
        {
            Campo = p_campo;
            if (p_orderby != Operadores.OrderByOperator.Nenhum)
                OrderBy = p_orderby;
        }
    }
}
