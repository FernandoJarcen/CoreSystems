
namespace CoreStudio.Objetos
{
    public class Enums
    {
        public enum EnumCores
        {
            Behance,
            BootstrapPrimary,
            BootstrapSecondary,
            BootstrapSucess,
            BootstrapDanger,
            BootstrapWarning,
            BootstrapInfo,
            BootstrapLight,
            BootstrapDark,
            DropBox,
            FacebookBlue,
            FacebookMedium,
            FacebookLigther,
            FacebookLightest,
            FourSquare,
            GitHub,
            GooglePlusRed,
            GooglePlusDark,
            GooglePlusLight,
            GooglePlusLightTest,
            InstagramRed,
            instagramMaroon,
            InstagramOrange,
            Linkedin,
            Pinterest,
            QuoraBurgundy,
            Reddit,
            RSS,
            SnapChat,
            Spotify,
            TumblrDark,
            TwitterBackground,
            TwitterBlue,
            VimeoGreen,
            VimeoRed,
            VimeoGray,
            VineGreen,
            VK,
            YouTube,
            YouTubeAlmost,
            WhatsZapp,
            White
        }

        public enum EnumEscolhaBooleana
        {
            Sim,
            Não
        }

        public enum EnumEstado
        {
            Comecar,
            Atencao,
            Finalizar
        }

        public enum EnumExportaExcel
        {
            Excel2007,
            Excel2007comCaminho,
            Excel2010,
            Excel2010comCaminho
        }

        public enum EnumGrids
        {
            CaptionGrid,
            CheckGrid,
            GridView,
            SelectGrid,
            SimpleGrid
        }

        public enum EnumGridView
        {
            Linhas = 1,
            Colunas
        }

        public enum EnumImagens
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

        public enum EnumMascaras
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

        public enum EnumMensagem
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

        public enum EnumPosicao
        {
            Horizontal = 0,
            Vertical
        }

        public enum EnumPosicaoPainel
        {
            Topo,             
            Rodape
        }

        public enum EnumProcesso
        {
            Sucesso,
            Erro,
            Atencao,
            Executar
        }

        public enum EnumTipoCaption
        {
            Grande = 0,
            Pequeno
        }

        public enum EnumTipoCaractere
        {
            Nenhum = 0,
            Maiuscula,
            Minúscula
        }

        public enum EnumTipoControle
        {
            Visual,
            Container,
            SuperContainer,
            Edicao,
            Dados
        }

        public enum EnumTipoDatas
        {
            DataLonga = 0,
            DataCurta,
            Hora,
            EspecíficaSefaz
        }

        public enum EnumTipoPainel
        {
            normal,
            grande
        }

        public enum EnumValidacaoCaracteres
        {
            Nenhum = 0,
            Texto,
            Numeros,
            Decimais
        }
    }

}
