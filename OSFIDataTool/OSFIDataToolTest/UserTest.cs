using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSFIDataTool;
using System.Linq;

namespace OSFIDataToolTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestReadTextFile()
        {
            var inputPath = @"C:\Blake\2016-2-pc.txt";
            var repository = new Repository();
            var dataList = repository.ReadTextFile(inputPath);

            Assert.AreNotEqual(0, dataList.Count());
        }

        [TestMethod]
        public void TestWriteTextFile()
        {
            var inputPath = @"C:\Blake\2016-1-pc.txt";
            var outputPath = @"C:\Blake\Output.xlsx";
            var reportCode = "1060";
            var repository = new Repository();
            var dataList = repository.ReadTextFile(inputPath);

            repository.WriteExcelFile(outputPath, reportCode, dataList.Where(d => string.Compare(d.ReportCode, reportCode, true)==0));
        }
    }
}
