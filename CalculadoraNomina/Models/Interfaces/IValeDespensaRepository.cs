using System;

namespace CalculadoraNomina.Models.Interfaces
{
    public interface IValeDespensaRepository
    {
        double ObtenValorUMA(DateTime fecha);
        double ObtenValorSBC(DateTime fecha);
    }
}
