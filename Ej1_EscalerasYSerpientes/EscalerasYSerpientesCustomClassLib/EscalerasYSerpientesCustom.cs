using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;
using System.Collections;
using EscalerasYSerpientesLegacyClassLib;

namespace EscalerasYSerpientesCustomClassLib
{
    public class EscalerasYSerpientesCustom : EscaleraYSerpientesLegacy
    {
        public EscalerasYSerpientesCustom(string nombre, int cantJugadores) : base(nombre, cantJugadores)
        {
        }

        override protected void InicializarTablero(string nombre, int cantJugadores)
        {
            //base.InicializarTablero(nombre, cantJugadores);

            jugadores.Add(new JugadorCustom(nombre));

            for (int n = 2; n <= cantJugadores; n++)
            {
                jugadores.Add(new JugadorCustom("Máquina " + n));
            }

            for (int n = 1; n <= 7; n++)
            {
                elementos.Add(new Escalera());
                elementos.Add(new Serpiente());
            }

            elementos.Add(new SerpienteVenenosa());
            elementos.Add(new SerpienteVenenosa());
        }
    }
}
