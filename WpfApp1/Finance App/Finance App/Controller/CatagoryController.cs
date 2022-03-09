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
    public class CatagoryController
    {

        public void SaveIncomeCatagory(Catagory catagory)
        {

            List<Catagory> catagories = GetIncomeCatagory();
            catagories.Add(catagory);

            string jsonString = JsonSerializer.Serialize(catagories);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeCatagoryList.txt");
            writer.Write(jsonString);
            writer.Close();

        }

        public List<Catagory> GetIncomeCatagory()
        {

            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/IncomeCatagoryList.txt");
                String json = reader.ReadToEnd();
                reader.Close();

                List<Catagory> catagories = JsonSerializer.Deserialize<List<Catagory>>(json)!;


                return catagories;
            }
            catch (Exception ex2)
            {
                try
                {
                    StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/OriginalIncomeCatagoryList.txt");
                    String json = reader.ReadToEnd();
                    reader.Close();

                    StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/IncomeCatagoryList.txt");
                    writer.Write(json);
                    writer.Close();

                    List<Catagory> catagories = JsonSerializer.Deserialize<List<Catagory>>(json)!;


                    return catagories;
                }
                catch (Exception ex)
                {
                    List<Catagory> incomeList = new List<Catagory>();
                    return incomeList;
                }
            }

        }



        public void SaveExpenseCatagory(Catagory catagory)
        {

            List<Catagory> catagories = GetExpenseCatagory();
            catagories.Add(catagory);

            string jsonString = JsonSerializer.Serialize(catagories);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/ExpenseCatagoryList.txt");
            writer.Write(jsonString);
            writer.Close();

        }

        public List<Catagory> GetExpenseCatagory()
        {

            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/ExpenseCatagoryList.txt");
                String json = reader.ReadToEnd();
                reader.Close();

                List<Catagory> catagories = JsonSerializer.Deserialize<List<Catagory>>(json)!;
               

                return catagories;
            }
            catch (Exception ex)
            {
                try
                {
                    StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/OriginalExpenseCatagoryList.txt");
                    String json = reader.ReadToEnd();
                    reader.Close();

                    StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/ExpenseCatagoryList.txt");
                    writer.Write(json);
                    writer.Close();

                    List<Catagory> catagories = JsonSerializer.Deserialize<List<Catagory>>(json)!;


                    return catagories;
                }
                catch (Exception ex2)
                {
                    List<Catagory> expenseList = new List<Catagory>();
                    return expenseList;
                }
            }

        }
    }
}
