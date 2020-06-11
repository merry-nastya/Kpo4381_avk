using Kpo4381_avk.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381_avk.Lib
{
     public enum LoadStatus { 
        None = 0, 
        Success = 1,
        Reading = 2,
        FileNameIsEmpty = -1, 
        FileNotExists = -2, 
        GeneralError = -100 
    }
    public class SearchProjectListSplitFileLoader : ISearchProjectListLoader
    {
        private readonly string _dataFileName = "";
        private List<SearchProject> _searchProjectList = null;
        private LoadStatus _status = LoadStatus.None;
        public List<SearchProject> searchProjectList
        {
            get { return _searchProjectList; }
        }
        public LoadStatus status
        {
            get { return _status; }
        }

        public SearchProjectListSplitFileLoader()
        {
            _dataFileName = AppGlobalSettings.dataFileName;
            _searchProjectList = new List<SearchProject>();
        }

        private Delegate.OnStatusChangedDelegate _onStatusChangedDelegate = null;
        public Delegate.OnStatusChangedDelegate onStatusChangedDelegate
        {
            get { return _onStatusChangedDelegate; }
        }

        public void SetOnStatusChanged(Delegate.OnStatusChangedDelegate onStatusChanged)
        {
            _onStatusChangedDelegate = onStatusChanged;
        }

        public void Execute()
        {
            _status = LoadStatus.Reading;

            if (_dataFileName == "")
            {

                _status = LoadStatus.FileNameIsEmpty;
                onStatusChangedDelegate?.Invoke(_status);
                throw new Exception("Имя файла отсутствует");

            }
            if (!File.Exists(_dataFileName))
            {

                _status = LoadStatus.FileNotExists;
                onStatusChangedDelegate?.Invoke(_status);
                throw new FileNotFoundException();
            }


            StreamReader sr = null;
            using (sr = new StreamReader(_dataFileName))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string str = sr.ReadLine();
                        string[] arr = str.Split('|');
                        SearchProject newSearchProject = new SearchProject()
                        {
                            year = arr[0],
                            director = arr[1],
                            diamAntenna = Convert.ToInt32(arr[2]),
                            frequency = Convert.ToInt32(arr[3])
                        };
                        _searchProjectList.Add(newSearchProject);
                    }
                    catch (Exception ex)
                    {
                        LogUtility.ErrorLog(ex);
                        _status = LoadStatus.GeneralError;
                    }

                }
            }
            _status = LoadStatus.Success;
            onStatusChangedDelegate?.Invoke(_status);
        }
    }
}
