using EscalerasYSerpientesClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalerasYSerpientesLegacyClassLib
{
    public class Serpiente : Elemento
    {
        public int Cabeza { get; protected  set; }
        public int Cola { get; protected set; }

        public Serpiente()
        {
            this.Cola = Dado.Next(2, 99);
            this.Cabeza = Dado.Next(this.Cola, 99);
        }

        public override void Evaluar(JugadorLegacy jugador)
        {
            if (jugador.PosicionActual == Cabeza)
            {
                jugador.PosicionActual = Cola;
                if(jugador is JugadorLegacy legacy)
                    legacy.AgregarAfectador(this);
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
