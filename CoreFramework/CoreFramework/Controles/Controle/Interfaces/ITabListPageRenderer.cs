using System.Drawing;

namespace CoreFramework.Controles.Controle
{
    public interface ITabListPageRenderer
    {
        #region  Private Methods

        void RenderHeader(Graphics g, TabListPageExtends page, TabListPageState state);

        #endregion  Private Methods

    }
}
