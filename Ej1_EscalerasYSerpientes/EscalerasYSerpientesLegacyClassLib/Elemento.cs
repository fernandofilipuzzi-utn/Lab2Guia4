using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;

namespace EscalerasYSerpientesLegacyClassLib
{
    abstract public class Elemento
    {
        static protected Random Dado = new Random();
        abstract public void Evaluar(JugadorLegacy jugador);
        abstract public string VerDescripcion();
    }
}
