using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReadCerFile
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            SAT_Selector.frm_SAT_Selector nFrm = new SAT_Selector.frm_SAT_Selector();
            if(nFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("RFC: " + nFrm.RFC);
                Console.WriteLine("Nombre: " + nFrm.Nombre);
                Console.WriteLine("Pwd: " + nFrm.Password);
            }
            else
            {
                Console.Write("Cancelado");
            }
            Console.ReadLine();


        }
    }
}
