
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
        
        
        Button clickedButton;
        private void Catagory_Is_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (clickedButton != null)
            {
                Style? style1 = this.FindResource("MaterialDesignOutlinedButton") as Style;
                clickedButton.Style = style1;
            }
            clickedButton = button;
            Style? style2 = this.FindResource("MaterialDesignFlatDarkBgButton") as Style;
            button.Style = style2;

            string selectedCatagory = (string)button.ToolTip;
            txtSelectedCatagory.Foreground = new SolidColorBrush(Colors.Gray);
            txtSelectedCatagory.Text = "You selected " + selectedCatagory + " as your Category";

        }

        private void AddIncome(object sender, RoutedEventArgs e)
        {
            if(clickedButton == null)
            {
                txtSelectedCatagory.Text = "Select a Catagory";
                txtSelectedCatagory.Foreground = new SolidColorBrush(Color.FromRgb(217, 83, 79));
            }
            else
            {
                String incomeDescription = txtIncomeDescription.Text;
                Double incomeAmount  = double.Parse(txtIncomeAmount.Text);
                DateTime incomeDate = (DateTime)txtIncomeDate.GetValue(DatePicker.DisplayDateProperty);
                Catagory incomeCatagory = new Catagory();
                incomeCatagory.Name = (string)clickedButton.ToolTip;
                incomeCatagory.Icon = clickedButton.Name;

                //MessageBox.Show(d.Date.ToString("d"));

                Transaction incomeTransaction = new Transaction();
                incomeTransaction.Description = incomeDescription;
                incomeTransaction.Amount = incomeAmount;
                incomeTransaction.Date = incomeDate;
                incomeTransaction.Catagory = incomeCatagory;

                IncomeController incomeController = new IncomeController();
                incomeController.addIncomeToFile(incomeTransaction);
              
            }

        }

        private void Next(object sender, RoutedEventArgs e)
        {

            Boolean approveTxtIncomeDescription = false;
            Boolean approveTxtIncomeAmount = false;
            Boolean approveTxtIncomeDate = false;
            Double x;

            if (txtIncomeDescription.Text == "")
            {
                txtIncomeDescription.BorderBrush = new SolidColorBrush(Color.FromRgb(217, 83, 79));
            }
            if (txtIncomeAmount.Text == "" || !double.TryParse(txtIncomeAmount.Text, out x))
            {
                txtIncomeAmount.BorderBrush = new SolidColorBrush(Color.FromRgb(217, 83, 79));
            }
            if (txtIncomeDate.Text == "")
            {
                txtIncomeDate.BorderBrush = new SolidColorBrush(Color.FromRgb(217, 83, 79));
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
