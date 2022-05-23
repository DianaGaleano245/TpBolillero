using System;
using System.Collections.Generic;

namespace Tp1Bolillero
{
    public class Bolillero : ICloneable
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        public Bolillero(IAzar azar)
        {
            this.Azar = azar;

        }
        public IAzar Azar { get; set; }

        public Bolillero()
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
        }

        public Bolillero(byte cantidad)
        {
            CrearBolilla(cantidad);
        }
        private void CrearBolilla(byte bolillas)
        {
            for (byte i = 0; i < bolillas; i++)
            {
                Adentro.Add(i);
            }
        }
        public void ReIngresar()
        {
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
        public byte SacarBolilla()
        {
            byte bolilla = Azar.SacarBolilla(Adentro);
            Afuera.Add(bolilla);
            Adentro.Remove(bolilla);
            return bolilla;
        }
        public bool Jugar(List<byte> bolillas)
        {
            for (int i = 0; i < bolillas.Count; i++)
            {
                if (SacarBolilla() == bolillas[i])
                    return true;
            }
            return false;
        }
        public long JugarN(List<byte> bolillas, int cantidad)
        {
            long contador = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (Jugar(bolillas))
                    contador++;
                ReIngresar();
            }
            return contador;
        }

        public object Clone()
        {
            return Clone ();
        }
    }
}