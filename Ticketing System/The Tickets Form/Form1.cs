using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Tickets_Form
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private List<Ticket> tickets = new List<Ticket>();

        private List<OptionsClass> slots = new List<OptionsClass>();

        private Options options = new Options();

        Ticket ticket = new Ticket();

        Boolean FirstClick = true;

         OptionsClass optionsClass = new  OptionsClass();
        

        public int FirstTicketNumber;
        public int GuestPerWindow;
        public int MinutesPerWindow;
        int NumberOfSlots;
        int SlotNumber=0;
        int issuedTicket;
        DateTime FirstEndTime;

        DateTime currentTime;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            this.Text = currentTime.ToLongTimeString();
            RemoveTickets();
            FillTicketsListBox();
            totalTicketsOutstandinglabel.Text = (tickets.Count).ToString();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            slots = options.GetTimeSlot();
            FirstTicketNumber = options.FirstTicketNumber;
            
            ticket = new Ticket();
            ticket.TicketNumber = options.FirstTicketNumber;

            issuedTicket = options.FirstTicketNumber;
            
            GuestPerWindow = options.GuestPerWindow;
          
            NumberOfSlots = options.NumberOfSlots;

            MinutesPerWindow = options.MinPerWindow;



        }
        


        private void issueTicketButton_Click(object sender, EventArgs e)
        {
            DateTime presentTime = DateTime.Now;
            

            for (int i = SlotNumber; i < NumberOfSlots; i++)
            {
                if (DateTime.Compare(currentTime,slots[i].EndTime)<0)
                {
                    
                    if (slots[i].TicketsIssued<=GuestPerWindow-1)
                    {
                        
                        ticket = new Ticket(issuedTicket,slots[i].StartTime);
                        
                        tickets.Add(ticket);
                        slots[i].TicketsIssued = slots[i].TicketsIssued + 1;
                        issuedTicket++;
                        if (slots[i].TicketsIssued > GuestPerWindow) 
                        {
                            SlotNumber = i;
                        }
                        break;
                    }
                   
                }
               
            }
            nextAvailableEntrylabel.Text = tickets[tickets.Count-1].TimeSlot.AddMinutes(slots[0].TimeSlotLength).ToShortTimeString();
            FillTicketsListBox();
           


        }

        private void FillTicketsListBox()
        {
            ticketsListBox.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            foreach (Ticket c in tickets)
            {
                ticketsListBox.Items.Add(c.GetDisplayText());
            }
        }

        private void RemoveTickets()
        {

            for(int i = 0; i < tickets.Count; i++)
            {
                if (DateTime.Compare(currentTime, tickets[i].TimeSlot.AddMinutes(slots[0].TimeSlotLength)) > 0)
                {
                    tickets.RemoveAt(i);
                }
                if((tickets[i].TimeSlot.AddMinutes(slots[0].TimeSlotLength)-currentTime).TotalMinutes <= MinutesPerWindow)
                {
                   
                    allowedGuestsLabel.Text = tickets[0].TicketNumber.ToString() + "-" + tickets[i].TicketNumber.ToString();
                }
            }
            
        }

        private void CurrentTimeSlot()
        {
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = optionsClass.TimeSlotLength;
            
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            slots = options.GetTimeSlot();
            tickets.Clear();
            FillTicketsListBox();
            FirstTicketNumber = options.FirstTicketNumber;

            ticket = new Ticket();
            ticket.TicketNumber = options.FirstTicketNumber;

            issuedTicket = options.FirstTicketNumber;

            GuestPerWindow = options.GuestPerWindow;

            NumberOfSlots = options.NumberOfSlots;
            MinutesPerWindow = options.MinPerWindow;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
