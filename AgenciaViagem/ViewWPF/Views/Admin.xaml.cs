﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Windows.Shapes;

namespace ViewWPF.Views
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GridAdm_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonFecharAdm_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ListViewMenuAdm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenuAdm.SelectedIndex;
            MoveCursorMenuAdm(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlInicio());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Passagens ());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Pacotes());
                    break;

                default:
                    break;
            }

        }

        private void MoveCursorMenuAdm(int index)
        {
            TrainsitionigContetSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (10 + (60 * index)), 0, 0);
        }
    
}
}