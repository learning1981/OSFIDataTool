using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSFIDataTool;
using System.Collections.Generic;
using System.Linq;

namespace OSFIDataToolTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestReadTextFile()
        {
            var inputPath1 = @"C:\Blake\2016-2-pc.txt";
            var repository = new Repository();
            var dataList = repository.ReadTextFile(inputPath1);

            Assert.AreNotEqual(0, dataList.Count());
        }

        [TestMethod]
        public void TestWriteTextFile()
        {
            var inputPath1 = @"C:\Blake\2016-1-pc.txt";
            var inputPath2 = @"C:\Blake\2016-2-pc.txt";
            var outputPath = @"C:\Blake\Output.xlsx";
            var companyCode = "A420";
            var reportCode = "1060";
            var repository = new Repository();
            var dataList = new List<Data>();

            dataList.AddRange(repository.ReadTextFile(inputPath1));
            dataList.AddRange(repository.ReadTextFile(inputPath2));

            var filterList = dataList.Where(d => d.CompanyCode == companyCode && d.ReportCode == reportCode);

            repository.WriteExcelFile(outputPath, companyCode, reportCode, filterList);
        }
    }
}
