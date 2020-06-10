using System.Collections.Generic;

namespace Kpo4381_avk.Lib
{
    public interface ISearchProjectListLoader
    {
        List<SearchProject> searchProjectList { get; }
        LoadStatus status { get; }

        void Execute();
    }
}