using CoreFramework.Controles.Controle.Base;
using System.ComponentModel;
using CoreFramework.Objetos;
using CoreFramework.Properties;

namespace CoreFramework.Controles.Controle
{
    public partial class ItemStatusExtends : DesignControlBase
    {
        Enums.Mensagem status = Enums.Mensagem.Executar;

        public ItemStatusExtends()
        {
            InitializeComponent();
        }

        #region Propriedades

        [Category("Custom")]
        [Description("Mensagem do controle")]
        public string Mensagem
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Status do processo")]
        public Enums.Mensagem Status
        {
            get { return status; }
            set
            {
                status = value;
                switch (status)
                {
                    case Enums.Mensagem.Executar:
                        pct_action.Image = Resources.executar;
                        break;
                    case Enums.Mensagem.Executado:
                        pct_action.Image = Resources.executado; break;
                    case Enums.Mensagem.Erro:
                        pct_action.Image = Resources.erros; break;
                    case Enums.Mensagem.Erro_Execucao:
                        pct_action.Image = Resources.erro_execucao; break;
                    case Enums.Mensagem.Informacao:
                        pct_action.Image = Resources.informacao; break;
                    case Enums.Mensagem.Nao_Executado:
                        pct_action.Image = Resources.nao_executado; break;
                    case Enums.Mensagem.Pronto:
                        pct_action.Image = Resources.pronto; break;
                    case Enums.Mensagem.Tarefa:
                        pct_action.Image = Resources.tarefa; break;
                    default:
                        pct_action.Image = Resources.executar; break;
                }
            }
        }

        [Category("Custom")]
        [Description("Cor da mensagem")]
        public System.Drawing.Color Cor
        {
            get { return lbl_action.ForeColor; }
            set { lbl_action.ForeColor = value; }
        }

        #endregion
    }
}
