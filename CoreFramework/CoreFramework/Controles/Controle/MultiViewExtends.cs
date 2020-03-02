using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CoreFramework.Controles.Controle
{
    [ToolboxBitmap(typeof(MultiViewExtends), "MultiView")]
    [Designer(typeof(CoreFramework.Controles.Controle.Designer.MultiViewDesigner))]
    public class MultiViewExtends : Panel
    {
        private bool borda = true;
        private Itens.MultiViewPageItem _selectedPage;

        #region propriedades

        [Category("Custom")]
        [Description("mostra borda")]
        public bool Borda
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

        #endregion

        #region metodos

        private void visualizar_borda(bool borda)
        {
            if (borda)
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            else
                this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        public Itens.MultiViewPageItem SelectedPage
        {
            get { return _selectedPage; }
            set
            {
                _selectedPage = value;
                if (_selectedPage != null)
                {
                    foreach (Control child in Controls)
                    {
                        if (object.ReferenceEquals(child, _selectedPage))
                            child.Visible = true;
                        else
                            child.Visible = false;
                    }
                }
            }
        }

        #endregion

        #region eventos

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            using (SolidBrush br = new SolidBrush(BackColor))
                g.FillRectangle(br, ClientRectangle);
        }

        protected override ControlCollection CreateControlsInstance()
        {
            return new Collection.MultiViewPageCollection(this);
        }
        
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            visualizar_borda(borda);
        }

        #endregion
    }
}
