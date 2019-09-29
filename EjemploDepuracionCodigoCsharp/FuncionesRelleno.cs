using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCsharp
{
    public class FuncionesRelleno : Funciones
    {
        public List<int> rellenar()
        {
            int indice = 0;
            List<int> valores = new List<int>();

            while (indice < this.getNumero()) {

                indice++;
                valores.Add(indice);

            }

            return valores;
        }

    }
}
