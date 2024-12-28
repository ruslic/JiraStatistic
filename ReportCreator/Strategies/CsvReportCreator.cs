using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReportCreator.Strategies
{
    public class CsvReportCreator<T> : IReportCreatorStrategy<T> where T : class
    {
        public void CreateReport(List<string> headers, List<T> statistics)
        {
            try
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                    Comment = '%'
                };

                using (var writer = new StreamWriter($"{FileName}.csv"))
                using (var csv = new CsvWriter(writer, configuration))
                {
                    csv.WriteRecords(statistics);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
