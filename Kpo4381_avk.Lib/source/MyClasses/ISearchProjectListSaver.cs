using System.Collections.Generic;

namespace Kpo4381_avk.Lib
{
    public interface ISearchProjectListSaver
    {
        void SaveFile(List<SearchProject> searchProjectList);
    }
}