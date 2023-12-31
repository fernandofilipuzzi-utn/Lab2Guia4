﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLib
{
    abstract public class Sujeto
    {
        List<IObservador> observadores = new List<IObservador>();

        public void SuscribirObservador(IObservador obs)
        {
            observadores.Add(obs);
        }

        public void DesuscribirObservador(IObservador obs)
        {
            observadores.Remove(obs);
        }

        public void NotificarATodosSobrePosicion()
        {
            foreach (IObservador obs in observadores)
            {
                obs.NotificarCambioPosicion(this);
            }
        }
    }
}
