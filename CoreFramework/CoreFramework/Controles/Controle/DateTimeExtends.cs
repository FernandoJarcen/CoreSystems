using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class DateTimeExtends : DesignControlBase
    {
        public event EventHandler AoAlterarTexto;
        Label lbl_action = new Label();
        DateTimePicker dtp_action = new DateTimePicker();
        private bool obrigatorio = false;
        Enums.TipoDatas tipoData = Enums.TipoDatas.DataCurta;
        private Enums.Posicao posicao = Enums.Posicao.Horizontal;
        private Point localizacao;
        private bool padrao = false;

        public DateTimeExtends()
        {
            inicializar();
            this.Size = new Size(150, 23);
            base.InicializarTipo(Enums.TipoControle.Edicao);
            atualizar();
        }

        #region Propriedades

        [Category("Custom")]
        [Description("Tamanho do controle")]
        public int Tamanho
        {
            get
            {
                return this.Width;
            }

            set
            {
                this.Width = value;
            }
        }

        [Category("Custom")]
        [Description("Texto da label")]
        public String Titulo
        {
            get
            {
                return lbl_action.Text;
            }

            set
            {
                lbl_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Valor do texto")]
        public string Valor
        {
            get
            {
                return dtp_action.Text;
            }
            set
            {
                if (value != " ")
                    dtp_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return dtp_action.Size.Width;
            }

            set
            {
                dtp_action.Size = new System.Drawing.Size(value, 25);
            }
        }

        [Category("Custom")]
        [Description("Verifica se o campo é obrigatorio")]
        public bool Obrigatorio
        {
            get { return obrigatorio; }
            set
            {
                obrigatorio = value;
                if (obrigatorio)
                {
                    this.dtp_action.BackColor = SystemColors.Info;
                    this.lbl_action.ForeColor = SystemColors.HotTrack;
                    this.lbl_action.Text += "*";
                }
                else
                {
                    this.dtp_action.BackColor = SystemColors.Window;
                    this.lbl_action.ForeColor = SystemColors.ControlText;
                    this.lbl_action.Text = lbl_action.Text.Replace("*", "");
                }
            }
        }

        [Category("Custom")]
        [Description("Verifica o formato do campo")]
        public Enums.TipoDatas Formato
        {
            get { return tipoData; }
            set
            {
                tipoData = value;
                if (tipoData == Enums.TipoDatas.DataCurta)
                    dtp_action.Format = DateTimePickerFormat.Short;
                else if (tipoData == Enums.TipoDatas.DataLonga)
                    dtp_action.Format = DateTimePickerFormat.Long;
                else if (tipoData == Enums.TipoDatas.Hora)
                    dtp_action.Format = DateTimePickerFormat.Time;
                else if (tipoData == Enums.TipoDatas.EspecíficaSefaz)
                {
                    dtp_action.Format = DateTimePickerFormat.Custom;
                    dtp_action.CustomFormat = "yyyy-MM-ddThh:mm:ss";
                }
            }
        }

        [Category("Custom")]
        [Description("Posição do titulo do controle")]
        public Enums.Posicao Posicao
        {
            get { return posicao; }
            set
            {
                posicao = value;
                if (posicao == Enums.Posicao.Vertical)
                {
                    this.dtp_action.Dock = DockStyle.Bottom;
                    localizacao = new Point(this.dtp_action.Location.X, this.dtp_action.Location.Y);
                    //this.Size = new Size(this.Size.Width - this.lbl_action.Size.Width, this.Size.Height + 22);
                    this.Size = new Size(this.Size.Width, this.Size.Height + 22);
                    Point pt = new Point(1, this.dtp_action.Location.Y + 22);
                    this.dtp_action.Location = pt;
                }
                else
                {
                    this.dtp_action.Dock = DockStyle.Right;
                    this.dtp_action.Location = localizacao;
                    //this.Size = new Size(this.Size.Width + this.lbl_action.Size.Width, this.Size.Height - 22);
                    this.Size = new Size(this.Size.Width, this.Size.Height - 22);
                }
            }
        }

        [Category("Custom")]
        [Description("Configura Padrão")]
        public bool Padrao
        {
            get { return padrao; }
            set { 
                padrao = value; 
                inserirPadrao(); 
            }
        }

        #endregion

        #region Metodos

        private void inicializar()
        {
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.Text = "Date";
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 1);

            dtp_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            dtp_action.Dock = DockStyle.Right;
            dtp_action.Format = DateTimePickerFormat.Custom;
            dtp_action.CustomFormat = " ";
            dtp_action.Width = 100;
            dtp_action.GotFocus += OnFocus;
            dtp_action.LostFocus += OnDefocus;
            dtp_action.ValueChanged += dtp_action_ValueChanged;
            //if (valorPadrao)
            //{
            //    DateTime hoje = DateTime.Now;
            //    dtp_action.Value = Convert.ToDateTime(hoje.ToShortDateString());
            //}
            this.Controls.Add(lbl_action);
            this.Controls.Add(dtp_action);
            localizacao = new Point(this.dtp_action.Location.X, this.dtp_action.Location.Y);
        }

        private void dtp_action_ValueChanged(object sender, EventArgs e)
        {
            this.dtp_action.Format = DateTimePickerFormat.Short;
            if (this.AoAlterarTexto != null)
            {
                this.AoAlterarTexto(this, e);
            }
        }

        public void Limpar()
        {
            this.dtp_action.Format = DateTimePickerFormat.Custom;
            this.dtp_action.CustomFormat = " ";
        }
        private void atualizar()
        {
            dtp_action.Size = new Size(this.TamanhoTexto, 23);
        }

        private void OnFocus(object sender, EventArgs e)
        {
            this.dtp_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.dtp_action.BackColor = SystemColors.Info;
            else
                this.dtp_action.BackColor = SystemColors.Window;
        }

        public void Habilitar(bool status)
        {
            this.dtp_action.Enabled = status;
        }
        
        private void inserirPadrao()
        {
            if (padrao)
            {
                DateTime data = DateTime.Now;
                dtp_action.Value = Convert.ToDateTime(data.ToShortDateString());
            }
        }

        #endregion

        #region Eventos

        private void lbl_action_Resize(object sender, EventArgs e)
        {
            dtp_action.Location = new Point(lbl_action.PreferredWidth + 10);
        }

        #endregion
    }
}
