
using Finance_App.Entity;
using Finance_App.Controller;
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
using System.IO;
using System.Text.Json;

namespace Finance_App.View
{
    /// <summary>
    /// Interaction logic for IncomeView.xaml
    /// </summary>
    public partial class IncomeView : UserControl
    {
        public IncomeView()
        {


            InitializeComponent();

            CatagoryController catagoryController = new CatagoryController();

            List<Catagory> catagories = catagoryController.GetIncomeCatagory();



            List<Button> x = new List<Button>();

            for (int i = 0; i < catagories.Count; i++)
            {

                Style? style = this.FindResource("MaterialDesignOutlinedButton") as Style;
                Button button = Common.CreateCatagoryButton(catagories[i].Name, catagories[i].Icon, style);
                button.Click += new RoutedEventHandler(Catagory_Is_Click);
               // button.Click += new EventHandler(Catagory_Is_Click);

                button.SetValue(Grid.RowProperty, (i / 2));
                button.SetValue(Grid.ColumnProperty, (i % 2));
                CatagoryList.Children.Add(button);



            }


        }

        private void Catagory_Is_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string x = button.ToolTip.ToString();
            MessageBox.Show(x);
            
        }

        private void Next(object sender, RoutedEventArgs e)
        {

            Boolean approveTxtIncomeDescription = false;
            Boolean approveTxtIncomeAmount = false;
            Boolean approveTxtIncomeDate = false;
            Double x;

            if (txtIncomeDescription.Text == "")
            {
                txtIncomeDescription.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (txtIncomeAmount.Text == "" || !double.TryParse(txtIncomeAmount.Text, out x))
            {
                txtIncomeAmount.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (txtIncomeDate.Text == "")
            {
                txtIncomeDate.BorderBrush = new SolidColorBrush(Colors.Red);
            }

            if (txtIncomeDescription.Text != "")
            {
                txtIncomeDescription.BorderBrush = new SolidColorBrush(Color.FromRgb(70,70,70));
                approveTxtIncomeDescription = true;
            }
            
            if (txtIncomeAmount.Text != "" && double.TryParse(txtIncomeAmount.Text, out x))
            {
                
                txtIncomeAmount.BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                approveTxtIncomeAmount = true;
            }
            if (txtIncomeDate.Text != "")
            {
                txtIncomeDate.BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                approveTxtIncomeDate = true;
            }

            if(approveTxtIncomeDate && approveTxtIncomeDescription && approveTxtIncomeAmount)
            {
                IncomeForm1.Visibility = Visibility.Hidden;
                IncomeForm2.Visibility = Visibility.Visible;
            }
            
        }

        private void Prev(object sender, RoutedEventArgs e)
        {
            IncomeForm2.Visibility = Visibility.Hidden;
            IncomeForm1.Visibility = Visibility.Visible;
        }

        private void NextAddCatagory(object sender, RoutedEventArgs e)
        {
            IncomeForm2.Visibility = Visibility.Hidden;
            AddCatagoryForm.Visibility = Visibility.Visible;
        }

        private void PrevAddCatagory(object sender, RoutedEventArgs e)
        {
            IncomeForm2.Visibility = Visibility.Visible;
            AddCatagoryForm.Visibility = Visibility.Hidden;
        }

        private void ClearIncomeForm1(object sender, RoutedEventArgs e)
        {
            txtIncomeDescription.Text = "";
            txtIncomeAmount.Text = "";
            txtIncomeDate.Text = "";
        }

       

    }
}
