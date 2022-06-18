using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Tickets_Form
{
    class Ticket
    {
        public int TicketNumber;
        public DateTime TimeSlot;

        public Ticket(int ticketNumber, DateTime timeSlot)
        {
            TicketNumber = ticketNumber;
            TimeSlot = timeSlot;
        }

        public Ticket( DateTime timeSlot)
        {
            
            TimeSlot = timeSlot;
        }

        public Ticket()
        {

        }

        public void GetIncrementTicket()
        {
            TicketNumber = TicketNumber + 1;
        }


       

        public String GetDisplayText()
        {
            return "Ticket " + this.TicketNumber.ToString()+":" + "    " + this.TimeSlot.ToShortTimeString();
        }
    }
}
