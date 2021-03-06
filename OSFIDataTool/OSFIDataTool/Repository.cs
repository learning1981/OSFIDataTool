﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OSFIDataTool
{
    public class Repository : IRepository
    {
        public IEnumerable<Data> ReadTextFile(string inputFile)
        {
            var listData = new List<Data>();

            if (!File.Exists(inputFile))
            {
                DisplayGeneralMessage(inputFile + " does not exist.");
            }
            else
            {
                try
                {
                    // Read file line by line to extract data to the list of Data object
                    foreach (string line in File.ReadLines(inputFile))
                    {
                        var data = new Data
                        {
                            StatementNumber = line.Substring(0, 2),
                            Year = line.Substring(2, 2),
                            CompanyCode = line.Substring(4, 4),
                            ReportCode = line.Substring(8, 4),
                            Row = line.Substring(12, 2),
                            Column = line.Substring(14, 2)
                        };
                        Double.TryParse(line.Substring(16, 16), out double tempValue);
                        data.Value = tempValue;
                        listData.Add(data);
                    }
                }
                catch (Exception ex)
                {
                    DisplayErrorMessage("An error occured while reading text file" + Environment.NewLine + ex.Message);
                }
            }

            return listData;
        }

        public void WriteExcelFile(string outputPath, string companyCode, string reportCode, IEnumerable<Data> collection)
        {
            if (!File.Exists(outputPath))
            {
                DisplayGeneralMessage(outputPath + " does not exist.");
            }
            else
            {
                try
                {
                    var fileInfo = new FileInfo(outputPath);

                    using (var p = new ExcelPackage(fileInfo))
                    {
                        var sheetName = string.Concat(companyCode, reportCode);
                        var found = false;

                        foreach (var worksheet in p.Workbook.Worksheets)
                        {
                            if (string.Compare(worksheet.Name, sheetName, true) == 0)
                            {
                                found = true;
                                foreach (var data in collection)
                                {
                                    var key = data.CellLookup;
                                    worksheet.Cells[CellLookupDictionary[key]].Value = data.Value;
                                }
                            }
                        }

                        p.Save();

                        if (!found)
                        {
                            DisplayGeneralMessage("Please create sheet: " + sheetName);
                        }
                        else
                        {
                            DisplayGeneralMessage("Data is populated to the excel file.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    DisplayErrorMessage("An error occured while reading text file" + Environment.NewLine + ex.Message);
                }
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

        private Dictionary<string, string> CellLookupDictionary
        {
            get
            {
                return new Dictionary<string, string>
                    {
                        { "0101", "E12" },
                        { "0102", "F12" },
                        { "0103", "G12" },
                        { "0104", "H12" },
                        { "0105", "I12" },
                        { "0201", "E13" },
                        { "0202", "F13" },
                        { "0203", "G13" },
                        { "0204", "H13" },
                        { "0205", "I13" },
                        { "0401", "E14" },
                        { "0402", "F14" },
                        { "0403", "G14" },
                        { "0404", "H14" },
                        { "0405", "I14" },
                        { "0501", "E15" },
                        { "0502", "F15" },
                        { "0503", "G15" },
                        { "0504", "H15" },
                        { "0505", "I15" },
                        { "0601", "E16" },
                        { "0602", "F16" },
                        { "0603", "G16" },
                        { "0604", "H16" },
                        { "0605", "I16" },
                        { "0701", "E17" },
                        { "0702", "F17" },
                        { "0703", "G17" },
                        { "0704", "H17" },
                        { "0705", "I17" },
                        { "0801", "E18" },
                        { "0802", "F18" },
                        { "0803", "G18" },
                        { "0804", "H18" },
                        { "0805", "I18" },
                        { "3001", "E21" },
                        { "3002", "F21" },
                        { "3003", "G21" },
                        { "3004", "H21" },
                        { "3005", "I21" },
                        { "3101", "E22" },
                        { "3102", "F22" },
                        { "3103", "G22" },
                        { "3104", "H22" },
                        { "3105", "I22" },
                        { "3301", "E23" },
                        { "3302", "F23" },
                        { "3303", "G23" },
                        { "3304", "H23" },
                        { "3305", "I23" },
                        { "3501", "E24" },
                        { "3502", "F24" },
                        { "3503", "G24" },
                        { "3504", "H24" },
                        { "3505", "I24" },
                        { "3601", "E25" },
                        { "3602", "F25" },
                        { "3603", "G25" },
                        { "3604", "H25" },
                        { "3605", "I25" },
                        { "4001", "E26" },
                        { "4002", "F26" },
                        { "4003", "G26" },
                        { "4004", "H26" },
                        { "4005", "I26" },
                        { "4101", "E27" },
                        { "4102", "F27" },
                        { "4103", "G27" },
                        { "4104", "H27" },
                        { "4105", "I27" },
                        { "4401", "E28" },
                        { "4402", "F28" },
                        { "4403", "G28" },
                        { "4404", "H28" },
                        { "4405", "I28" },
                        { "4501", "E29" },
                        { "4502", "F29" },
                        { "4503", "G29" },
                        { "4504", "H29" },
                        { "4505", "I29" },
                        { "4601", "E30" },
                        { "4602", "F30" },
                        { "4603", "G30" },
                        { "4604", "H30" },
                        { "4605", "I30" },
                        { "4701", "E31" },
                        { "4702", "F31" },
                        { "4703", "G31" },
                        { "4704", "H31" },
                        { "4705", "I31" },
                        { "4801", "E32" },
                        { "4802", "F32" },
                        { "4803", "G32" },
                        { "4804", "H32" },
                        { "4805", "I32" },
                        { "7001", "E34" },
                        { "7002", "F34" },
                        { "7003", "G34" },
                        { "7004", "H34" },
                        { "7005", "I34" },
                        { "7201", "E35" },
                        { "7202", "F35" },
                        { "7203", "G35" },
                        { "7204", "H35" },
                        { "7205", "I35" },
                        { "7401", "E36" },
                        { "7402", "F36" },
                        { "7403", "G36" },
                        { "7404", "H36" },
                        { "7405", "I36" },
                        { "5001", "E40" },
                        { "5002", "F40" },
                        { "5003", "G40" },
                        { "5004", "H40" },
                        { "5005", "I40" },
                        { "5201", "E41" },
                        { "5202", "F41" },
                        { "5203", "G41" },
                        { "5204", "H41" },
                        { "5205", "I41" },
                        { "5401", "E42" },
                        { "5402", "F42" },
                        { "5403", "G42" },
                        { "5404", "H42" },
                        { "5405", "I42" },
                        { "6001", "E44" },
                        { "6002", "F44" },
                        { "6003", "G44" },
                        { "6004", "H44" },
                        { "6005", "I44" },
                        { "6201", "E45" },
                        { "6202", "F45" },
                        { "6203", "G45" },
                        { "6204", "H45" },
                        { "6205", "I45" },
                        { "6401", "E46" },
                        { "6402", "F46" },
                        { "6403", "G46" },
                        { "6404", "H46" },
                        { "6405", "I46" },
                        { "6601", "E47" },
                        { "6602", "F47" },
                        { "6603", "G47" },
                        { "6604", "H47" },
                        { "6605", "I47" },
                        { "6801", "E48" },
                        { "6802", "F48" },
                        { "6803", "G48" },
                        { "6804", "H48" },
                        { "6805", "I48" },
                        { "1901", "E53" },
                        { "1902", "F53" },
                        { "1903", "G53" },
                        { "1904", "H53" },
                        { "1905", "I53" },
                        { "2001", "E54" },
                        { "2002", "F54" },
                        { "2003", "G54" },
                        { "2004", "H54" },
                        { "2005", "I54" },
                        { "2101", "E55" },
                        { "2102", "F55" },
                        { "2103", "G55" },
                        { "2104", "H55" },
                        { "2105", "I55" },
                        { "2201", "E56" },
                        { "2202", "F56" },
                        { "2203", "G56" },
                        { "2204", "H56" },
                        { "2205", "I56" },
                        { "2301", "E57" },
                        { "2302", "F57" },
                        { "2303", "G57" },
                        { "2304", "H57" },
                        { "2305", "I57" },
                        { "2401", "E58" },
                        { "2402", "F58" },
                        { "2403", "G58" },
                        { "2404", "H58" },
                        { "2405", "I58" },
                        { "2501", "E59" },
                        { "2502", "F59" },
                        { "2503", "G59" },
                        { "2504", "H59" },
                        { "2505", "I59" },
                        { "2601", "E60" },
                        { "2602", "F60" },
                        { "2603", "G60" },
                        { "2604", "H60" },
                        { "2605", "I60" },
                        { "2701", "E61" },
                        { "2702", "F61" },
                        { "2703", "G61" },
                        { "2704", "H61" },
                        { "2705", "I61" }
                    };
            }
        }
    }
}
