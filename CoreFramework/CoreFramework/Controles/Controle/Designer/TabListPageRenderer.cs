﻿using System.Drawing;

namespace CoreFramework.Controles.Controle
{
    public abstract class TabListPageRenderer : ITabListPageRenderer
    {
        #region  Public Class Properties

        public static ITabListPageRenderer DefaultRenderer { get; set; }

        #endregion  Public Class Properties

        #region  Public Abstract Methods

        public abstract void RenderHeader(Graphics g, TabListPageExtends page, TabListPageState state);

        #endregion  Public Abstract Methods
    }
}
