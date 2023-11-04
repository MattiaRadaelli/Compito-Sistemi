using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public static string TrovaSubnet(string classe, string Subnet, ref int CIDRULtOttet)
        {
            int classesub = 0;
            double subnetsub = 0;
            int potenza = 7;        
            string subnet = "";
            if (classe == "Classe A")
            {
                classesub = 1;
            }
            else if (classe == "Classe B")
            {
                classesub = 2;
            }
            else if (classe == "Classe C")
            {
                classesub = 3;
            }           
            for (double i = Math.Log(int.Parse(Subnet), 2); i > 0; i-- )
            {
                subnetsub += Math.Pow(2, potenza);
                potenza--;
                CIDRULtOttet++;
                if (subnetsub == 255)
                {
                    classesub++;
                    subnetsub = 0;
                    CIDRULtOttet = 0;
                    potenza = 7;

                }
            }
            if (classesub == 1)
            {
                subnet = "255." + subnetsub + ".0.0";
            }
            else if (classesub == 2)
            {
                subnet = "255.255." + subnetsub + ".0";
            }
            else if (classesub == 3)
            {
                subnet = "255.255.255." + subnetsub;
            }
            else if (classesub == 4)
            {
                subnet = "255.255.255.255";
            }
            return subnet;
        }

        public static string TrovaCIDR(string classe, string Subnet, ref int CIDRULtOttet)
        {
            double CIDR = 0;
            if (classe == "Classe A")
            {
                CIDR = 8;
            }
            else if (classe == "Classe B")
            {
                CIDR = 16;
            }
            else if (classe == "Classe C")
            {
                CIDR = 24;
            }
            CIDR += CIDRULtOttet;
            return CIDR.ToString();

        }
    }
}


