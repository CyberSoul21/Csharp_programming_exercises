using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ruleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (btnRadio1_18.Checked)
            {
                textResultado.Text = "Apustea 1-18";
            }
            else if (btnRadio_Par.Checked)
            {
                textResultado.Text = "Apuesta Par";
            }
            else if (btnRadio_Impar.Checked)
            {
                textResultado.Text = "Apuesta a los impares";
            }
            else if (btnRadio_19_36.Checked)
            {
                textResultado.Text = "Apuesta 19-36";
            }
            else if (btnRadio_1_12.Checked)
            {
                textResultado.Text = "Apuesta primera docena";
            }
            else if (btnRadio_13_24.Checked)
            {
                textResultado.Text = "Apuesta segunda docena";
            }
            else if (btnRadio_25_36.Checked)
            {
                textResultado.Text = "Apuesta Tercera docena";
            }
        }
    }
}
