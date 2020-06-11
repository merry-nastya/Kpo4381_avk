using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kpo4381_avk.Lib
{
    public class SearchProjectListTestSaver : ISearchProjectListSaver
    {
        private List<SearchProject> _searchProjectList = null;

        public void SaveFile(List<SearchProject> searchProjectList)
        {
            _searchProjectList = searchProjectList;

        }
    }
}
