using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateConversionsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ConversionItem> conversionItems = null;

        private void form_Load(object sender, EventArgs e)
        {

            
            conversionItems = ConversionsDB.GetItems(@"..\..\..\Conversions.txt");

            FillItemListBox();
        }

        private void FillItemListBox()
        {
            conversionsListBox.Items.Clear();
            foreach (ConversionItem conversionItem in conversionItems)
            {
                string row = conversionItem.From.ToString() + " To " + conversionItem.To.ToString();
                conversionsListBox.Items.Add(row);

            }
        }

        private void manageConversionsButton_Click(object sender, EventArgs e)
        {
            ManageConversionsForm manageConversionsForm = new ManageConversionsForm();
            manageConversionsForm.ShowDialog();
            conversionItems = ConversionsDB.GetItems(@"..\..\..\Conversions.txt");

            FillItemListBox();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {

            if (IsValidData())
            {
                outputListBox.Items.Clear();
                for (int i = 0; i <= conversionItems.Count - 1; i++)
                {
                    if (conversionsListBox.GetSelected(i))
                    {
                        string row = valueToConvertTextBox.Text.ToString() + " " + conversionItems[i].From.ToString() + " = "
                        + (Double.Parse(valueToConvertTextBox.Text) * conversionItems[i].Multiplier).ToString("F") + " " +
                        conversionItems[i].To.ToString();
                        outputListBox.Items.Add(row);
                    }
                }
            }
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            conversionsListBox.ClearSelected();
            valueToConvertTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(valueToConvertTextBox)&&
                Validator.IsDouble(valueToConvertTextBox)&&
                Validator.IsNegative(valueToConvertTextBox);
        }
    }
}
