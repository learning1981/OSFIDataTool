namespace OSFIDataTool
{
    public interface IModel
    {
        void ReadTextFile(string fullPath);

        void WriteExcelFile(string fullPath);
    }
}