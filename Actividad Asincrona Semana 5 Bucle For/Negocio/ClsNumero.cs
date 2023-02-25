using Actividad_Asincrona_Semana_5_Bucle_For.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Asincrona_Semana_5_Bucle_For.Negocio
{
    public class ClsNumero
    {
        public void ImprimirPares(Numero numero) 
        { 
            for(int i =numero.NumeroMinimo;i< numero.NumeroMaximo;i++) 
            {
             if(i % 2 ==0) 
                {
                    Console.WriteLine(i);
                }
            }
        
        }

    }
}
