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
    public partial class AddConversionsForm : Form
    {
        public AddConversionsForm()
        {
            InitializeComponent();
        }

        private ConversionItem conversionItem = new ConversionItem();

        public ConversionItem GetNewConversionItem()
        {
            this.ShowDialog();
            return conversionItem;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                conversionItem.From = fromTextBox.Text.ToString();
                conversionItem.To = toTextBox.Text.ToString();
                conversionItem.Multiplier = Double.Parse(multiplierTextBox.Text.ToString());
                this.Close();
            }

            
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            conversionItem = null;
            this.Close();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(fromTextBox) &&
                Validator.IsPresent(toTextBox) &&
                Validator.IsPresent(multiplierTextBox)&&
                Validator.IsDouble(multiplierTextBox)&&
                Validator.IsNegative(multiplierTextBox);
        }
    }
}
