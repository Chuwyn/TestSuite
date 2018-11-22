using DesktopUI.Abstract;
using DesktopUI.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesktopUI.ViewModels
{
    public class TestViewModel : ObservableObject
    {
        private TestDataModel _currentTestData;
        private ICommand _getTestDataCommand;

        public TestDataModel CurrentTestData
        {
            get
            {
                if(_currentTestData == null)
                {
                    GetTestData();
                }
                return _currentTestData;
            }
            set
            {
                if(value != _currentTestData)
                {
                    _currentTestData = value;
                    OnPropertyChanged("CurrentTestData");
                }
            }
        }

        public SeriesCollection TestDataSeries = new SeriesCollection
        {
            new LineSeries
            {
                Values = new ChartValues<double> {3, 5, 7, 4}
            },
            new ColumnSeries
            {
                Values = new ChartValues<decimal> { 5, 6, 2, 7}
            }
        };

        public ICommand GetTestDataCommand
        {
            get
            {
                if(_getTestDataCommand == null)
                {
                    _getTestDataCommand = new RelayCommand(
                        param => GetTestData()
                    );
                }
                return _getTestDataCommand;
            }
        }

        private void GetTestData()
        {
            TestDataModel m = new TestDataModel
            {
                Col1 = 4.0,
                Col2 = 5.3,
                AirTank = 8.3,
                ProdTank = 1.5,
                Temp = 24.2,
                Flow = 125,
                Consumption = 1000,
                Purity = 99.999
            };
            CurrentTestData = m;
        }
    }
}
