using System;
using System.Globalization;
using System.IO;

namespace Section13201_Arquivos
{
    public class UserStory201
    {
        static void Main()
        {
            string soldItemsPath = Directory.GetCurrentDirectory() + @"..\..\..\..\Vendas\SoldItems.csv";

            string[] soldItems = File.ReadAllLines(soldItemsPath);
            string[] sumaryItems = new string[soldItems.Length];
            double[] sumaryAmount = new double[soldItems.Length];
            string[] summary = new string[soldItems.Length];

            Console.WriteLine("*** Sold Items ***\n");

            for (int n = 0; n < soldItems.Length; n++)
            {
                string[] columns = soldItems[n].Split(';');
                double invoicedAmountItem = double.Parse(columns[1], CultureInfo.InvariantCulture) * int.Parse(columns[2]);
                sumaryItems[n] = columns[0];
                sumaryAmount[n] = invoicedAmountItem;

                summary[n] = sumaryItems[n] + ";" + sumaryAmount[n].ToString("F2", CultureInfo.InvariantCulture);

                string soldItem = soldItems[n].Replace(";", ", ");
                Console.WriteLine(soldItem);
            }

            string summaryPath = Directory.GetCurrentDirectory() + @"..\..\..\..\Vendas\out\";
            string summaryPathFile = Directory.GetCurrentDirectory() + @"..\..\..\..\Vendas\out\summary.csv";

            if (!Directory.Exists(summaryPath))
            {
                Directory.CreateDirectory(summaryPath);
            }

            Console.WriteLine("\n\n\n*** Amount per item ***\n");
            using (StreamWriter summaryWriter = File.AppendText(summaryPathFile))
            {
                foreach (string line in summary)
                {
                    summaryWriter.WriteLine(line);
                    string summaryLine = line.Replace(";", ", ");
                    Console.WriteLine(summaryLine);
                }
            }
        }
    }
}
