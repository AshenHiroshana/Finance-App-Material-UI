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

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/WriteText.txt");
            writer.Write(jsonString);
            writer.Close();

        }

        public List<Catagory> GetIncomeCatagory()
        {

            try
            {
                StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/WriteText.txt");
                String json = reader.ReadToEnd();
                reader.Close();

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
}
