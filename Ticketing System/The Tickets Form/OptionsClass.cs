using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Tickets_Form
{
    public class OptionsClass
    {
        public int TicketsIssued;
        public int TimeSlotLength;
        public DateTime StartTime;
        public DateTime EndTime;

        public OptionsClass()
        {
            
        }

        public void SetIncrementTicketsIssued()
        {
            TicketsIssued = TicketsIssued + 1;
        }

        public OptionsClass(int ticketsIssued, int timeSlotLength, DateTime startTime, DateTime endTime)
        {
            TicketsIssued = ticketsIssued;
            TimeSlotLength = timeSlotLength;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
