using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalerasYSerpientesLegacyClassLib
{
    public class SerpienteVenenosa:Serpiente
    {

        public override void Evaluar(JugadorLegacy jugador)
        {
            if (jugador.PosicionActual == Cabeza)
            {
                jugador.PosicionActual = Cola;
                if (jugador is JugadorLegacy)
                    ((JugadorLegacy)jugador).AgregarAfectador(this);
            }
        }

        public override string VerDescripcion()
        {
            string descripcion = "";

            descripcion = $"Serpiente - Cabeza: {Cabeza}, Fin:{Cola}";

            return descripcion;
        }
    }
}
