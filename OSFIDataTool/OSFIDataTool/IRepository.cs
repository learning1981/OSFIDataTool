using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OSFIDataTool
{
    public interface IRepository
    {
        IEnumerable<Data> ReadTextFile(string inputFile);

        void WriteExcelFile(string outputPath, string companyCode, string reportCode, IEnumerable<Data> collection);
    }
}