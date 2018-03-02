namespace OSFIDataTool
{
    public interface IViewModel
    {
        string CompanyCode { get; set; }
        string InputFile1 { get; set; }
        string InputFile2 { get; set; }
        string OutputFile { get; set; }
        string ReportCode { get; set; }

        void LoadInputFiles();
        void PopulateData();
    }
}