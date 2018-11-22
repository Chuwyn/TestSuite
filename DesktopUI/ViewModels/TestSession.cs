using DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels
{
    class TestSession
    {
        public TestDataModel CurrentTestData { get; set; }

        public TestSession()
        {
            CurrentTestData = new TestDataModel
            {
                Col1 = 5.0,
                Col2 = 4.6,
                AirTank = 6.2,
                ProdTank = 1.5,
                Purity = 99.99,
                Consumption = 1000,
                Flow = 100,
                Temp = 25
            };
        }
    }
}
