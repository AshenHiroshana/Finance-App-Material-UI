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
        public void SaveIncomeCatagory()
        {

            List<Catagory> catagories = GetIncomeCatagory();

            string jsonString = JsonSerializer.Serialize(catagories);

            StreamWriter writer = new StreamWriter("C:/Users/Ashen/Desktop/WriteText.txt");
            writer.Write(jsonString);
            writer.Close();

        }

        public List<Catagory> GetIncomeCatagory()
        {


            StreamReader reader = new StreamReader("C:/Users/Ashen/Desktop/WriteText.txt");
            String json = reader.ReadToEnd();
            reader.Close();

            List<Catagory> catagories = JsonSerializer.Deserialize<List<Catagory>>(json)!;

            return catagories;

        }
    }
}
