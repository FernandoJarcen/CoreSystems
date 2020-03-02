using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreExtension.Controles.Controle
{
    public class FieldExtends:UserControl
    {
        TextBoxExtends tbx_action;
        Label lbl_action;
        Color corTexto = Color.Maroon;
        public FieldExtends()
        {
            InitializeComponent();
        }

        #region Propriedades

        [Category("Custom")]
        [Description("Tamanho de texto")]
        public int TamanhoTexto
        {
            get
            {
                return tbx_action.Size.Width;
            }

            set
            {
                tbx_action.Size = new System.Drawing.Size(value, 23);
            }
        }

        [Category("Custom")]
        [Description("Tamanho do Título")]
        public int TamanhoTitulo
        {
            get { return lbl_action.Size.Width; }
            set { lbl_action.Size = new System.Drawing.Size(value, 23); }
        }

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
        public Color CorTitulo
        {
            get { return corTexto; }
            set { 
                corTexto = value;
                lbl_action.ForeColor = corTexto;
            }
        }

        #endregion
        private void InitializeComponent()
        {
            this.lbl_action = new System.Windows.Forms.Label();
            this.tbx_action = new CoreExtension.Controles.Controle.TextBoxExtends();
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
