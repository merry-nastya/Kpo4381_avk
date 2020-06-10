using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib
{
    public class SearchProjectListTestLoader: ISearchProjectListLoader
    {
        private List<SearchProject> _searchProjectList = null;

        private LoadStatus _status = LoadStatus.None;
        public LoadStatus status
        {
            get { return _status; }
        }
        public List<SearchProject> searchProjectList
        {
            get { return _searchProjectList; }
        }

        public SearchProjectListTestLoader()
        {
            _searchProjectList = new List<SearchProject>();
        }

        public void Execute()
        {

            {
                SearchProject searchProject = new SearchProject()
                {
                    year = "1960",
                    director = "Дрейк",
                    diamAntenna = 26,
                    frequency = 1420
                };
                _searchProjectList.Add(searchProject);

            }

            {
                SearchProject searchProject = new SearchProject()
                {
                    year = "1970",
                    director = "Троицкий",
                    diamAntenna = 14,
                    frequency = 1875
                };
                _searchProjectList.Add(searchProject);
            }

            {
                SearchProject searchProject = new SearchProject()
                {
                    year = "1978",
                    director = "Хоровиц",
                    diamAntenna = 300,
                    frequency = 1665
                };
                _searchProjectList.Add(searchProject);
            }
        }
    }
}
