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

namespace Zd_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            list.ItemsSource = Sorting(new List <int>{1, 2, 3, 1 }, new List<int> {4, 5, 2, 9 });
        }

        static List<int> Sorting(List<int> num1, List<int> num2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < num1.Count; i++)
            {
                if (!list.Contains(num1[i]))
                { list.Add(num1[i]); }
            }           
            for (int i = 0; i < num2.Count; i++)
                {
                    if (!list.Contains(num2[i]))
                    { list.Add(num2[i]); }
            }
            list.Sort();

            return list;
        }


        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string input = num1.Text;
            string input2 = num2.Text;

            List<int> numbersList = new List<int>();
            List<int> numbers2List = new List<int>();

            string[] numbers = input.Split(',');
            string[] numbers2 = input2.Split(',');

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    numbersList.Add(num);
                }
            }
            foreach (string number in numbers2)
            {
                if (int.TryParse(number, out int num))
                {
                        numbers2List.Add(num);
                }
            }
            list.ItemsSource = Sorting(numbersList, numbers2List);
        }
    }
}
