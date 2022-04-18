using System;
using System.Collections.Generic;

namespace Tp1Bolillero
{
    public class Aleatorio: IAzar
    {
        public Random r = new Random(DateTime.Now.Millisecond);
        public byte SacarBolilla(List<byte> bolillas) 
        {
            var indiceAleatorio = r. Next(0 ,bolillas.Count);
            return bolillas [indiceAleatorio];
        }
    }
}

