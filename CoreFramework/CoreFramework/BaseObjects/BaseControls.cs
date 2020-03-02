using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CoreFramework.BaseObjects
{
    public static class BaseControls
    {
        public static List<Control> RetornarEditaveis(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => RetornarEditaveis(ctrl))
                                      .Concat(controls)
                                      .Where(c => ObterTipoControle(c) == "Edicao").ToList();
        }

        public static List<Control> RetornarControles(Control control, string tipo)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => RetornarControles(ctrl,tipo))
                                      .Concat(controls)
                                      .Where(c => ObterTipoControle(c) == tipo).ToList();
        }

        public static string ObterTipoControle(Control obj)
        {
            string retorno = string.Empty;
            Type Tipo = obj.GetType();
            PropertyInfo[] props = Tipo.GetProperties();
            PropertyInfo opcao = props.FirstOrDefault(x => x.Name == "TipoControle");

            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    if (prop.Name == "TipoControle")
                    {
                        retorno = prop.GetValue(obj).ToString();
                        break;
                    }

            if (opcao != null)
            {
                if (opcao.GetIndexParameters().Length == 0)
                    retorno = opcao.GetValue(obj).ToString();
            }
            else retorno = string.Empty;
            return retorno;
        }

    }
}
