using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OSFIDataTool
{
    public class ViewModel : IViewModel
    {
        private IRepository _repository;
        private List<Data> _allInputData;

        public string InputFile1 { get; set; }
        public string InputFile2 { get; set; }
        public string OutputFile { get; set; }
        public string CompanyCode { get; set; }
        public string ReportCode { get; set; }

        public ViewModel(IRepository repository)
        {
            _repository = repository;
            _allInputData = new List<Data>();
        }

        public void LoadInputFiles()
        {
            try
            {
                _allInputData.Clear();
                _allInputData.AddRange(_repository.ReadTextFile(InputFile1));
                _allInputData.AddRange(_repository.ReadTextFile(InputFile2));

                DisplayGeneralMessage("Text files are loaded successfully.");
            }
            catch (Exception ex)
            {
                DisplayErrorMessage("Error occurred when loading text files" + Environment.NewLine + ex.Message);
            }
        }

        public void PopulateData()
        {
            try
            {
                if (_allInputData.Count <= 0)
                {
                    DisplayGeneralMessage("The input data is empty. Please load the input text files first and then populate the data");
                }
                else
                {
                    var filteredList = _allInputData.Where(d => string.Compare(d.CompanyCode, CompanyCode, true) == 0 && string.Compare(d.ReportCode, ReportCode, true) == 0);

                    _repository.WriteExcelFile(OutputFile, CompanyCode, ReportCode, filteredList);
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage("Error occurred when writing to excel file" + Environment.NewLine + ex.Message);
            }
        }

        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayGeneralMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
