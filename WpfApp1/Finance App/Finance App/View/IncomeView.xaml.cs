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


            InitializeComponent();



            Catagory catagory1 = new Catagory();
            catagory1.Name = "Salary";

            Catagory catagory2 = new Catagory();
            catagory2.Name = "Interest";


            List<Catagory> cat = new List<Catagory>();
            cat.Add(catagory1);
            cat.Add(catagory2);

            List<Button> x = new List<Button>();

            for (int i = 0; i < cat.Count; i++)
            {
                Button button = new Button();
                button.Content = cat[i].Name;
                Style? style = this.FindResource("MaterialDesignOutlinedButton") as Style;
                button.Style = style;
                button.Height = 50;
                button.Width = 250;
                button.HorizontalAlignment = HorizontalAlignment.Left;
                //button.Padding = new Thickness(0,0,10,0);

                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Horizontal;
                //stackPanel.Margin = new Thickness(0);

                MaterialDesignThemes.Wpf.PackIcon packIcon = new MaterialDesignThemes.Wpf.PackIcon{ Kind = MaterialDesignThemes.Wpf.PackIconKind.Package };
                packIcon.Width = 20;
                packIcon.Height = 20;
                packIcon.VerticalAlignment = VerticalAlignment.Center;
                packIcon.HorizontalAlignment = HorizontalAlignment.Center;
                stackPanel.Children.Add(packIcon);

                TextBlock textBlock = new TextBlock();  
                textBlock.Text = cat[i].Name;
                textBlock.Margin = new Thickness(10, 0, 0, 0);
                stackPanel.Children.Add(textBlock);

                button.Content = stackPanel;

                button.SetValue(Grid.RowProperty, i);
                CatagoryList.Children.Add(button);

            }


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
