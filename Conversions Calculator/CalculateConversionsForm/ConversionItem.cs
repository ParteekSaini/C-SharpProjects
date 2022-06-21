using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateConversionsForm
{
    public class ConversionItem
    {

        public ConversionItem() { }

        public ConversionItem(string from , string to , double multiplier)
        {
            From = from;
            To = to;
            Multiplier = multiplier;
        }

        public string From { get; set; }

        public string To { get; set; }

        public double Multiplier  { get; set; }

        
    }
}
