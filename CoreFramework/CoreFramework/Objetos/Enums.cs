
namespace CoreFramework.Objetos
{
    public class Enums
    {
        public enum EscolhaBooleana
        {
            Sim,
            Não
        }

        public enum Estado
        {
            Comecar,
            Atencao,
            Finalizar
        }

        public enum ExportaExcel
        {
            Excel2007,
            Excel2007comCaminho,
            Excel2010,
            Excel2010comCaminho
        }
        
        public enum Grids
        {
            CaptionGrid,
            CheckGrid,
            GridView,
            SelectGrid,
            SimpleGrid
        }

        public enum GridView
        {
            Linhas = 1,
            Colunas
        }

        public enum Imagens
        {
            acrescimo,
            carregar,
            checado,
            deschecado,
            fechar,
            erros,
            executar,
            executado,
            informacao,
            naoexecutado,
            pronto
        }

        public enum Mascaras
        {
            Nulo,
            CEP,
            CPF,
            CNPJ,
            RG,
            Tel,
            TelDDD,
            TelDDDLongo,
            Celular,
            CelularDDD,
            CelularDDDLongo,
            DataLonga,
            Data,
            Hora
        }

        public enum Mensagem
        {
            Executar = 0,
            Executado,
            Erro,
            Erro_Execucao,
            Informacao,
            Nao_Executado,
            Pronto,
            Tarefa
        }

        public enum Posicao
        {
            Horizontal = 0,
            Vertical
        }

        public enum PosicaoPainel
        {
            Topo,             
            Rodape
        }

        public enum Processo
        {
            Sucesso,
            Erro,
            Atencao,
            Executar
        }

        public enum TipoCaption
        {
            Grande = 0,
            Pequeno
        }

        public enum TipoCaractere
        {
            Nenhum = 0,
            Maiuscula,
            Minúscula
        }
        
        public enum TipoControle
        {
            Acao,            // item que iterage com alguma acao 
            Menu,            // item que contem outro subitem
            Visual,          // item meramente visual
            Container,       // item que contem outro
            SuperContainer,  // item que contem outros containeres
            SubItem,         // item pertence a outro item
            Edicao,          // item de inserção de dados
            Dados            // item de agrupamento de dados 
        }

        public enum TipoDatas
        {
            DataLonga = 0,
            DataCurta,
            Hora,
            EspecíficaSefaz
        }

        public enum TipoPainel
        {
            normal,
            grande
        }

        public enum ValidacaoCaracteres
        {
            Nenhum = 0,
            Texto,
            Numeros,
            Decimais
        }
    }

}
