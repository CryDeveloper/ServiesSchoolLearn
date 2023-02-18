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
using ServiesSchoolLearn.Pages;

namespace ServiesSchoolLearn
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //dgTable.ItemsSource = demoExam_TaranEntities.Service.ToList();
            Frame1.Navigate(new ListService());
            
        }

        private void TextForCode_SelectionChanged(object sender, RoutedEventArgs e)
        {
            AdminMode.forAdmin = TextForCode.Text == "0000" ? "visible" : "hidden";
            Frame1.Navigate(new ListService());
            //servicelist.ItemsSource = demoExam_TaranEntities.Service.ToList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Tag.ToString());
        }
    }
}
