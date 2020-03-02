using CoreFramework.Controles.Controle.Base;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreFramework.Objetos;

namespace CoreFramework.Controles.Controle
{
    public partial class MemoExtends : DesignControlBase
    {
        private Enums.TipoControle tipoControle = Enums.TipoControle.Edicao;
        private bool obrigatorio = false;
        Label lbl_action = new Label();
        TextBox tbx_action = new TextBox();
        private Enums.TipoCaractere tipoCaractere = Enums.TipoCaractere.Nenhum;

        public MemoExtends()
        {
            //InitializeComponent();
            inicializar();
            atualizar();
        }

        #region propriedades

        //[Browsable(false)]
        //public Enums.TipoControle TipoControle
        //{
        //    get
        //    {
        //        return tipoControle;
        //    }
        //}

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
                return this.lbl_action.Text;
            }

            set
            {
                this.lbl_action.Text = value;
            }
        }

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return this.tbx_action.Size.Width;
            }

            set
            {
                this.tbx_action.Size = new System.Drawing.Size(value, 23);
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
                    this.tbx_action.BackColor = SystemColors.Info;
                    this.lbl_action.ForeColor = SystemColors.HotTrack;
                }
                else
                {
                    this.tbx_action.BackColor = SystemColors.Window;
                    this.lbl_action.ForeColor = SystemColors.ControlText;
                }
            }
        }

        [Category("Custom")]
        [Description("Valor do campo")]
        public String Valor
        {
            get
            {
                return this.tbx_action.Text;
            }
            set { this.tbx_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Tamanho máximo de caracteres")]
        public int ComprimentoMaximo
        {
            get { return this.tbx_action.MaxLength; }
            set { this.tbx_action.MaxLength = value; }
        }

        [Category("Custom")]
        [Description("Tipo de Caractere")]
        public Enums.TipoCaractere TipoCaractere
        {
            get { return tipoCaractere; }
            set
            {
                tipoCaractere = value;
                if (tipoCaractere == Enums.TipoCaractere.Nenhum)
                    tbx_action.CharacterCasing = CharacterCasing.Normal;
                else if (tipoCaractere == Enums.TipoCaractere.Maiuscula)
                    this.tbx_action.CharacterCasing = CharacterCasing.Upper;
                else
                    this.tbx_action.CharacterCasing = CharacterCasing.Lower;
            }
        }

        #endregion

        #region metodos

        private void atualizar()
        {
            tbx_action.Size = new Size(this.TamanhoTexto, this.Size.Height);
        }

        private void inicializar()
        {
            ComprimentoMaximo = 30;

            lbl_action.Text = "Memo Field";
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.AutoSize = true;
            lbl_action.Location = new Point(2, 4);
            lbl_action.Dock = DockStyle.Left;

            tbx_action.Dock = DockStyle.Right;
            tbx_action.Multiline = true;
            tbx_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            tbx_action.Size = new Size(200, this.Size.Height);
            tbx_action.GotFocus += OnFocus;
            tbx_action.LostFocus += OnDefocus;

            this.Size = new Size(300, 85);
            this.Controls.Add(lbl_action);
            this.Controls.Add(tbx_action);
        }

        public void Habilitar(bool status)
        {
            this.tbx_action.Enabled = status;
        }

        #endregion

        #region Eventos

        private void OnFocus(object sender, EventArgs e)
        {
            this.tbx_action.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            if (obrigatorio)
                this.tbx_action.BackColor = SystemColors.Info;
            else
                this.tbx_action.BackColor = SystemColors.Window;
        }

        #endregion        
    }
}
