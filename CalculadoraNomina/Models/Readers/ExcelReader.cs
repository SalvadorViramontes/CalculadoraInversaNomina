using System;
using ClosedXML.Excel;
using CalculadoraNomina.Models.Abstracts;

namespace CalculadoraNomina.Models.Readers
{
    public class ExcelReader : AExcelReader
    {
        private XLWorkbook Workbook { get; set; }
        private IXLWorksheet Worksheet { get; set; }
        
        public ExcelReader(string tipoTabla) : base(tipoTabla)
        {
            Workbook = new XLWorkbook(bookUrl);
        }

        public override bool CellHasValue(int row, int col)
        {
            var isEmpty = Worksheet.Cell(row, col).IsEmpty();
            return !isEmpty;
        }

        public override object ReadCell(int row, int col)
        {
            return Worksheet.Cell(row, col).Value;
        }

        public override double ReadCellAsDouble(int row, int col)
        {
            var cell = Worksheet.Cell(row, col).Value;
            try { return Convert.ToDouble(cell); }
            catch(Exception) { return 0; }
        }

        public override void SelectSheet(string sheetName)
        {
            Worksheet = Workbook.Worksheet(sheetName);
        }
    }
}
