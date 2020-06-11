using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib
{
    public interface ISearchProjectFactory
    {
        ISearchProjectListSaver CreateSearchProjectListSaver();
        ISearchProjectListLoader CreateSearchProjectListLoader();
    }
}
