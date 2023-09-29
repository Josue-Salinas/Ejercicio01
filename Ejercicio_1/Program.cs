using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int asis_actu=0;
            int lleno=0;
            int vacio = 0;
            int ingreso=0;
            int salida = 0;
            Console.WriteLine("Ingrese un número máximo de personas: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("El número máximo establecido es de "+ max+" personas, presiona una tecla para comenzar a contar");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("| Asistentes actuales |" + asis_actu);
                Console.WriteLine($"| Aforo               |{((double)asis_actu / max * 100):F0}%");
                Console.WriteLine("| Máximo              |"+ max +"personas");
                Console.WriteLine("Presione");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");
                char opcion = char.ToLower(Console.ReadKey().KeyChar);
                switch (opcion) 
                {
                    case 'i':
                        if (asis_actu < max) 
                        {
                            asis_actu++;
                            ingreso++;
                        }
                        break;
                    case 's':
                        if (asis_actu>0) 
                        {
                            asis_actu--;
                            salida++;
                        }
                        break;
                    case 'x':
                        Console.WriteLine("El programa ha terminado");
                        break;
                    default:
                        Console.WriteLine("Intente de nuevo más tarde");
                        break;
                }
                Console.Clear() ;
                if (asis_actu == 0) 
                {
                    vacio++;
                }
                else if (asis_actu == max) 
                {
                    lleno++;
                }
                else if (opcion == 'x') 
                {
                    break;
                }
            }
            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadisticas");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{ingreso} personas ingresaron");
            Console.WriteLine($"{salida} personas salieron");
            Console.WriteLine($"{lleno} veces se llenó el local");
            Console.WriteLine($"Estuvo vacío {vacio} veces");
            Console.ReadKey();
        }
    }
}
