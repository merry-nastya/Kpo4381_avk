using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib.source.MyClasses
{
    public class SearchProjectSplitFileFactory : ISearchProjectFactory
    {
        public ISearchProjectListLoader CreateSearchProjectListLoader()
        {
            return new SearchProjectListSplitFileLoader();
        }

        public ISearchProjectListSaver CreateSearchProjectListSaver()
        {
            return new SearchProjectListSplitFileSaver();

        }
    }
}
