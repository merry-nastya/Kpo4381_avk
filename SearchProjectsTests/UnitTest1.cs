using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4381_avk.Lib;
using System.Collections.Generic;
using System.IO;

namespace SearchProjectsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SaveSplitFileTest()
        {
            List<SearchProject> searchProjects = new List<SearchProject>();
            SearchProject testSearchProject = new SearchProject()
            {
                    year = "1960",
                    director = "Дрейк",
                    diamAntenna = 26,
                    frequency = 1420
            };
            searchProjects.Add(testSearchProject);
            ISearchProjectListSaver saver = new SearchProjectListSplitFileSaver("NewSearchProject.txt");
            saver.SaveFile(searchProjects);

            ISearchProjectListLoader loader = new SearchProjectListSplitFileLoader("NewSearchProject.txt");
            loader.Execute();
            Assert.AreEqual(loader.searchProjectList[0].year, testSearchProject.year);
            Assert.AreEqual(loader.searchProjectList[0].director, testSearchProject.director);
            Assert.AreEqual(loader.searchProjectList[0].diamAntenna, testSearchProject.diamAntenna);
            Assert.AreEqual(loader.searchProjectList[0].frequency, testSearchProject.frequency);
            File.WriteAllText("NewSearchProject.txt", "");

        }
    }
}
