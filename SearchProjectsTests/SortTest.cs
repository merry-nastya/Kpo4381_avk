using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4381_avk.Lib;
using System.Collections.Generic;
using System.IO;

namespace SearchProjectsTests
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void SortByDiamAntennaListTest()
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
            SearchProject test2SearchProject = new SearchProject()
            {
                year = "1970",
                director = "Троицкий",
                diamAntenna = 14,
                frequency = 1875
            };
            searchProjects.Add(test2SearchProject);
            ISearchProjectListSaver saver = new SearchProjectListSplitFileSaver("NewSearchProject.txt");
            saver.SaveFile(searchProjects);

            ISearchProjectListLoader loader = new SearchProjectListSplitFileLoader("NewSearchProject.txt");
            loader.Execute();
            loader.Sort("diamAntenna");
            Assert.AreEqual(loader.searchProjectList[0].diamAntenna, 14);
            File.WriteAllText("NewSearchProject.txt", "");

        }
        [TestMethod]
        public void SortByFrequencyListTest()
        {
            List<SearchProject> searchProjects = new List<SearchProject>();
            SearchProject test2SearchProject = new SearchProject()
            {
                year = "1970",
                director = "Троицкий",
                diamAntenna = 14,
                frequency = 1875
            };
            searchProjects.Add(test2SearchProject);
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
            loader.Sort("frequency");
            Assert.AreEqual(loader.searchProjectList[0].frequency, 1420);
            File.WriteAllText("NewSearchProject.txt", "");

        }

        [TestMethod]
        public void SortErrorTest()
        {
            List<SearchProject> searchProjects = new List<SearchProject>();
            SearchProject test2SearchProject = new SearchProject()
            {
                year = "1970",
                director = "Троицкий",
                diamAntenna = 14,
                frequency = 1875
            };
            searchProjects.Add(test2SearchProject);
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
            Assert.ThrowsException<Exception>(() => {
                loader.Sort();

            });    

        }
    }
}
