using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator.Strategies
{
    public interface IReportCreatorStrategy<T>
    {
        public void CreateReport(List<string> headers, List<T> statistics, string fileName);
    }
}
