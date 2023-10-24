using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio2Condicionales.Servicios
{
    internal class solicitudNumeroImplementacion : solicitudNumeroInterfaz
    {
        public int numeroSolicitado() 
        {
            int numeroSolicitado;

            Console.WriteLine("Introduzca el numero ");
            numeroSolicitado= Convert.ToInt32(Console.ReadLine());
            return numeroSolicitado;
        }


    }
   
}
