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
    public partial class ManageConversionsForm : Form
    {
        public ManageConversionsForm()
        {
            InitializeComponent();
        }

        private List<ConversionItem> conversionItems = null;

        private void addButton_Click(object sender, EventArgs e)
        {
            AddConversionsForm newAddConversionsForm = new AddConversionsForm();
            ConversionItem conversionItem = newAddConversionsForm.GetNewConversionItem();
            if (conversionItem != null)
            {
                
                conversionItems.Add(conversionItem);
                FillItemListBox();
            }
        }

        private void ManageConversionsLoadForm(object sender, EventArgs e)
        {
            conversionItems = ConversionsDB.GetItems(@"..\..\..\Conversions.txt");
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            conversionsListBox.Items.Clear();
            foreach (ConversionItem conversionItem in conversionItems)
            {
                string row = conversionItem.From.ToString() + "|" + conversionItem.To.ToString() + "|" + conversionItem.Multiplier.ToString();
                conversionsListBox.Items.Add(row);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ConversionsDB.SaveItems(conversionItems, @"..\..\..\Conversions.txt");
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int i = conversionsListBox.SelectedIndex;

            if(i != -1)
            {
                ConversionItem conversionItem = (ConversionItem)conversionItems[i];
                string message = "Are you sure you want to delete" + conversionItem.From.ToString() + 
                    "|" + conversionItem.To.ToString() + "|" + conversionItem.Multiplier.ToString();

                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if(button == DialogResult.Yes)
                {
                    conversionItems.Remove(conversionItem);
                }
                FillItemListBox();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restoreDetailsButton_Click(object sender, EventArgs e)
        {
            conversionItems = ConversionsDB.GetItems(@"..\..\..\ConversionsDefault.txt");
            FillItemListBox();
            
        }
    }
}
