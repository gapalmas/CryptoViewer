using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoViewer.Models
{
    public class CoinGeckoData
    {
        public decimal usd { get; set; }
        public decimal usd_24h_change { get; set; }
        public decimal mxn { get; set; }
        public decimal mxn_24h_change { get; set; }
    }
}
