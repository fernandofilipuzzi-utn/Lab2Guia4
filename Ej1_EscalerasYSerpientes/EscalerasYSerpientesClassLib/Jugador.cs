using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace EscalerasYSerpientesClassLib
{
    public class Jugador
    {
        static Random dado = new Random();

        public string Nombre { get; private set; }

        int posicion;
        public int PosicionActual 
        {
            get 
            {
                return posicion;
            }
            set {
                if(value<100)
                    posicion = value;
                else
                    posicion = 100;
            }
        }

        public int PosicionAnterior { get; private set; }
        public int Avance { get; private set; }
        public bool HaLLegado
        {
            get 
            {
                return PosicionActual == 100;
            }
        }

       
        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        virtual public void Mover()
        {

            Avance = dado.Next(1, 6);

            PosicionAnterior = PosicionActual;
            PosicionActual += Avance;
        }

    }
}
