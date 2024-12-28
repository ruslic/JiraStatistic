using Aspose.Cells;
using System.Text;

namespace ReportCreator.Strategies
{
    public class ExcelReportCreator<T> : IReportCreatorStrategy<T> where T : class
    {
        static string[] ExcelColumnAlphabetIdentifiers = new string[] { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
     "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public void CreateReport(List<string> headers, List<T> statistics)
        {
            //At the start, set the license before using other APIs
            //Aspose.Cells.License Aspose_Cells_license = new Aspose.Cells.License();
            //Aspose_Cells_license.SetLicense("Aspose.Cells.lic");

            Workbook ExcelFileWorkbook = new Workbook();

            Worksheet ExcelFileSheet = ExcelFileWorkbook.Worksheets[0];

            Cells SheetCells = ExcelFileSheet.Cells;

            var columns = GetPropertiesLists(statistics);

            var keys = new List<string>(columns.Keys);

            var numOfRows = columns[keys[0]].Count;
            var columnsHeaders = new List<string>();

            for (int i = 0; i < keys.Count; i++)
            {
                columnsHeaders.Add(ExcelColumnAlphabetIdentifier(i + 1));
            }

            for (int i = 0; i < headers.Count; i++)
            {
                SheetCells[$"{columnsHeaders[i]}1"].PutValue(headers[i]);
            }

            for (int i = 2; i < numOfRows + 2; i++)
            {
                var values = columns.Values.ToList();

                for (int j = 0; j < columnsHeaders.Count; j++)
                {
                    SheetCells[$"{columnsHeaders[j]}{i}"].PutValue(values[j][i - 2]);
                }
            }

            ExcelFileWorkbook.Save($"{FileName}.xlsx");
        }

        private Dictionary<string, List<string>> GetPropertiesLists(List<T> values)
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentNullException("Values must have data");
            }

            var propertiesNames = values.FirstOrDefault().GetType().GetProperties().Select(s => s.Name);

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (string propertyName in propertiesNames)
            {
                List<string> stringValues = new List<string>();

                foreach (var value in values)
                {
                    stringValues.Add(value.GetType().GetProperty(propertyName)?.GetValue(value, null).ToString());
                }

                result[propertyName] = stringValues;
            }

            return result;
        }

        private static string ExcelColumnAlphabetIdentifier(int ColumnNumber)
        {
            StringBuilder sb = new StringBuilder();
            int remainder = ColumnNumber;
            do
            {
                sb.Append(ExcelColumnAlphabetIdentifiers[remainder % 26]);
                remainder = remainder / 26;
            }
            while (remainder > 0);
            return sb.ToString();
        }
    }
}
