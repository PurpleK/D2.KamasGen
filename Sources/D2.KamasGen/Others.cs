/// ----------------
/// @Author: PurpleK
/// @Class: Others.cs
/// La classe où les fonctions secondaires résident.
/// ----------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace D2.KamasGen
{
    class Others
    {
        #region AddToLogs

        /// <summary>
        /// Permet d'écrire dans une RichTextBox
        /// </summary>
        /// <param name="Logs">La RichTextBox où écrire</param>
        public static void AddToLogs(KryptonRichTextBox Logs)
        {
            Logs.Text += "\n";
        }

        /// <summary>
        /// Permet d'écrire dans une RichTextBox
        /// </summary>
        /// <param name="Text">Le texte à écrire</param>
        /// <param name="Logs">La RichTextBox où écrire</param>
        public static void AddToLogs(string Text, KryptonRichTextBox Logs)
        {
            Logs.Text += "\n" + Text;
        }

        /// <summary>
        /// Permet d'écrire dans une RichTextBox
        /// </summary>
        /// <param name="Text">Le texte à écrire</param>
        /// <param name="Logs">La RichTextBox où écrire</param>
        /// <param name="Line">Permet de configurer le saut de ligne</param>
        public static void AddToLogs(string Text, KryptonRichTextBox Logs, bool Line)
        {
            if (!Line)
                Logs.Text += Text;
            else
                AddToLogs(Text, Logs);
        }

        /// <summary>
        /// Permet d'écrire dans une RichTextBox
        /// </summary>
        /// <param name="Text">Le texte à écrire</param>
        /// <param name="Clr">Permet de définir la couleur</param>
        /// <param name="Logs">La RichTextBox où écrire</param>
        public static void AddToLogs(string Text, Color Clr,KryptonRichTextBox Logs)
        {            
            Logs.SelectionStart = Logs.TextLength;
            Logs.SelectionLength = 0;
            Logs.SelectionColor = Clr;
            Logs.AppendText("\n" + Text);
            Logs.SelectionColor = Logs.ForeColor;
        }

        /// <summary>
        /// Permet d'écrire dans une RichTextBox
        /// </summary>
        /// <param name="Text">Le texte à écrire</param>
        /// <param name="Clr">Permet de définir la couleur</param>
        /// <param name="Logs">La RichTextBox où écrire</param>
        /// <param name="Line">Permet de configurer le saut de ligne</param>
        public static void AddToLogs(string Text, Color Clr, KryptonRichTextBox Logs, bool Line)
        {
            if (!Line)
            {
                Logs.SelectionStart = Logs.TextLength;
                Logs.SelectionLength = 0;
                Logs.SelectionColor = Clr;
                Logs.AppendText(Text);
                Logs.SelectionColor = Logs.ForeColor;
            }
            else
                AddToLogs(Text, Clr, Logs);
        }

#endregion
    }
}
