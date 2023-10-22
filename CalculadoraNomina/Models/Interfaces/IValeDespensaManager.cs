using System;
using CalculadoraNomina.Models.Enums;

namespace CalculadoraNomina.Models.Interfaces
{
    public interface IValeDespensaManager
    {
        double ValeDespensaPorUMA(DateTime fecha, PeriodicidadPago periodo);
        double ValeDespensaPorSBC(DateTime fecha, PeriodicidadPago periodo);
    }
}
