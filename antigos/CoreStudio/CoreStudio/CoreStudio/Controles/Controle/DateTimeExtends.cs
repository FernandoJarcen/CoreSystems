using CoreStudio.Controles.Base;
using CoreStudio.Controles.Controle.Expandable;
using CoreStudio.Objetos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreStudio.Controles.Controle
{
    public class DateTimeExtends : DesignControlBase
    {
        Label lbl_action = new Label();
        DateTimeBase ctr_action = new DateTimeBase();
        private FieldExpandable _fieldSize;
        public event EventHandler AoAlterarTexto;

        public DateTimeExtends()
        {
            InitializeComponent();
            //inicializar();
            this.Size = new Size(300, 23);
            base.InicializaControle(this.lbl_action);
            base.VerificarObrigatorio(this, this.Obrigatorio);
            //base.InicializarTipo(Enums.TipoControle.Edicao);
            //atualizar();
        }

        private void InitializeComponent()
        {
            lbl_action.Text = "Date";
            lbl_action.Dock = DockStyle.Left;
            lbl_action.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            lbl_action.ForeColor = System.Drawing.Color.Maroon;
            lbl_action.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            ctr_action.Dock = System.Windows.Forms.DockStyle.Right;
            ctr_action.ValueChanged += ctr_action_ValueChanged;

            this.Controls.Add(lbl_action);
            this.Controls.Add(ctr_action);
        }

        #region propriedades

        [Category("Custom")]
        public string Titulo
        {
            get { return lbl_action.Text; }
            set
            {
                lbl_action.Text = value;
                Invalidate();
            }
        }
        [Category("Custom")]
        public Color BorderColor
        {
            get { return ctr_action.BorderColor; }
            set
            {
                ctr_action.BorderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Category("Custom")]
        [Description("Valor do texto")]
        public string Valor
        {
            get
            {
                return ctr_action.Valor;
            }
            set
            {
                if (ctr_action.Valor != " ")
                    ctr_action.Valor = value;
            }
        }

        [Category("Custom")]
        public bool Habilitado
        {
            get { return ctr_action.Habilitado; }
            set { ctr_action.Habilitado = value; }
        }

        [
        Browsable(true),
        Category("Custom"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)
        ]
        public FieldExpandable Controle
        {
            get
            {
                if (_fieldSize == null)
                {
                    _fieldSize = new FieldExpandable(lbl_action, ctr_action);
                }

                return _fieldSize;
            }
        }

        [Category("Custom")]
        public Enums.EnumTipoDatas Formato
        {
            get { return ctr_action.Formato; }
            set
            {
                ctr_action.Formato = value;
            }
        }

        #endregion

        #region metodos

        public void DataCorrente()
        {
            ctr_action.DataCorrente();
        }

        #endregion

        #region eventos

        private void ctr_action_ValueChanged(object sender, EventArgs e)
        {
            if (this.AoAlterarTexto != null)
            {
                this.AoAlterarTexto(this, e);
            }
        }

        #endregion
    }
}
