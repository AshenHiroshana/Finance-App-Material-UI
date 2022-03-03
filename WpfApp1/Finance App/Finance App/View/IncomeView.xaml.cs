using personal_financial_management_app_class_libbey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Finance_App.View
{
    /// <summary>
    /// Interaction logic for IncomeView.xaml
    /// </summary>
    public partial class IncomeView : UserControl
    {
        public IncomeView()
        {
          
            Catagory catagory1 = new Catagory();
            catagory1.Name = "Salary";

            Catagory catagory2 = new Catagory();
            catagory2.Name = "Interest";

            List<Catagory> catagories1 = new List<Catagory>();
            catagories1.Add(catagory1);
            catagories1.Add(catagory2);

            List<Catagory> catagories2 = new List<Catagory>();
            catagories2.Add(catagory1);
            catagories2.Add(catagory2);



            
           


            List<Catagory> cat = new List<Catagory>();
            cat.Add(catagory1);
            cat.Add(catagory2);

            List<Button> x = new List<Button>();

            for (int i = 0; i < cat.Count; i++)
            {
                Button button = new Button();
                button.Content = cat[i].Name;
                x.Add(button);


            }

            List<List<Button>> lsts = new List<List<Button>>();
            lsts.Add(x);
            lsts.Add(x);

            /* List<List<int>> lsts = new List<List<int>>();



             for (int i = 0; i < 5; i++)
             {
                 lsts.Add(new List<int>());

                 for (int j = 0; j < 2; j++)
                 {
                     lsts[i].Add(i * 10 + j);
                 }
             }
 */
            InitializeComponent();

            lst.ItemsSource = lsts;
            




        }

        private void Next(object sender, RoutedEventArgs e)
        {
            IncomeForm1.Visibility = Visibility.Hidden;
            IncomeForm2.Visibility = Visibility.Visible;
        }

        private void Prev(object sender, RoutedEventArgs e)
        {
            IncomeForm2.Visibility = Visibility.Hidden;
            IncomeForm1.Visibility = Visibility.Visible;
        }
    }
}
