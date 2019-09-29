using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCsharp
{
    public class FibonacciLogica : SerieFibonacci
    {
       
        public List<int> serieF()
        {
           
            int a = 0;
            int b = 1;
            int c = 0;
            List<int> valores = new List<int>();

            for (int i = 0; i < this.getNumero(); i++) {

                c = a + b;
                a = b;
                b = c;
                valores.Add(c);
            }

            //while (indice < this.getNumero()) {
                    //int indice = 0;
            //    if (indice < this.getNumero()) {

                    
            //        c = a + b;
            //        a = b;
            //        b = c;
            //        valores.Add(c);
            //        indice++;
            //    }

                
            //}

            return valores;

            
            
        }

    }
}
