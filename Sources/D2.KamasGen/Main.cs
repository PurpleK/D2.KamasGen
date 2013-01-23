/// ----------------
/// @Author: PurpleK
/// @Class: Main.cs
/// La Fenêtre principale où tout va être géré
/// ----------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace D2.KamasGen
{
    // Pour l'apparence de la fenêtre
    public partial class Main : KryptonForm
    {
        // La méthode principale
        public Main()
        {
            InitializeComponent();
        }

        // Quand la fenêtre se lance
        private void Main_Load(object sender, EventArgs e)
        {
            RbCredit.Checked = true; // On règle la valeur du bouton banque sur vrai
        }
    }
}
