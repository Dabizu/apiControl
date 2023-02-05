using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicia el programa net");
            
            while (true)
            {
                string entrada = Console.ReadLine();
                
                Console.WriteLine(entrada+"  letra del arduino");
                /*
                if (entrada.Equals("3"))
                {
                    Console.WriteLine("entro en el 3");
                    
                    //Muevete a la izq
                    WindowsCrap.Press(WindowsCrap.ScanCodeShort.LEFT);
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.RIGHT);
                }*/
            }
            /*
            while (true)
            {
                //string movimiento = Console.ReadLine(); //0, -1, 1
                string entrada = Console.ReadLine();
                string[] datos = entrada.Split(',');
                string movimiento = datos[0];
                string brincar = datos[1];
                string acelerar = datos[2];

                //MARIO KART
                if (movimiento.Equals("0"))
                {
                    //No te muevas
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.RIGHT);
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.LEFT);
                }
                else if (movimiento.Equals("3"))
                {
                    //Muevete a la izq
                    WindowsCrap.Press(WindowsCrap.ScanCodeShort.LEFT);
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.RIGHT);
                }
                else if (movimiento.Equals("1"))
                {
                    //Muevete a la der
                    WindowsCrap.Press(WindowsCrap.ScanCodeShort.RIGHT);
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.LEFT);
                }


                if (brincar.Equals("1"))
                {
                    WindowsCrap.Press(WindowsCrap.ScanCodeShort.KEY_A);
                }
                else
                {
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.KEY_A);
                }

                if (acelerar.Equals("1"))
                {
                    WindowsCrap.Press(WindowsCrap.ScanCodeShort.KEY_C);
                }
                else
                {
                    WindowsCrap.Release(WindowsCrap.ScanCodeShort.KEY_C);
                }
            }*/
        }
    }
}
