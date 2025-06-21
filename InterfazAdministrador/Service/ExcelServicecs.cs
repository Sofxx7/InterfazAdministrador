using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InterfazAdministrador.Service
{
    internal class ExcelServicecs
    {
        public ExcelServicecs()
        {
            ExcelPackage.License.SetNonCommercialPersonal("Sistema Administrador");
        }

        public void ExportMultipleDataGridViewsToExcel(Dictionary<string, DataGridView> grids, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                foreach (var entry in grids)
                {
                    var ws = package.Workbook.Worksheets.Add(entry.Key);
                    var dgv = entry.Value;
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        ws.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText;
                    }
                    for (int row = 0; row < dgv.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            ws.Cells[row + 2, col + 1].Value = dgv.Rows[row].Cells[col].Value;
                        }
                    }
                    ws.Cells[ws.Dimension.Address].AutoFitColumns();
                }
                package.SaveAs(new FileInfo(filePath));
            }
        }
    }
}
