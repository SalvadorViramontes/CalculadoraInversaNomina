using System;
using System.Linq;
using System.Collections.Generic;
using MathNet.Numerics.RootFinding;
using CalculadoraNomina.Models.Enums;
using CalculadoraNomina.Models.Interfaces;

namespace CalculadoraNomina.Models.Managers
{
    public class CalculadoraContableManager : ICalculadoraContableManager
    {
        private ITablaIsrManager TablaIsr { get; set; }
        private ITablaSubsidioManager TablaSubsidio { get; set; }
        private IValeDespensaManager DespensaManager { get; set; }
        private IEnumerable<Premio> Premios { get; set; }
        private DateTime FechaNomina { get; set; }
        private BaseCalculoDespensa? BaseCalculo { get; set; }
        private PeriodicidadPago Periodicidad { get; set; }

        public CalculadoraContableManager(PeriodicidadPago periodicidad, DateTime fecha, BaseCalculoDespensa? baseCalculo = null, IEnumerable<Premio> premios = null)
        {
            Periodicidad = periodicidad;
            TablaIsr = new TablaIsrManager(Periodicidad);
            TablaSubsidio = new TablaSubsidioManager(Periodicidad);
            DespensaManager = new ValeDespensaManager();
            FechaNomina = fecha;
            Premios = premios;
            BaseCalculo = baseCalculo;
        }

        public decimal CalculoInversoSalarioBrutoIsr(double salarioNeto)
        {
            double LIMITE_INFERIOR = salarioNeto * 0.5, 
                LIMITE_SUPERIOR = salarioNeto * 1.5;

            double CalculoSalarioBruto(double x)
            {
                return CalculoSalarioNetoIsrInterno(x) - salarioNeto;
            }

            double dCalculoSalarioBruto(double x)
            {
                return 1 - TablaIsr.ObtenPorcentajeExcedenteLimiteInferior(x) + dCalculoPremios();
            }
            double salarioBruto = RobustNewtonRaphson.FindRoot(CalculoSalarioBruto, dCalculoSalarioBruto, LIMITE_INFERIOR, LIMITE_SUPERIOR, 1E-06, 75);
            return Convert.ToDecimal(salarioBruto);
        }
        

        private double CalculoSalarioNetoIsrInterno(double salarioBruto)
        {
            double subsidio = TablaSubsidio.ObtenSubsidioEmpleo(salarioBruto);
            double premios = CalculoPremios(salarioBruto);
            double valesDespensa = CalculoValesDespensaInterno();

            return salarioBruto - CalculoIsrInterno(salarioBruto) + subsidio + valesDespensa + premios;
        }
        private double CalculoIsrInterno(double salarioBruto)
        {
            double limiteInferior = TablaIsr.ObtenLimiteInferior(salarioBruto);
            double porcentajeExcedente = TablaIsr.ObtenPorcentajeExcedenteLimiteInferior(salarioBruto);
            double cuotaFija = TablaIsr.ObtenCuotaFija(salarioBruto);

            return (salarioBruto - limiteInferior) * porcentajeExcedente + cuotaFija;
        }
        private double CalculoValesDespensaInterno()
        {
            switch (BaseCalculo)
            {
                case BaseCalculoDespensa.UMA:
                    return DespensaManager.ValeDespensaPorUMA(FechaNomina, Periodicidad);
                case BaseCalculoDespensa.SBC:
                    return DespensaManager.ValeDespensaPorSBC(FechaNomina, Periodicidad);
                default:
                    return 0;
            }
        }
        private double CalculoPremios(double salarioBruto)
        {
            double resultado = 0;
            foreach (var premio in Premios)
            {
                resultado += salarioBruto * premio.Porcentaje;
            }
            return resultado;
        }
        private double dCalculoPremios()
        {
            double resultado = 0;
            foreach (var premio in Premios)
            {
                resultado += premio.Porcentaje;
            }
            return resultado;
        }

        public decimal CalculoSalarioNetoIsr(double salarioBruto)
        {
            return Convert.ToDecimal(CalculoSalarioNetoIsrInterno(salarioBruto));
        }
        public decimal CalculoIsr(double salarioBruto)
        {
            return Convert.ToDecimal(CalculoIsrInterno(salarioBruto));
        }
        public decimal CalculoSubsidioEmpleo(double salarioBruto)
        {
            return Convert.ToDecimal(TablaSubsidio.ObtenSubsidioEmpleo(salarioBruto));
        }
        public decimal CalculoPremioAsistencia(double salarioBruto)
        {
            if (Premios.Any(p => p.Tipo == TipoPremio.Asistencia))
            {
                Premio premioAsistencia = Premios.Where(p => p.Tipo == TipoPremio.Asistencia).FirstOrDefault();
                return Convert.ToDecimal(premioAsistencia.Porcentaje * salarioBruto);
            }
            else
                return 0M;
        }
        public decimal CalculoPremioPuntualidad(double salarioBruto)
        {
            if (Premios.Any(p => p.Tipo == TipoPremio.Puntualidad))
            {
                Premio premioPuntualidad = Premios.Where(p => p.Tipo == TipoPremio.Puntualidad).FirstOrDefault();
                return Convert.ToDecimal(premioPuntualidad.Porcentaje * salarioBruto);
            }
            else
                return 0M;
        }
        public decimal CalculoValesDespensa()
        {
            return Convert.ToDecimal(CalculoValesDespensaInterno());
        }
    }
}
