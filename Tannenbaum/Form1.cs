using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum_mit_Klasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            Tanne t = new Tanne(Convert.ToInt32(textBoxKronenhoehe.Text)
                , Convert.ToInt32(textBoxStammbreite.Text)
                , Convert.ToInt32(textBoxStammhoehe.Text));

            t.Zeichne();
            textBoxOutput.Text = t.Resultat;
        }

        private void textBoxKronenHoehe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
