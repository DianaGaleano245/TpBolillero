using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tp1Bolillero
{
    public class Simulacion 
    {
        private long simularHilos(Bolillero bolillero, List<byte>jugada,int cantidad)
        {
            return bolillero.JugarN(jugada,cantidad);
        }
        private long simularConHilos(Bolillero bolillero, List<byte>jugada,long cantidadSimulaciones, long cantidadHilos)
        {
            var tareas  = new Task<long>[cantidadHilos];
            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                Bolillero bolilleroClone = bolillero.Clone();
            }

        }

    }
}