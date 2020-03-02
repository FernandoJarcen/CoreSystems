using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CoreFramework.Controles.Controle
{
    public class GradientPanelExtends : Panel
    {
        private LinearGradientBrush gradientBrush;
        private Color corA = Color.SteelBlue;
        private Color colB = Color.LavenderBlush;
        private LinearGradientMode estilo = LinearGradientMode.Vertical;

        public GradientPanelExtends()
        {
            ResizeRedraw = true;
        }

        #region propriedades

        [Category("Custom")]
        [Description("primeira cor do gradiente")]
        public Color CorA
        {
            get
            {
                return corA;
            }
            set
            {
                corA = value;
                gradientBrush = null;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("segunda cor do gradiente")]
        public Color CorB
        {
            get
            {
                return colB;
            }
            set
            {
                colB = value;
                gradientBrush = null;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Estilo do gradiente")]
        public LinearGradientMode Estilo
        {
            get
            {
                return estilo;
            }
            set
            {
                estilo = value;
                gradientBrush = null;
                Invalidate();
            }
        }

        #endregion

        #region metodos

        private LinearGradientBrush GradientBrush
        {
            get
            {
                if (gradientBrush == null)
                {
                    gradientBrush =
                        new LinearGradientBrush(ClientRectangle, corA,
                        colB, estilo);
                }
                return gradientBrush;
            }
        }

        #endregion

        #region eventos

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(GradientBrush, ClientRectangle);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            Invalidate();
        }

        void GradientPanelExtends_Resize(object sender, EventArgs e)
        {
            gradientBrush = null;
            Invalidate();
        }

        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Resize += GradientPanelExtends_Resize;
        }

    }
}
