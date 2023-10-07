using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compito_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string classe = "";

        private void butfaitut_Click(object sender, EventArgs e)
        {
            if (int.Parse(textHost.Text) <= 255)
            {
                classe = "Classe C";
            }
            else if (int.Parse(textHost.Text) <= Math.Pow(2,16))
            {
                classe = "Classe B";
            }
            else if (int.Parse(textHost.Text) <= Math.Pow(2, 24))
            {
                classe = "Classe A";
            }
            else if (int.Parse(textHost.Text) > Math.Pow(2, 24))
            {
                classe = "Troppi Host Bro";
            }
            textclasse.Text = classe;
        }
    }
}
