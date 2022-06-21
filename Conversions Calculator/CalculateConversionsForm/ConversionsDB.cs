using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CalculateConversionsForm
{
    class ConversionsDB
    {
        public static List<ConversionItem> GetItems(string path)
        {

           
            List<ConversionItem> conversionItems = new List<ConversionItem>();

            if (!File.Exists(path))
            {
                
                File.Create(path);
            }

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                
                string[] columns = row.Split('|');
                ConversionItem conversionItem = new ConversionItem();
                conversionItem.From = columns[0];
                conversionItem.To = columns[1];
                conversionItem.Multiplier = Double.Parse(columns[2]);
                conversionItems.Add(conversionItem);
                
            }
            
            textIn.Close();

            return conversionItems;
        }

        public static void SaveItems(List<ConversionItem> conversionItems , string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach(ConversionItem conversionItem in conversionItems)
            {
                textOut.Write(conversionItem.From.ToString() + "|");
                textOut.Write(conversionItem.To.ToString() + "|");
                textOut.WriteLine(conversionItem.Multiplier.ToString());
            }

            textOut.Close();
        }

        public static void AddItem(ConversionItem conversionItem , string path)
        {
            

            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            textOut.Write(conversionItem.From.ToString() + "|");
            textOut.Write(conversionItem.To.ToString() + "|");
            textOut.WriteLine(conversionItem.Multiplier.ToString());
            textOut.Close();
        }
    }
}
