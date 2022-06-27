using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp1Bolillero
{
    public class Simulacion
    {
        private long simularSinHilos(Bolillero bolillero, List<byte> jugada, long cantidad)
        {
            return bolillero.JugarN(jugada, cantidad);
        }
        private long simularConHilos(Bolillero bolillero, List<byte> jugada, long cantidadSimulaciones, long cantidadporHilos)
        {
            long cantidadporhilos = cantidadSimulaciones / cantidadporHilos;
            var tareas = new Task<long>[cantidadSimulaciones];
            for (long i = 0; i < cantidadporHilos; i++)
            {
                Bolillero clon = (Bolillero)bolillero.Clone();
                tareas[i] = Task.Run(() => simularSinHilos(clon, jugada, cantidadSimulaciones));
            }
            Task<long>.WaitAll(tareas);
            return tareas.Sum(i => i.Result);
        }

        public async Task<long> SimularConHilosAsync()
        {
            long cantidadporhilos = cantidadSimulaciones / cantidadporHilos;
            var tareas = new Task<long>[cantidadSimulaciones];
            for (long i = 0; i < cantidadporHilos; i++)
            {
                Bolillero clon = (Bolillero)bolillero.Clone();
                tareas[i] = Task.Run(() => simularSinHilos(clon, jugada, cantidadSimulaciones));
            }
            await Task<long>.WhenAll(tareas);
            return tareas.Sum(i => i.Result);
        }

    }
}