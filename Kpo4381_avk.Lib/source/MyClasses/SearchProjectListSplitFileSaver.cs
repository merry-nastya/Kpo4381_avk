using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo4381_avk.Lib
{
    class SearchProjectListSplitFileSaver : ISearchProjectListSaver
    {
        private List<SearchProject> _searchProjectList = null;
        private string _saveFileName = "";

        public void SaveFile(List<SearchProject> searchProjectList)
        {
            _searchProjectList = searchProjectList;
            _saveFileName = AppGlobalSettings.saveFileName;
            foreach( SearchProject i in _searchProjectList)
            {
                string searchProject = i.year + "|" + i.director + "|" + i.diamAntenna + "|" + i.frequency + "\n";
                File.WriteAllText(_saveFileName, searchProject);

            }

        }
    }
}
