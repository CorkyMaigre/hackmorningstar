using System;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace hackmorningstar.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        RelayCommand _openCommand;
        RelayCommand _searchCommand;

        string content;


        public MainWindowViewModel()
        {

        }
        
        private string _ticker;
        public string Ticker
        {
            get { return _ticker; }
            set
            {
                if (value != _ticker)
                {
                    _ticker = value;
                    NotifyPropertyChanged("Ticker");
                }
            }
        }

        public ICommand OpenCommand
        {
            get
            {
                if (_openCommand == null)
                {
                    _openCommand = new RelayCommand(param => this.OpenCommandExecute(), param => this.OpenCommandCanExecute);
                }
                return _openCommand;
            }
        }

        void OpenCommandExecute()
        {
            // Create OpenFileDialog
            var dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (.txt)|*.txt|All files (.)|*.";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
            }

            //FileContent = System.IO.File.ReadAllText(FilePath);
        }

        bool OpenCommandCanExecute
        {
            get { return true; }
        }

        public ICommand SearchCommand
        {
            get
            {
                if (_searchCommand == null)
                {
                    _searchCommand = new RelayCommand(param => this.SearchCommandExecute(), param => this.SearchCommandCanExecute);
                }
                return _searchCommand;
            }
        }

        void SearchCommandExecute()
        {

            string key_ratios_csv_url = "http://financials.morningstar.com/ajax/exportKR2CSV.html?t=" + Ticker;

            string financials_income_statement_csv_url =
                    "http://financials.morningstar.com/ajax/ReportProcess4CSV.html?t=" +
                    Ticker + "&region=USA&culture=en_us&reportType=is&period=12&dataType=" +
                            "A&order=asc&columnYear=5&rounding=3&view=raw&productCode=usa&r=" +
                            "283305&denominatorView=raw&number=3";

            string financials_balance_sheet_csv_url =
                    "http://financials.morningstar.com/ajax/ReportProcess4CSV.html?&t=" +
                    Ticker + "&region=usa&culture=en-US&cur=&reportType=bs&period=12&dataType=" +
                            "A&order=asc&columnYear=5&curYearPart=1st5year&rounding=3&view=raw&r=" +
                            "865104&denominatorView=raw&number=3";

            string financials_cash_flow_csv_url =
                    "http://financials.morningstar.com/ajax/ReportProcess4CSV.html?&t=" +
                    Ticker + "&region=usa&culture=en-US&cur=&reportType=cf&period=12&dataType=" +
                            "A&order=asc&columnYear=5&curYearPart=1st5year&rounding=3&view=raw&r=" +
                            "907543&denominatorView=raw&number=3";
            /*
            string historical_prices_csv_url =
                                    "http://real-chart.finance.yahoo.com/table.csv?s=" +
                                    Ticker + "&a=" + month + "&b=" + Integer.toString(Integer.parseInt(day) - 10) + "&c=" + year
                                                + "&d=" + month + "&e=" + day + "&f=" + year + "&g=d&ignore=.csv";*/

            var client = new WebClient();
            bool isKeyRatios = false;
            bool isFinancialsIncomeStatement = false;
            bool isFinancialsBalanceSheet = false;
            bool isFinancialsCashFlow = false;


            if (CheckForInternetConnection(key_ratios_csv_url))
            {
                isKeyRatios = true;
                content += client.DownloadString(key_ratios_csv_url);
            }   
            if (CheckForInternetConnection(financials_income_statement_csv_url))
            {
                isFinancialsIncomeStatement = true;
                content += client.DownloadString(financials_income_statement_csv_url);
            }  
            if (CheckForInternetConnection(financials_balance_sheet_csv_url))
            {
                isFinancialsBalanceSheet = true;
                content += client.DownloadString(financials_balance_sheet_csv_url);
            }   
            if (CheckForInternetConnection(financials_cash_flow_csv_url))
            {
                isFinancialsCashFlow = true;
                content += client.DownloadString(financials_cash_flow_csv_url);
            }


            if (isKeyRatios && isFinancialsIncomeStatement && isFinancialsBalanceSheet && isFinancialsCashFlow)
            {
                //System.IO.File.WriteAllText("Files/"+Ticker+".csv", content);
                System.IO.File.WriteAllText(Ticker + ".csv", content);
                MessageBox.Show(Ticker + ".csv", "Done", MessageBoxButton.OK, MessageBoxImage.Information);

                // Add text to the end of the file
                //System.IO.File.AppendAllText(FilePath, FileContent);
            }
            else
            {
                MessageBox.Show("Data can not be retrieved, verify the name of " + Ticker + "or check the network connection" , "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        bool SearchCommandCanExecute
        {
            get { return true; }
        }

        public static bool CheckForInternetConnection(string url)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead(url))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }
}



