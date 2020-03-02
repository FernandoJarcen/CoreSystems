
namespace CoreSDK.Enums
{
    public class Operadores
    {
        public enum ConditionOperator
        {
            Igual,
            Diferente,
            Maior,
            MaiorIgual,
            Menor,
            MenorIgual,
            Entre,
            ENulo
        }

        public enum OrderByOperator
        {
            Nenhum = 0,
            Ascendente = 1,
            Descendente = 2
        }

        public enum QueryOperator
        {
            E,
            Ou,
            Not,
            IN,
            NotIn
        }
    }
}
