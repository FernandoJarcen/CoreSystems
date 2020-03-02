using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CoreFramework.Controles.Controle.Base
{
    public class ChooseControlBase : DesignControlBase
    {
        [Category("Custom")]
        [Description("Valor Padrão")]
        public bool ValorPadrao { get; set; }

    }    
}
