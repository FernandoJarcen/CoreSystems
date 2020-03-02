using CoreSDK.Enums;

namespace CoreMDK.Query
{
    public class Condition
    {
        private string _nome;
        private Operadores.ConditionOperator _operador;
        private object _valor1;
        private object _valor2;
        public Condition()
        {
            
        }

        public Condition(string nome, Operadores.ConditionOperator operador, object valor1 = null, object valor2 = null)
        {
            _nome = nome;
            _operador = operador;
            if (valor1 != null)
                _valor1 = valor1;
            if (valor2 != null)
                _valor2 = valor2;
        }

        public object Valor1
        {
            get { return _valor1; }
        }

        public object Valor2
        {
            get { return _valor2; }
        }

        public string Nome
        {
            get { return _nome; }
        }

        public Operadores.ConditionOperator Operador
        {
            get { return _operador; }
        }
        //public Condition(string p_nome, Operadores.ConditionOperator p_operador, object p_valor1 = null, object p_valor2 = null)
        //{
        //    Nome = p_nome;
        //    Operador = p_operador;
        //    if (p_valor1 != null)
        //        Valor1 = p_valor1;
        //    if (p_valor2 != null)
        //        Valor2 = p_valor2;
        //}
    }
}
