using System.Collections.Generic;
using CalculadoraNomina.Models.Enums;
using CalculadoraNomina.Models.Readers;
using CalculadoraNomina.Models.Abstracts;
using CalculadoraNomina.Models.Interfaces;

namespace CalculadoraNomina.Models.Managers
{
    public class TablaSubsidioManager : ATableManager, ITablaSubsidioManager
    {
        private AExcelReader ExcelReader { get; set; }
        private string TipoPagoPeriodico { get; set; }
        private IDictionary<string, IList<double>> TablaSubsidio;

        public TablaSubsidioManager(PeriodicidadPago periodicidad)
        {
            ExcelReader = new ExcelReader("SubsidioEmpleo");
            TipoPagoPeriodico = periodicidad.ToString("g");
            TablaSubsidio = new Dictionary<string, IList<double>>
            {
                {"LimiteInferior", new List<double>() },
                {"SubsidioEmpleo", new List<double>() },
            };
            InicializarTabla();
        }

        public double ObtenSubsidioEmpleo(double salarioBruto)
        {
            const string columna = "SubsidioEmpleo";
            return ObtenValorPorColumna(TablaSubsidio, columna, salarioBruto);
        }

        protected override void InicializarTabla()
        {
            const int COL_LIMITE_INFERIOR = 1,
            COL_SUBSIDIO_EMPLEO = 3;
            int row = 2;

            ExcelReader.SelectSheet(string.Format("Subsidio{0}", TipoPagoPeriodico));

            while (ExcelReader.CellHasValue(row, COL_LIMITE_INFERIOR))
            {
                TablaSubsidio["LimiteInferior"].Add(ExcelReader.ReadCellAsDouble(row, COL_LIMITE_INFERIOR));
                TablaSubsidio["SubsidioEmpleo"].Add(ExcelReader.ReadCellAsDouble(row, COL_SUBSIDIO_EMPLEO));
                row++;
            }
        }
    }
}
