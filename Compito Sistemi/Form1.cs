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

        private void butfaitut_Click(object sender, EventArgs e)
        {
           string classe = "";
           string basepriv = "";
           int CIDRUltimoOttetto = 0;
           int[] Sottoreti = new int[int.Parse(textSot.Text)];
           textclasse.Text = Funzioni.TrovaClasse(textHost.Text, textSot.Text);
           BasePrivtext.Text = Funzioni.TrovaBasePriv(textclasse.Text);
           subnettext.Text = Funzioni.TrovaSubnet(textclasse.Text, textSot.Text, ref CIDRUltimoOttetto);
           CIDRtext.Text = Funzioni.TrovaCIDR(textclasse.Text, textSot.Text, ref CIDRUltimoOttetto);
           Funzioni.TrovaRete(textclasse.Text, textSot.Text, ref CIDRUltimoOttetto, ref Sottoreti);
        }
    }
}
