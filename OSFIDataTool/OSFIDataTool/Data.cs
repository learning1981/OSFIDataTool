namespace OSFIDataTool
{
    public class Data
    {
        public string OriginalText { get; set; }
        public string StatementNumber { get; set; }
        public string Year { get; set; }
        public string CompanyCode { get; set; }
        public string ReportCode { get; set; }
        public string Row { get; set; }
        public string Column { get; set; }
        public string DataArea { get; set; }
        public double Value { get; set; }

        public string CellLookup => string.Concat(Row, Column);
    }
}
