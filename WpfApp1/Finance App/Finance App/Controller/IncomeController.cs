using Finance_App.Entity;
using Finance_App.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Finance_App.Controller
{
    public class IncomeController
    {
        public void addIncomeToFile(Transaction income)
        {

            List<Transaction> incomeList = GetIncomeList();

            income.Id = findIncomeId();
            incomeList.Add(income);

            string jsonString = JsonSerializer.Serialize(incomeList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeList.txt");
            writer.Write(jsonString);
            writer.Close();


        }

        public void deleteIncomeFromFile(Transaction oldIncome)
        {


            List<Transaction> fullIncomeList = GetIncomeList();
            foreach (Transaction fullIncome in fullIncomeList)
            {
                if (oldIncome.Id == fullIncome.Id)
                {
                    oldIncome = fullIncome;

                }

            }

            fullIncomeList.Remove(oldIncome);

            string jsonString = JsonSerializer.Serialize(fullIncomeList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeList.txt");
            writer.Write(jsonString);
            writer.Close();


        }

        public void updateIncomeListToFile(Transaction oldIncome, Transaction newIncome)
        {

            List<Transaction> fullIncomeList = GetIncomeList();
            foreach (Transaction fullIncome in fullIncomeList)
            {
              if (oldIncome.Id == fullIncome.Id)
                {
                    oldIncome = fullIncome;
                    
                }
               
            }
            newIncome.Id = findIncomeId(); 

            fullIncomeList.Remove(oldIncome);
            fullIncomeList.Add(newIncome);

            string jsonString = JsonSerializer.Serialize(fullIncomeList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeList.txt");
            writer.Write(jsonString);
            writer.Close();


        }

        public List<Transaction> GetIncomeListByFilter()
        {

            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/IncomeList.txt");
                String json = reader.ReadToEnd();
                reader.Close();

                List<Transaction> incomeList = JsonSerializer.Deserialize<List<Transaction>>(json)!;

                List<Transaction> filteredIncomeList = new List<Transaction>();
                foreach (Transaction item in incomeList)
                {
                    DateTime itemDate = (DateTime)item.Date;
                    if (Common.selectedFilter == "filterByDate")
                    {
                        if (Common.selectedDate.Month == itemDate.Month && Common.selectedDate.Year == itemDate.Year && Common.selectedDate.Day == itemDate.Date.Day)
                        {
                            filteredIncomeList.Add(item);
                        }
                    }else if (Common.selectedFilter == "filterByMonth")
                    {
                        if (Common.selectedDate.Month == itemDate.Month && Common.selectedDate.Year == itemDate.Year)
                        {
                            filteredIncomeList.Add(item);
                        }
                    }
                    else if (Common.selectedFilter == "filterByYear")
                    {
                        if (Common.selectedDate.Year == itemDate.Year)
                        {
                            filteredIncomeList.Add(item);
                        }
                    }
                
                }

                List<Transaction> incomeList2 = filteredIncomeList.OrderByDescending(x => x.Date).ToList();
               

                return incomeList2;
            }catch (Exception ex)
            {
                List<Transaction> incomeList = new List<Transaction>();
                return incomeList;
            }

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
            }
            catch (Exception ex)
            {
                List<Transaction> incomeList = new List<Transaction>();
                return incomeList;
            }
        }

        public int findIncomeId()
        {
            int id = 0;
            List<Transaction> incomeList = GetIncomeList();
            if(incomeList != null)
            {
                for (int i = 0; i < incomeList.Count; i++)
                {
                    Transaction transaction = incomeList[i];
                    id = (int)transaction.Id;
                }
            }
            return ++id;
           
        }

    }
}
