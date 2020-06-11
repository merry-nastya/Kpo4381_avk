using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo4381_avk.Lib
{
     public class SearchProjectListSplitFileSaver : ISearchProjectListSaver
    {
        private List<SearchProject> _searchProjectList = null;
        private string _saveFileName = "";

        public SearchProjectListSplitFileSaver(string path = "")
        {
            if (path == "")
            {
                _saveFileName = AppGlobalSettings.saveFileName;
            }
            else
            {
                _saveFileName = path;
            }
        }

        public void SaveFile(List<SearchProject> searchProjectList)
        {
            _searchProjectList = searchProjectList;
            List<string> strings = new List<string>();
            foreach( SearchProject i in _searchProjectList)
            {
               string searchProject = i.year + "|" + i.director + "|" + i.diamAntenna + "|" + i.frequency;
                strings.Add(searchProject);

            }
            File.WriteAllLines(_saveFileName, strings); 

        }
    }
}
