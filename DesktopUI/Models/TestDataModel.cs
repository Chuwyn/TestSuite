using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Models
{
    class TestDataModel : INotifyPropertyChanged
    {
        // Pressure Data
        private double _col1;
        private double _col2;
        private double _airTank;
        private double _prodTank;

        // Other Data
        private double _temp;
        private double _purity;
        private double _flow;
        private double _consumption;

        // Getters/Setters
        public double Col1
        {
            get { return _col1; }
            set
            {
                _col1 = value;
                OnPropertyChanged("Col1");
            }
        }

        public double Col2
        {
            get { return _col2; }
            set
            {
                _col2 = value;
                OnPropertyChanged("Col2");
            }
        }

        public double AirTank
        {
            get { return _airTank; }
            set
            {
                _airTank = value;
                OnPropertyChanged("AirTank");
            }
        }

        public double ProdTank
        {
            get { return _prodTank; }
            set
            {
                _prodTank = value;
                OnPropertyChanged("ProdTank");
            }
        }

        public double Temp
        {
            get { return _temp; }
            set
            {
                _temp = value;
                OnPropertyChanged("Temp");
            }
        }

        public double Purity
        {
            get { return _purity; }
            set
            {
                _purity = value;
                OnPropertyChanged("Purity");
            }
        }

        public double Flow
        {
            get { return _flow; }
            set
            {
                _flow = value;
                OnPropertyChanged("Flow");
            }
        }

        public double Consumption
        {
            get { return _consumption; }
            set
            {
                _consumption = value;
                OnPropertyChanged("Consumption");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
