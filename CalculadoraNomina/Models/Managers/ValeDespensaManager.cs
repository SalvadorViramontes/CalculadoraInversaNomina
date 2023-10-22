using CalculadoraNomina.Models.Enums;
using CalculadoraNomina.Models.Interfaces;
using CalculadoraNomina.Models.Repositories;
using System;

namespace CalculadoraNomina.Models.Managers
{
    public class ValeDespensaManager : IValeDespensaManager
    {
        private const double PORCENTAJE_TOPE_IMSS = 0.4;
        private IValeDespensaRepository ValesDespensa { get; set; }

        public ValeDespensaManager()
        {
            ValesDespensa = new ValeDespensaRepository();
        }

        public double ValeDespensaPorSBC(DateTime fecha, PeriodicidadPago periodo)
        {
            var topeDiario = ValesDespensa.ObtenValorSBC(fecha) * PORCENTAJE_TOPE_IMSS;
            var dias = (int)periodo;
            return topeDiario * dias;
        }

        public double ValeDespensaPorUMA(DateTime fecha, PeriodicidadPago periodo)
        {
            var topeDiario = ValesDespensa.ObtenValorUMA(fecha) * PORCENTAJE_TOPE_IMSS;
            var dias = (int)periodo;
            return topeDiario * dias;
        }
    }
}
