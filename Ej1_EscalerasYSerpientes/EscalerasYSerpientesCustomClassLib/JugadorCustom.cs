using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;
using EscalerasYSerpientesLegacyClassLib;

namespace EscalerasYSerpientesCustomClassLib
{
    public class JugadorCustom:JugadorLegacy
    {
        public JugadorCustom(string nombre) : base(nombre)
        {
        }

        public int TurnosSuspendidos { get; set; }

        public override void Mover() 
        {
            if (TurnosSuspendidos <= 0)
                base.Mover();
            else
                TurnosSuspendidos--;
        }
    }
}
