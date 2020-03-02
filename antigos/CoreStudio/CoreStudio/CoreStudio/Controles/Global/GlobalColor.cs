using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreStudio.Objetos;

namespace CoreStudio.Controles.Global
{
    public static class GlobalColor
    {
        public static Color Cor(Enums.EnumCores cor)
        {
            Color retorno = SystemColors.ActiveBorder;
            switch (cor)
            {
                case Enums.EnumCores.Behance: retorno = Color.FromArgb(23, 105, 255); break;
                case Enums.EnumCores.BootstrapPrimary: retorno = Color.FromArgb(2, 117, 216); break;
                case Enums.EnumCores.BootstrapSecondary: retorno = Color.FromArgb(66, 90, 112); break;
                case Enums.EnumCores.BootstrapSucess: retorno = Color.FromArgb(92, 184, 92); break;
                case Enums.EnumCores.BootstrapDanger: retorno = Color.FromArgb(217, 83, 79); break;
                case Enums.EnumCores.BootstrapWarning: retorno = Color.FromArgb(240, 173, 78); break;
                case Enums.EnumCores.BootstrapInfo: retorno = Color.FromArgb(91, 192, 222); break;
                case Enums.EnumCores.BootstrapLight: retorno = Color.FromArgb(247, 247, 247); break;
                case Enums.EnumCores.BootstrapDark: retorno = Color.FromArgb(41, 43, 44); break;
                case Enums.EnumCores.DropBox: retorno = Color.FromArgb(0, 126, 229); break;
                case Enums.EnumCores.FacebookBlue: retorno = Color.FromArgb(59, 89, 152); break;
                case Enums.EnumCores.FacebookMedium: retorno = Color.FromArgb(109, 132, 180); break;
                case Enums.EnumCores.FacebookLigther: retorno = Color.FromArgb(175, 189, 212); break;
                case Enums.EnumCores.FacebookLightest: retorno = Color.FromArgb(216, 223, 234); break;
                case Enums.EnumCores.FourSquare: retorno = Color.FromArgb(0, 114, 177); break;
                case Enums.EnumCores.GitHub: retorno = Color.FromArgb(0, 0, 0); break;
                case Enums.EnumCores.GooglePlusRed: retorno = Color.FromArgb(221, 75, 57); break;
                case Enums.EnumCores.GooglePlusDark: retorno = Color.FromArgb(45, 45, 45); break;
                case Enums.EnumCores.GooglePlusLight: retorno = Color.FromArgb(210, 210, 210); break;
                case Enums.EnumCores.GooglePlusLightTest: retorno = Color.FromArgb(241, 241, 241); break;
                case Enums.EnumCores.InstagramRed: retorno = Color.FromArgb(188, 42, 141); break;
                case Enums.EnumCores.instagramMaroon: retorno = Color.FromArgb(205, 72, 107); break;
                case Enums.EnumCores.InstagramOrange: retorno = Color.FromArgb(251, 173, 80); break;
                case Enums.EnumCores.Linkedin: retorno = Color.FromArgb(0, 123, 181); break;
                case Enums.EnumCores.Pinterest: retorno = Color.FromArgb(203, 32, 39); break;
                case Enums.EnumCores.QuoraBurgundy: retorno = Color.FromArgb(168, 36, 0); break;
                case Enums.EnumCores.Reddit: retorno = Color.FromArgb(255, 69, 0); break;
                case Enums.EnumCores.RSS: retorno = Color.FromArgb(255, 102, 0); break;
                case Enums.EnumCores.SnapChat: retorno = Color.FromArgb(255, 252, 0); break;
                case Enums.EnumCores.Spotify: retorno = Color.FromArgb(0, 228, 97); break;
                case Enums.EnumCores.TumblrDark: retorno = Color.FromArgb(50, 80, 109); break;
                case Enums.EnumCores.TwitterBlue: retorno = Color.FromArgb(85, 172, 238); break;
                case Enums.EnumCores.TwitterBackground: retorno = Color.FromArgb(192, 222, 237); break;
                case Enums.EnumCores.VimeoGreen: retorno = Color.FromArgb(170, 212, 80); break;
                case Enums.EnumCores.VimeoRed: retorno = Color.FromArgb(252, 87, 94); break;
                case Enums.EnumCores.VimeoGray: retorno = Color.FromArgb(153, 170, 187); break;
                case Enums.EnumCores.VineGreen: retorno = Color.FromArgb(0, 191, 143); break;
                case Enums.EnumCores.VK: retorno = Color.FromArgb(69, 102, 142); break;
                case Enums.EnumCores.YouTube: retorno = Color.FromArgb(255, 0, 0); break;
                case Enums.EnumCores.YouTubeAlmost: retorno = Color.FromArgb(40, 40, 40); break;
                case Enums.EnumCores.WhatsZapp: retorno = Color.FromArgb(77, 194, 71); break;
                case Enums.EnumCores.White: retorno = Color.FromArgb(249, 249, 251); break;
                default: break;
            }
            return retorno;
        }

    }
}
