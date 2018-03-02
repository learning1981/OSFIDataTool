using System.Windows.Forms;

namespace OSFIDataTool
{
    public partial class OSFIDataTool : Form
    {
        private IViewModel _viewModel;

        public OSFIDataTool(IViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
        }

        private void ButtonLoadFile_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxInputFile1.Text) || string.IsNullOrEmpty(TextBoxInputFile1.Text))
            {
                DisplayMessage("Please provide 2 input text files.");
            }
            else
            {
                _viewModel.InputFile1 = TextBoxInputFile1.Text;
                _viewModel.InputFile2 = TextBoxInputFile2.Text;
                _viewModel.LoadInputFiles();
            }
        }

        private void ButtonPopulateData_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxOutputFile.Text))
            {
                DisplayMessage("Please provide the output excel file.");
            }
            else if (string.IsNullOrEmpty(TextBoxCompanyCode.Text))
            {
                DisplayMessage("Please provide the company code.");
            }
            else if (string.IsNullOrEmpty(TextBoxReportCode.Text))
            {
                DisplayMessage("Please provide the report code.");
            }
            else
            {
                _viewModel.OutputFile = TextBoxOutputFile.Text;
                _viewModel.CompanyCode = TextBoxCompanyCode.Text;
                _viewModel.ReportCode = TextBoxReportCode.Text;
                _viewModel.PopulateData();
            }
        }

        private void ButtonExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
