using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TwinCAT.Ads;

namespace PLCService
{
    public class PLCService
    {
        private readonly TcAdsClient _client;
        private readonly Timer _timer;
        private readonly int _scansPerSecond = 4;
        private DateTime _lastScanTime;

        private volatile object _locker = new object();

        public PLCService()
        {
            _client = new TcAdsClient();
            _timer = new Timer();
            _timer.Interval = 1000/_scansPerSecond;
            _timer.Elapsed += OnTimerElapsed;
        }

        public ConnectionStates ConnectionStates { get; private set; }

        public double Col1 { get; private set; }

        public double Col2 { get; private set; }

        public double AirTank { get; private set; }

        public double ProdTank { get; private set; }

        public double Purity { get; private set; }

        public double Flow { get; private set; }

        public double Consumption { get; private set; }

        public double Temp { get; private set; }

        public TimeSpan ScanTime { get; private set; }

        public event EventHandler ValuesRefreshed;

        public void Connect(string ipAddress, int rack, int slot)
        {

        }
    }
}
