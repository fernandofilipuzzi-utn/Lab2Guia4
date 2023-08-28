using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;
using System.Collections;

namespace EscalerasYSerpientesLegacyClassLib
{
    public class EscaleraYSerpientesLegacy:EscalerasYSerpientesBasico
    {
        protected ArrayList elementos = new ArrayList();
        public int CantidadElementos
        {
            get { return elementos.Count; }
        }

        public EscaleraYSerpientesLegacy(string nombre, int cantJugadores) : base(nombre, cantJugadores)
        {            
        }

        override protected void InicializarTablero(string nombre, int cantJugadores)
        {
            //base.InicializarTablero(nombre, cantJugadores);

            jugadores.Add(new JugadorLegacy(nombre));

            for (int n = 2; n <= cantJugadores; n++)
            {
                jugadores.Add(new JugadorLegacy("Máquina " + n));
            }

            for (int n = 1; n <= 7; n++)
            {
                elementos.Add(new Escalera());
                elementos.Add(new Serpiente());
            }
        }
          
        override public void Jugar()
        {
            base.Jugar();

            foreach (JugadorLegacy jugador in jugadores)
            {
                foreach (Elemento elemento in elementos)
                {
                    elemento.Evaluar(jugador);
                }
            }
        }

        public Elemento VerElemento(int idx)
        {
            return (Elemento)elementos[idx];
        }
    }
}
