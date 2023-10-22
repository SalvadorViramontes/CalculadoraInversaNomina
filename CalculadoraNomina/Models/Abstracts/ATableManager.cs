using System.Collections.Generic;

namespace CalculadoraNomina.Models.Abstracts
{
    public abstract class ATableManager
    {
        protected const int INDEX = 0;

        protected double ObtenValorPorColumna(IDictionary<string, IList<double>> tabla, string nombreColumna, double salario)
        {
            int index = INDEX;
            int listSize = tabla[nombreColumna].Count;
            foreach (var limiteInferior in tabla["LimiteInferior"])
            {
                if (salario > limiteInferior)
                {
                    if (index + 1 < listSize) index++;
                    continue;
                }
                else
                {
                    if (index > 0) index--;
                    break;
                }
            }
            return tabla[nombreColumna][index];
        }

        protected abstract void InicializarTabla();
    }
}
