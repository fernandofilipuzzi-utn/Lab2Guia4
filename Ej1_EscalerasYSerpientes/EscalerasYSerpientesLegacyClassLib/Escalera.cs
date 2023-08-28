using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;

namespace EscalerasYSerpientesLegacyClassLib
{
    public class Escalera : Elemento
    {
        public int Base { get; private set; }
        public int Cima { get; private set; }

        public Escalera()
        {
            this.Base = Dado.Next(2, 99);
            this.Cima = Dado.Next(this.Base, 99);
        }

        public override void Evaluar(JugadorLegacy jugador)
        {
            if (jugador.PosicionActual == Base)
            {
                jugador.PosicionActual = Cima;
                if(jugador is JugadorLegacy legacy)
                    legacy.AgregarAfectador(this);
            }
        }

        public override string VerDescripcion()
        {
            string descripcion = "";

            descripcion = $"Escalera - Base: {Base}, Cima:{Cima}";

            return descripcion;
        }
    }
}
