using System;
using System.Collections.Generic;

namespace Tp1Bolillero
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        public IAzar Azar { get; set; }

        public Bolillero(IAzar azar, byte cantidad)
        {
            Azar = azar;
            Adentro = new List<byte>();
            Afuera = new List<byte>();
            CrearBolilla(cantidad);
        }
        private void CrearBolilla(byte bolillas)
        {
            for (byte i = 0; i < bolillas; i++)
            {
                Adentro.Add(i);
            }
        }
        public void ReIngresar ()
        {
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
        public byte SacarBolilla()
        {
            Aleatorio aleatorio = new Aleatorio();
            aleatorio.SacarBolilla(Adentro);
        }
        public bool Jugar(List<byte> bolillas)
        {

        }
        public long JugarN (List<byte> bolillas)
        {

        }
    }
}