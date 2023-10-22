using System;
using CalculadoraNomina.Models.Interfaces;

namespace CalculadoraNomina.Models.Repositories
{
    class ValeDespensaRepository : IValeDespensaRepository
    {
        public double ObtenValorSBC(DateTime fecha)
        {
            return 86.88;

        }

        public double ObtenValorUMA(DateTime fecha)
        {
            return 123.22;
        }
    }
}
