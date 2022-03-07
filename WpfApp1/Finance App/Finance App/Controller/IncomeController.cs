using Finance_App.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Finance_App.Controller
{
    public class IncomeController
    {
        public void addIncomeToFile(Transaction income)
        {

            List<Transaction> incomeList = GetIncomeList();

            incomeList.Add(income);

            string jsonString = JsonSerializer.Serialize(incomeList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeList.txt");
            writer.Write(jsonString);
            writer.Close();


        }

        public void addIncomeListToFile(List<Transaction> incomeList)
        {

            string jsonString = JsonSerializer.Serialize(incomeList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeList.txt");
            writer.Write(jsonString);
            writer.Close();


        }

        public List<Transaction> GetIncomeList()
        {

            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/IncomeList.txt");
                String json = reader.ReadToEnd();
                reader.Close();

                List<Transaction> incomeList = JsonSerializer.Deserialize<List<Transaction>>(json)!;

                return incomeList;
            }catch (Exception ex)
            {
                List<Transaction> incomeList = new List<Transaction>();
                return incomeList;
            }

        }
    }
}
