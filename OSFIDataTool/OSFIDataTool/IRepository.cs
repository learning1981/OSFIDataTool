using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OSFIDataTool
{
    public interface IRepository
    {
        IEnumerable<Data> ReadTextFile(string fullPath);

        void WriteExcelFile(string outputPath, string reportCode, IEnumerable<Data> collection);
    }
}