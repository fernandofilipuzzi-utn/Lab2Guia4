using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalerasYSerpientesDesktop.Modelo
{
    class Partida
    {
        public string Ganador { get; set; }
        public int Ganadas { get; set; }

        public Partida(string ganador, int ganadas)
        {
            this.Ganador = ganador;
            this.Ganadas = ganadas;
        }
    }
}
