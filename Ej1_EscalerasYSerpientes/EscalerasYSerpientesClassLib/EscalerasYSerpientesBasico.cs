
using System.Collections;

namespace EscalerasYSerpientesClassLib

{
    public class EscalerasYSerpientesBasico
    {
        protected ArrayList jugadores = new ArrayList();
        
        public int CantidadJugadores { get{ return jugadores.Count; } }
        

        public EscalerasYSerpientesBasico(int cantJugadores) : this("Máquina 1", cantJugadores)
        {
        }

        public EscalerasYSerpientesBasico(string nombre, int cantJugadores)
        {
            InicializarTablero(nombre, cantJugadores);
        }

        virtual protected void  InicializarTablero(string Nombre, int cantJugadores)
        {
            jugadores.Add(new Jugador(Nombre));

            for (int n = 2; n <= cantJugadores; n++)
            {
                jugadores.Add(new Jugador("Máquina " + n));
            }
        }

        virtual public void Jugar()
        {
            foreach (Jugador jugador in jugadores)
            {
                jugador.Mover();
            }
        }

        public Jugador VerJugador(int idx)
        {
            return (Jugador)jugadores[idx];
        }
        
              
        public bool HaFinalizado()
        {
            bool haFinalizado=false;
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.HaLLegado==true)
                {
                    haFinalizado |= true;
                }
            }
            return haFinalizado;
        }
    }
}
