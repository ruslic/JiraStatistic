using ReportCreator.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreator
{
    public class ReportStrategyContext<T>
    {
        IReportCreatorStrategy<T> _strategy { get; set; }

        public ReportStrategyContext(IReportCreatorStrategy<T> strategy)
        {
            _strategy = strategy;
        }

        public void CreateReport(List<string> headers, List<T> statistics)
        {
            _strategy.CreateReport(headers, statistics);
        }
    }
}
