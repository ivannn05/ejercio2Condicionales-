
using ejercio2Condicionales.Servicios;
using System.ComponentModel.Design;
using System.Timers;

namespace ejercio2Condicionales
{
    class Program
    {
        static void Main(string[] args) {
            ///asignacion de la imterfaz y creacion de objeto , asignandolo a la implementacion
            solicitudNumeroInterfaz si = new solicitudNumeroImplementacion();
            int numero =si.numeroSolicitado();
            ///calculo para hacer la raiz del numero introducido
            
            double raiz = Math.Sqrt(numero);

            if (raiz *raiz ==numero)
            {
                Console.WriteLine("El numero intoducido es entero");

                

            }
            else
            {
                Console.WriteLine("El numero intoducido no es entero ");

            }
        }
    }
}