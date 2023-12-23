using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CalculadoraV2;

namespace CalculadoraV2
{
    public class OPERACIONES
    {
   
        public float Suma(float sa,float sb)
        {
            return sa + sb;
            
        }

        public float Resta(float ra, float rb) 
        {
            return ra - rb;
        }

        public float Multiplicacion(float ma, float mb) 
        {
            return ma * mb;
        }

        public float Division (float da, float db)
        {

            try
            {
                if (db != 0)
                {
                    return da / db;
                }
                else
                {
                    throw new DivideByZeroException("No se puede dividir entre 0");
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede divir entre 0");
                return 0;
            }
        }
    }
}






