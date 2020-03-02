using System;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace CoreFramework.Controles.Controle.Designer
{
    public class MultiViewPageDesigner : ScrollableControlDesigner
    {
        public MultiViewPageDesigner()
        {
        }

        public string Text
        {
            get
            {
                return _page.Text;
            }
            set
            {
                string ot = _page.Text;
                _page.Text = value;
                IComponentChangeService iccs = GetService(typeof(IComponentChangeService)) as IComponentChangeService;
                if (iccs != null)
                {
                    MultiViewExtends ytc = _page.Parent as MultiViewExtends;
                    if (ytc != null)
                        ytc.Refresh();
                }
            }
        }

        protected override void OnPaintAdornments(PaintEventArgs pea)
        {
            base.OnPaintAdornments(pea);

            using (Pen p = new Pen(SystemColors.ControlDark, 1))
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                pea.Graphics.DrawRectangle(p, 0, 0, _page.Width - 1, _page.Height - 1);
            }

            using (Brush b = new SolidBrush(Color.FromArgb(100, Color.Black)))
            {
                float fh = _font.GetHeight(pea.Graphics);
                RectangleF tleft = new RectangleF(0, 0, _page.Width / 2, fh);
                RectangleF bleft = new RectangleF(0, _page.Height - fh, _page.Width / 2, fh);
                RectangleF tright = new RectangleF(_page.Width / 2, 0, _page.Width / 2, fh);
                RectangleF bright = new RectangleF(_page.Width / 2, _page.Height - fh, _page.Width / 2, fh);
                pea.Graphics.DrawString(_page.Text, _font, b, tleft);
                pea.Graphics.DrawString(_page.Text, _font, b, bleft);
                pea.Graphics.DrawString(_page.Text, _font, b, tright, _rightfmt);
                pea.Graphics.DrawString(_page.Text, _font, b, bright, _rightfmt);
            }
        }

        public override void Initialize(IComponent component)
        {
            _page = component as Itens.MultiViewPageItem;
            if (_page == null)
                DisplayError(new Exception("You attempted to use a MultiPanelPageDesigner with a class that does not inherit from MultiPanelPage."));
            base.Initialize(component);
        }

        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);
            properties["Text"] = TypeDescriptor.CreateProperty(typeof(MultiViewPageDesigner), (PropertyDescriptor)properties["Text"], new Attribute[0]);
        }

        #region Constants
        private const int WM_LBUTTONDOWN = 0x0201;

        private const int WM_LBUTTONDBLCLK = 0x0203;
        #endregion

        private Itens.MultiViewPageItem _page;
        private Font _font = new Font("Courier New", 8F, FontStyle.Bold);
        private StringFormat _rightfmt = new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.DirectionRightToLeft);

    }

}
