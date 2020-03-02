using CoreFramework.Controles.Controle.Designer;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    [Designer(typeof(PanelDesigner))]
    public class PanelExtends:Panel
    {
        private CoreFramework.Objetos.Enums.TipoControle tipoControle = Enums.TipoControle.Container;
        Panel pnl_cabecalho = new Panel();
        Label lbl_texto = new Label();
        Enums.PosicaoPainel posicao = Enums.PosicaoPainel.Topo;
        bool borda = true;
        bool centralizar = false;
        Enums.TipoPainel tipoPainel = Enums.TipoPainel.normal;
        Color cor = System.Drawing.Color.SteelBlue;

        #region propriedades

        [Browsable(true)]
        public CoreFramework.Objetos.Enums.TipoControle TipoControle
        {
            get
            {
                return tipoControle;
            }
        }

        [Category("Custom")]
        [Description("Texto do cabecalho do controle")]
        public string Cabecalho
        {
            get
            {
                return lbl_texto.Text;
            }
            set
            {
                lbl_texto.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Posição do cabecalho do controle")]
        public Enums.PosicaoPainel Posicao
        {
            get { return posicao; }
            set
            {
                posicao = value;
                if (posicao == Enums.PosicaoPainel.Topo)
                {
                    pnl_cabecalho.Dock = DockStyle.Top;
                }
                else pnl_cabecalho.Dock = DockStyle.Bottom;
            }
        }

        [Category("Custom")]
        [Description("visibilidade da borda")]
        public bool MostrarBorda
        {
            get { return borda; }
            set
            {
                borda = value;
                if (borda)
                    this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                else
                    this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        [Category("Custom")]
        [Description("centralizar texto")]
        public bool Centralizar
        {
            get { return centralizar; }
            set
            {
                centralizar = value;
                if (centralizar)
                {
                    lbl_texto.Dock = DockStyle.Fill;
                    lbl_texto.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    lbl_texto.Dock = DockStyle.Left;
                    lbl_texto.TextAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        [Category("Custom")]
        [Description("altura do painel")]
        public int Altura
        {
            get { return pnl_cabecalho.Height; }
            set { pnl_cabecalho.Height = value; }
        }

        [Category("Custom")]
        [Description("cor do painel")]
        public System.Drawing.Color Cor
        {
            get { return pnl_cabecalho.BackColor; }
            set
            {
                cor = value;
                pnl_cabecalho.BackColor = cor;
            }
        }

        [Category("Custom")]
        [Description("Modo de apresentacao do painél")]
        public Enums.TipoPainel TipoPainel
        {
            get { return tipoPainel; }
            set
            {
                tipoPainel = value;
                if (tipoPainel == Enums.TipoPainel.normal)
                {
                    pnl_cabecalho.Height = 25;
                    lbl_texto.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                }
                else
                {
                    pnl_cabecalho.Height = 50;
                    lbl_texto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
                }
            }
        }

        #endregion

        #region metodos

        private void inicializar()
        {
            this.TipoPainel = tipoPainel;
            pnl_cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_cabecalho.BackColor = cor;
            base.BackColor = Color.White;

            pnl_cabecalho.Controls.Add(lbl_texto);
            lbl_texto.ForeColor = Color.White;
            lbl_texto.AutoSize = false;
            lbl_texto.Width = 500;
            base.Controls.Add(pnl_cabecalho);
            base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            inicializar();
        }
    }
}
