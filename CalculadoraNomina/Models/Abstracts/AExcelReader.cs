using System;
using System.IO;
using System.Reflection;

namespace CalculadoraNomina.Models.Abstracts
{
    public abstract class AExcelReader
    {
        protected string bookUrl { get; set; }

        public AExcelReader(string tipoTabla)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string baseDirectory = Path.GetDirectoryName(path);
            string nombreArchivo = string.Format("Tablas{0}.xlsx", tipoTabla);
            bookUrl = Path.Combine(baseDirectory, "DataBases", nombreArchivo);
        }

        public abstract void SelectSheet(string sheetName);
        public abstract bool CellHasValue(int row, int col);
        public abstract object ReadCell(int row, int col);
        public abstract double ReadCellAsDouble(int row, int col);
    }
}
