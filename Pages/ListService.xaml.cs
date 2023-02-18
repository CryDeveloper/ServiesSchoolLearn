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

namespace ServiesSchoolLearn.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListService.xaml
    /// </summary>
    public partial class ListService : Page
    {
        DemoExam_TaranEntities demoExam_TaranEntities;
        List<Service> services,services1;
        public ListService()
        {
            
            demoExam_TaranEntities = new DemoExam_TaranEntities();
            InitializeComponent();
            services = demoExam_TaranEntities.Service.ToList();
            services1 = services;
            servicelist.ItemsSource = services1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Tag.ToString());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
          

            switch (comboBox.SelectedIndex)
            {
                case 0:
                    services1 = services1.OrderBy(x => x.Cost).ToList();
                    services = services.OrderBy(x => x.Cost).ToList();
                    break;
                case 1:
                    services1 = services1.OrderBy(x => x.Cost).Reverse().ToList();
                    services = services.OrderBy(x => x.Cost).Reverse().ToList();
                    break;
            }
            servicelist.ItemsSource = services1;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            services1 = services.Where(x => x.Title.Contains(textBox.Text)).ToList();
            servicelist.ItemsSource = services1;

        }
    }
}
