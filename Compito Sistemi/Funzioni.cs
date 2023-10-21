using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Compito_Sistemi
{
    public class Funzioni
    {
        public static string TrovaClasse(string Host, string Subnet)
        {
            string classe= "";
            if (Math.Log(int.Parse(Host) + 2, 2) +Math.Log(int.Parse(Subnet),2) <= 8)
            {
                classe = "Classe C";
            }
            else if (Math.Log(int.Parse(Host) + 2, 2) + Math.Log(int.Parse(Subnet), 2) <= 16)
            {
                classe = "Classe B";
            }
            else if (Math.Log(int.Parse(Host) + 2, 2) + Math.Log(int.Parse(Subnet), 2) <= 24)
            {
                classe = "Classe A";
            }
            else if (Math.Log(int.Parse(Host) + 2, 2) + Math.Log(int.Parse(Subnet), 2) > 24)
            {
                classe = "Troppi host e sottoreti bro";
            }
            return classe;
        }

        public static string TrovaBasePriv(string classe)
        {
            string Basepriv = "";
            if (classe == "Classe A")
            {
                Basepriv = "10.0.0.0";
            }
            else if (classe == "Classe B")
            {
                Basepriv = "172.16.0.0";
            }
            else if (classe == "Classe C")
            {
                Basepriv = "192.168.0.0";
            }
            return Basepriv;
        }
    }

}
