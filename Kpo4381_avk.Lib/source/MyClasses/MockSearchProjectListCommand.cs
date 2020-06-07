using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib
{
    public class MockSearchProjectListCommand
    {
        private readonly string _dataFileName = ""; 
        private List<SearchProject> _searchProjectList = null;
        public List<SearchProject> searchProjectList
        { 
            get { return _searchProjectList; } 
        }

        public MockSearchProjectListCommand() 
        { 
            this._searchProjectList = null; 
        }

        public void Execute()
        {
            throw new NotImplementedException();
            throw new Exception();

            {
                SearchProject searchProject = new SearchProject()
                {
                    year = "1960",
                    director = "Дрейк",
                    diamAntenna = 26,
                    frequency = 1420
                };
            }

            {
                SearchProject searchProject = new SearchProject()
                {
                    year = "1970",
                    director = "Троицкий",
                    diamAntenna = 14,
                    frequency = 1875
                };
            }

            {
                SearchProject searchProject = new SearchProject()
                {
                    year = "1978",
                    director = "Хоровиц",
                    diamAntenna = 300,
                    frequency = 1665
                };
            }
        }
    }
}
