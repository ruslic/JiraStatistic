using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraStatistic.Infrastructure.Entities
{
    public class JiraTaskEntity : IHasId
    {
        public int Id { get; set; }
        public string Tag { get; set; }
    }
}
