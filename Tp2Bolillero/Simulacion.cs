namespace Tp2Bolillero
{
    public class Simulacion
    {
        private long simularHilos(List<byte>bolillas,int cantidad, int jugada);
        public void bolillas()
        {
            for (int i = 0; i < bolillas.Count; i++)
            {
            if(SacarBolilla() == bolillas[i])
                return true;
            }
            return false;
        }
        public void cantidad()
        {

        }
        public bool Jugar(List<byte> bolillas);

        private long simularConHilos(List<byte>bolillas,int cantidad);

    }
}