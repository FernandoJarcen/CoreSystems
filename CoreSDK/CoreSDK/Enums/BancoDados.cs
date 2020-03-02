
namespace CoreSDK.Enums
{
    public class BancoDados
    {
        public enum TipoBaseDados
        {
            SqlServer,
            Oracle,
            MySQL,
            Firebird
        }

        public enum TipoDados
        {
            Nenhum = -1,
            Booleano,
            Real,
            Data,
            Hora,
            DataHora,
            Texto,
            TextoLongo,
            Caracter,
            Longo,
            Inteiro,
            Imagem,
            Moeda,
            Duplo
        }

        public enum TipoAutenticacao
        {
            Banco = 0,
            AD
        }
    }
}
