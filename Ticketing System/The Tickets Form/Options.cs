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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        OptionsClass optionsClass = new OptionsClass();

        private List<OptionsClass> slots = new List<OptionsClass>();

        DateTime currentTime = DateTime.Now;

        public int FirstTicketNumber;
        public int GuestPerWindow;
        public int NumberOfSlots;
        public int MinPerWindow;





        public List<OptionsClass> GetTimeSlot()
        {
            this.ShowDialog();
            return slots;
        }

        public int FirstTicketNumber1()
        {
            return FirstTicketNumber;
        }

        public int GuestPerWindow1()
        {
            return GuestPerWindow;
        }

        public int NumberOfSlots1()
        {
            return NumberOfSlots;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            minutesPerWindow.Text = "5";
            guestsPerWindow.Text = "5";
            startTime.Text = currentTime.ToShortTimeString();
            endTime.Text = currentTime.AddHours(4).ToShortTimeString();
            firstTicketNumber.Text = "1";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                MinPerWindow = int.Parse(minutesPerWindow.Text);
                GuestPerWindow = int.Parse(guestsPerWindow.Text);
                DateTime srtTime = DateTime.Parse(startTime.Text);
                DateTime enTime = DateTime.Parse(endTime.Text);
                FirstTicketNumber = int.Parse(firstTicketNumber.Text);


                TimeSpan totalTimeLength = enTime - srtTime;
                NumberOfSlots = (((int)Math.Round(totalTimeLength.TotalMinutes)) / MinPerWindow);


                for (int i = 0; i < NumberOfSlots; i++)
                {
                    optionsClass = new OptionsClass(0, MinPerWindow, srtTime, srtTime.AddMinutes(MinPerWindow));
                    slots.Add(optionsClass);
                    srtTime = srtTime.AddMinutes(MinPerWindow);
                }

                this.Close();
            }
            


        }

        private bool IsValidData()
        {
            return Validator.IsInt32(minutesPerWindow) &&
                   Validator.IsInt32(guestsPerWindow) &&
                   Validator.IsDateTime(startTime)&&
                   Validator.IsDateTime(endTime)&&
                   Validator.IsInt32(firstTicketNumber)&&
                   Validator.IsDateTimeEqualsTwoTimeSlots(startTime,endTime,minutesPerWindow);
          
           
        }
    }
}
