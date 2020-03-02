using CoreStudio.Controles.Base;
using CoreStudio.Controles.Controle.Expandable;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreStudio.Controles.Controle
{
    public partial class FieldExtends : DesignControlBase
    {
        CoreStudio.Controles.Base.TextBoxBase tbx_action;
        Label lbl_action;
        Color _corTexto = Color.Maroon;
        private FieldExpandable _fieldSize;

        public FieldExtends()
        {
            InitializeComponent();
        }

        #region Propriedades


        [Category("Custom")]
        [Description("Configura o texto da marca dagua")]
        public string MarcaDagua
        {
            get { return tbx_action.MarcaDagua; }
            set
            {
                tbx_action.MarcaDagua = value;
            }
        }

        [Category("Custom")]
        [Description("Valor padrão")]
        public string Valor
        {
            get { return tbx_action.Text; }
            set { tbx_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor quando focado")]
        public Color FocusColor
        {
            get { return tbx_action.FocusColor; }
            set { tbx_action.FocusColor = value; }
        }

        [Category("Custom")]
        [Description("Titulo do Campo")]
        public string Titulo
        {
            get { return lbl_action.Text; }
            set { lbl_action.Text = value; }
        }

        [Category("Custom")]
        [Description("Cor do Titulo")]
        public Color CorTitulo
        {
            get { return _corTexto; }
            set
            {
                _corTexto = value;
                lbl_action.ForeColor = _corTexto;
            }
        }

        [Category("Custom")]
        [Description("Campo Obrigatório?")]
        public bool CampoObrigatorio
        {
            get { return base.RetornarObrigatorio(); }
            set
            {
                base.VerificarObrigatorio(lbl_action, value);
            }
        }

        [
        Browsable(true),
        Category("Custom"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        ]
        public FieldExpandable Controle
        {
            get
            {
                if (_fieldSize == null)
                {
                    _fieldSize = new FieldExpandable(lbl_action,tbx_action);
                }

                return _fieldSize;
            }
        }

        #endregion
        private void InitializeComponent()
        {
            this.lbl_action = new System.Windows.Forms.Label();
            this.tbx_action = new CoreStudio.Controles.Base.TextBoxBase();
            this.SuspendLayout();
            // 
            // lbl_action
            // 
            this.lbl_action.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_action.Location = new System.Drawing.Point(0, 0);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(40, 23);
            this.lbl_action.TabIndex = 0;
            this.lbl_action.Text = "Field";
            this.lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_action
            // 
            this.tbx_action.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbx_action.FocusColor = System.Drawing.Color.Empty;
            this.tbx_action.Location = new System.Drawing.Point(90, 0);
            this.tbx_action.MarcaDagua = "";
            this.tbx_action.Name = "tbx_action";
            this.tbx_action.Padding = new System.Windows.Forms.Padding(1);
            this.tbx_action.Size = new System.Drawing.Size(210, 23);
            this.tbx_action.TabIndex = 1;
            this.tbx_action.TamanhoTexto = 308;
            this.tbx_action.Valor = "";
            // 
            // FieldExtends
            // 
            this.Controls.Add(this.lbl_action);
            this.Controls.Add(this.tbx_action);
            this.Name = "FieldExtends";
            this.Size = new System.Drawing.Size(300, 23);
            this.ResumeLayout(false);

        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            tbx_action.FocusColor = Color.Red;
        }
    }
}
