using System.Collections.Generic;

namespace Kpo4381_avk.Lib
{
    public interface ISearchProjectListLoader
    {
        List<SearchProject> searchProjectList { get; }
        LoadStatus status { get; }
        Delegate.OnStatusChangedDelegate onStatusChangedDelegate { get; }
        void SetOnStatusChanged(Delegate.OnStatusChangedDelegate onStatusChanged);
        void Execute();
        void Sort(string property = "");
    }
}