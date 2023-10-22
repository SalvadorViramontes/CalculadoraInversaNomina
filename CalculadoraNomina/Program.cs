using System;
using System.Collections.Generic;
using CalculadoraNomina.Models;
using CalculadoraNomina.Models.Enums;
using CalculadoraNomina.Models.Managers;

namespace CalculadoraNomina
{
    class Program
    {
        static void Main(string[] args)
        {
            var premios = new List<Premio>()
            {
                new Premio
                {
                    Tipo = TipoPremio.Puntualidad,
                    Porcentaje = 0.1
                },
                new Premio
                {
                    Tipo = TipoPremio.Asistencia,
                    Porcentaje = 0.1
                }
            };
            var valeDespensa = BaseCalculoDespensa.SBC;

            IEnumerable<double> salarioNeto = new List<double>() {
                1000,
                2000,
                3000,
                4000,
                5000,
                6000,
                7000,
                8000,
                9000,
                10000
            };
            var periodicidad = PeriodicidadPago.Quincenal;
            foreach(var salario in salarioNeto)
            {
                TestCalculoInversoCompleto(salario, periodicidad, premios, valeDespensa);
            }
        }

        public static void TestLecturaTablas()
        {
            double salarioBruto = 100;
            var periodicidad = PeriodicidadPago.Diario;
            Console.WriteLine(string.Format("Salario Bruto: {0} \nPeriodicidadPago: {1}\n\n", salarioBruto, periodicidad.ToString("g")));
            var tablaIsr = new TablaIsrManager(periodicidad);
            var tablaSubsidio = new TablaSubsidioManager(periodicidad);

            double cuotaFija = tablaIsr.ObtenCuotaFija(salarioBruto);
            double limInferior = tablaIsr.ObtenLimiteInferior(salarioBruto);
            double limSuperior = tablaIsr.ObtenLimiteSuperior(salarioBruto);
            double porcentajeExcedente = tablaIsr.ObtenPorcentajeExcedenteLimiteInferior(salarioBruto);
            double subsidioEmpleo = tablaSubsidio.ObtenSubsidioEmpleo(salarioBruto);

            string output = string.Format(
                "Cuota Fija: {0}\n" +
                "Límite Inferior: {1}\n" +
                "Límite Superior: {2}\n" +
                "Porcentaje Excedente: {3}\n" +
                "Subsidio al Empleo: {4}\n",
                cuotaFija, limInferior, limSuperior, porcentajeExcedente, subsidioEmpleo);
            Console.WriteLine(output);
        }

        public static void TestCalculoInverso(double salarioNeto, PeriodicidadPago periodicidad, BaseCalculoDespensa? baseCalculo = null)
        {
            Console.WriteLine(string.Format("Salario Neto: {0} \nPeriodicidad Pago: {1}", salarioNeto, periodicidad.ToString("g")));
            var calculadora = new CalculadoraContableManager(periodicidad, DateTime.Now, baseCalculo);

            var salarioBruto = calculadora.CalculoInversoSalarioBrutoIsr(salarioNeto);
            var salarioNetoInverso = calculadora.CalculoSalarioNetoIsr(Convert.ToDouble(salarioBruto));

            string output = string.Format(
                "Salario Bruto Calculado: {0}\n" +
                "Salario Neto Inverso: {1}\n\n",
                salarioBruto, salarioNetoInverso);
            Console.WriteLine(output);
        }

        public static void TestCalculoISR(double salarioBruto, PeriodicidadPago periodicidad)
        {
            Console.WriteLine(string.Format("Salario Bruto: {0} \nPeriodicidad Pago: {1}", salarioBruto, periodicidad.ToString("g")));
            var calculadora = new CalculadoraContableManager(periodicidad, DateTime.Now);

            var salarioNeto = calculadora.CalculoSalarioNetoIsr(salarioBruto);

            string output = string.Format("Salario Neto Calculado: {0}\n\n", salarioNeto);
            Console.WriteLine(output);
        }

        public static void TestCalculoInversoCompleto(double salarioNeto, PeriodicidadPago periodicidad, IEnumerable<Premio> premios, BaseCalculoDespensa? baseCalculo = null)
        {
            Console.WriteLine(string.Format("Salario Neto: {0} \nPeriodicidad Pago: {1}", salarioNeto, periodicidad.ToString("g")));
            var calculadora = new CalculadoraContableManager(periodicidad, DateTime.Now, baseCalculo, premios);

            var salarioBruto = calculadora.CalculoInversoSalarioBrutoIsr(salarioNeto);
            double salarioBrutoDoble = Convert.ToDouble(salarioBruto);
            var salarioNetoInverso = calculadora.CalculoSalarioNetoIsr(Convert.ToDouble(salarioBruto));
            var isr = calculadora.CalculoIsr(salarioBrutoDoble);
            var subsidio = calculadora.CalculoSubsidioEmpleo(salarioBrutoDoble);
            var puntualidad = calculadora.CalculoPremioPuntualidad(salarioBrutoDoble);
            var asistencia = calculadora.CalculoPremioAsistencia(salarioBrutoDoble);

            string output = string.Format(
                "Salario Bruto Calculado: {0}\n" +
                "Salario Neto Inverso: {1}\n" +
                "Impuesto sobre la Renta: {2}\n" +
                "Subsidio al Empleo: {3}\n" +
                "Premio de Puntualidad: {4}\n" +
                "Premio de Asistencia: {5}\n\n",
                salarioBruto, salarioNetoInverso, isr, subsidio, puntualidad, asistencia);
            Console.WriteLine(output);
        }
    }
}
