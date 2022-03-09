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
    internal class ExpenseController
    {
        public void addExpenseToFile(Transaction expense)
        {

            List<Transaction> expenseList = GetExpenseList();

            expense.Id = findExpenseId();
            expenseList.Add(expense);

            string jsonString = JsonSerializer.Serialize(expenseList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/ExpenseList.txt");
            writer.Write(jsonString);
            writer.Close();


        }


        public void deleteExpenseFromFile(Transaction oldExpense)
        {


            List<Transaction> fullExpenseList = GetExpenseList();
            foreach (Transaction fullExpense in fullExpenseList)
            {
                if (oldExpense.Id == fullExpense.Id)
                {
                    oldExpense = fullExpense;

                }

            }

            fullExpenseList.Remove(oldExpense);

            string jsonString = JsonSerializer.Serialize(fullExpenseList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/ExpenseList.txt");
            writer.Write(jsonString);
            writer.Close();

        }

        public void updateExpenseListToFile(Transaction oldExpense, Transaction newExpense)
        {

            List<Transaction> fullExpenseList = GetExpenseList();
            foreach (Transaction fullExpense in fullExpenseList)
            {
                if (oldExpense.Id == fullExpense.Id)
                {
                    oldExpense = fullExpense;
                    
                }
               
            }
            newExpense.Id = findExpenseId();

            fullExpenseList.Remove(oldExpense);
            fullExpenseList.Add(newExpense);

            string jsonString = JsonSerializer.Serialize(fullExpenseList);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/ExpenseList.txt");
            writer.Write(jsonString);
            writer.Close();


        }

        public List<Transaction> GetExpenseListByFilter()
        {

            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/ExpenseList.txt");
                String json = reader.ReadToEnd();
                reader.Close();

                List<Transaction> expenseList = JsonSerializer.Deserialize<List<Transaction>>(json)!;

                List<Transaction> filteredExpenseList = new List<Transaction>();
                foreach (Transaction item in expenseList)
                {
                    DateTime itemDate = (DateTime)item.Date;
                    if (Common.selectedFilter == "filterByDate")
                    {
                        if (Common.selectedDate.Month == itemDate.Month && Common.selectedDate.Year == itemDate.Year && Common.selectedDate.Day == itemDate.Date.Day)
                        {
                            filteredExpenseList.Add(item);
                        }
                    }
                    else if (Common.selectedFilter == "filterByMonth")
                    {
                        if (Common.selectedDate.Month == itemDate.Month && Common.selectedDate.Year == itemDate.Year)
                        {
                            filteredExpenseList.Add(item);
                        }
                    }
                    else if (Common.selectedFilter == "filterByYear")
                    {
                        if (Common.selectedDate.Year == itemDate.Year)
                        {
                            filteredExpenseList.Add(item);
                        }
                    }

                }

                List<Transaction> expenseList2 = filteredExpenseList.OrderByDescending(x => x.Date).ToList();


                return expenseList2;
            }
            catch (Exception ex)
            {
                List<Transaction> expenseList = new List<Transaction>();
                return expenseList;
            }

        }

        public List<Transaction> GetExpenseList()
        {
            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/ExpenseList.txt");
                String json = reader.ReadToEnd();
                reader.Close();

                List<Transaction> expenseList = JsonSerializer.Deserialize<List<Transaction>>(json)!;

                return expenseList;
            }
            catch (Exception ex)
            {
                List<Transaction> expenseList = new List<Transaction>();
                return expenseList;
            }
        }

        public int findExpenseId()
        {
            int id = 0;
            List<Transaction> expenseList = GetExpenseList();
            if (expenseList != null)
            {
                for (int i = 0; i < expenseList.Count; i++)
                {
                    Transaction transaction = expenseList[i];
                    id = (int)transaction.Id;
                }
            }
            return ++id;

        }

    }
}
