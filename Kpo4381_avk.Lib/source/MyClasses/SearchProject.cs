using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib
{
    public class SearchProject
    {
        public string year { get; set; }
        public string director { get; set; }
        public int diamAntenna { get; set; }
        public int frequency { get; set; }

        public SearchProject()
        {
            year = "";
            director = "";
            diamAntenna = 0;
            frequency = 0;
        }
    }
}
