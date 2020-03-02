using System;
using System.ComponentModel;

namespace CoreFramework.Componentes.Componente
{
    public partial class MenuComponent : Component
    {
        public event EventHandler AoChamar;
        public MenuComponent()
        {
            InitializeComponent();
        }

        public MenuComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Execute(object sender, EventArgs e)
        {
            if (this.AoChamar != null)
            {
                this.AoChamar(this, e);
            }
        }
    }
}
