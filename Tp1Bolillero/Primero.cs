using System;
using System.Collections.Generic;

namespace Tp1Bolillero
{
    public class Primero : IAzar
    {
        public byte SacarBolilla(List<byte> bolillas)
        {
            return bolillas[0];
        }
    }
}
