using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Finance_App.View
{
    public class Common : UserControl
    {
        public static Button CreateCatagoryButton(string? name, string? icon, Style? style)
        {
            

            Button button = new Button();
            
            button.Content = name;
            button.Style = style;
            button.Height = 50;
            button.Width = 210;
            button.Content = name;
            button.ToolTip = name;
            button.Name = icon;
            /* button.Foreground = new SolidColorBrush(Color.FromRgb(2, 117, 216));
             button.BorderBrush = new SolidColorBrush(Color.FromRgb(2, 117, 216));*/
            button.HorizontalAlignment = HorizontalAlignment.Left;
            //button.Padding = new Thickness(0,0,10,0);

            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            //stackPanel.Margin = new Thickness(0);

            MaterialDesignThemes.Wpf.PackIcon packIcon = FindPackIcon(icon);
            packIcon.Width = 20;
            packIcon.Height = 20;
            packIcon.VerticalAlignment = VerticalAlignment.Center;
            packIcon.HorizontalAlignment = HorizontalAlignment.Center;
            //packIcon.Foreground = new SolidColorBrush(Color.FromRgb(2, 117, 216));
            stackPanel.Children.Add(packIcon);

            TextBlock textBlock = new TextBlock();
            textBlock.Text = name;
            textBlock.Margin = new Thickness(10, 0, 0, 0);
            stackPanel.Children.Add(textBlock);

            button.Content = stackPanel;
            return button;

        }

        public static MaterialDesignThemes.Wpf.PackIcon FindPackIcon(string name)
        {
            switch (name)
            {
                case "Home":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.Home };

                case "Car":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.Car };

                case "Travel":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.Travel };

                case "Food":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.Food };

                case "TshirtCrewOutline":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.TshirtCrewOutline };

                case "Pill":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.Pill };

                case "FuelPump":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.FuelPump };

                case "BabyFaceOutline":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.BabyFaceOutline };

                case "QuestionMark":
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.QuestionMark };

                default:
                    return new MaterialDesignThemes.Wpf.PackIcon { Kind = MaterialDesignThemes.Wpf.PackIconKind.Home };

            }
        }


    }
}
