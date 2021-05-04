using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TP4_MonteCarlo_grupo7.Generadores_Aleatorios;

namespace TP4_MonteCarlo_grupo7.Generadores_Aleatorios
{
    class GeneradorUniformeLenguaje 
    {
        Random random;
        Truncador truncador;

        private double aleatorio;

        public GeneradorUniformeLenguaje( Truncador truncador)
        {
            this.random = new Random();
            this.truncador = truncador;
        }

        public double siguienteAleatorio()
        {
            return truncador.truncar(random.NextDouble());
        }

       
    }

}
