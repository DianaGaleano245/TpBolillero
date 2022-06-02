using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tp1Bolillero
{
    public class Simulacion
    {
        private long simularSinHilos(Bolillero bolillero, List<byte> jugada, long cantidad)
        {
            return bolillero.JugarN(jugada, cantidad);
        }
        private long simularConHilos(Bolillero bolillero, List<byte> jugada, long cantidadSimulaciones, long cantidadHilos)
        {
            long cantidadporhilos = cantidadSimulaciones/cantidadHilos;
            var tareas = new Task<long>[cantidadHilos];
            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                Bolillero clon = (Bolillero)bolillero.Clone();
                tareas[i] = Task.Run(() => simularSinHilos(clon, jugada, cantidadSimulaciones));
            }
        }
    }
}