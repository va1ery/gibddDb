using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gibddDBModels
{
    public class Licence
    {
        public DateTime licenceDate { get; set; }
        public DateTime expireDate { get; set; }
        public string categories { get; set; }
        public string licenceSeries { get; set; }
        public string licenceNubber { get; set; }
        public string status { get; set; }
    }
}
