using System.Collections.Generic;
using CalculadoraNomina.Models.Enums;
using CalculadoraNomina.Models.Readers;
using CalculadoraNomina.Models.Abstracts;
using CalculadoraNomina.Models.Interfaces;

namespace CalculadoraNomina.Models.Managers
{
    public class TablaIsrManager : ATableManager, ITablaIsrManager
    {
        private AExcelReader ExcelReader { get; set; }
        private string TipoPagoPeriodico { get; set; }
        private IDictionary<string, IList<double>> TablaIsr;

        public TablaIsrManager(PeriodicidadPago periodicidad)
        {
            ExcelReader = new ExcelReader("ISR");
            TipoPagoPeriodico = periodicidad.ToString("g");
            TablaIsr = new Dictionary<string, IList<double>>
            {
                {"LimiteInferior", new List<double>() },
                {"LimiteSuperior", new List<double>() },
                {"CuotaFija", new List<double>() },
                {"PorcentajeExcedente", new List<double>() },
            };
            InicializarTabla();
        }

        public double ObtenLimiteInferior(double salarioBruto)
        {
            const string columna = "LimiteInferior";
            return ObtenValorPorColumna(TablaIsr, columna, salarioBruto);
        }

        public double ObtenLimiteSuperior(double salarioBruto)
        {
            const string columna = "LimiteSuperior";
            return ObtenValorPorColumna(TablaIsr, columna, salarioBruto);
        }

        public double ObtenCuotaFija(double salarioBruto)
        {
            const string columna = "CuotaFija";
            return ObtenValorPorColumna(TablaIsr, columna, salarioBruto);
        }

        public double ObtenPorcentajeExcedenteLimiteInferior(double salarioBruto)
        {
            const string columna = "PorcentajeExcedente";
            return ObtenValorPorColumna(TablaIsr, columna, salarioBruto);
        }

        protected override void InicializarTabla()
        {
            const int COL_LIMITE_INFERIOR = 1,
            COL_LIMITE_SUPERIOR = 2,
            COL_CUOTA_FIJA = 3,
            COL_PORCENTAJE_EXCEDENTE = 4;
            int row = 2;

            ExcelReader.SelectSheet(string.Format("Cuota{0}", TipoPagoPeriodico));

            while (ExcelReader.CellHasValue(row, COL_LIMITE_INFERIOR))
            {
                TablaIsr["LimiteInferior"].Add(ExcelReader.ReadCellAsDouble(row, COL_LIMITE_INFERIOR));
                TablaIsr["LimiteSuperior"].Add(ExcelReader.ReadCellAsDouble(row, COL_LIMITE_SUPERIOR));
                TablaIsr["CuotaFija"].Add(ExcelReader.ReadCellAsDouble(row, COL_CUOTA_FIJA));
                TablaIsr["PorcentajeExcedente"].Add(ExcelReader.ReadCellAsDouble(row, COL_PORCENTAJE_EXCEDENTE));
                row++;
            }
        }
    }
}
