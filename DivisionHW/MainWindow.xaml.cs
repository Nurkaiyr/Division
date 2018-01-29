using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DivisionHW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> employers;
        public ObservableCollection<Division> divisions;
        public MainWindow()
        {
            InitializeComponent();

            employers = new ObservableCollection<Employee>
            {
                new Employee
                {
                    Name="Едиге Нуркайыр", Age=19,
                },
                new Employee
                {
                    Name="Bill Gates", Age=45,
                },
            };

            divisions = new ObservableCollection<Division>
            {
                new Division
                {
                    Name="Генеральный директор", Employees={employers[0]},
                },
                new Division
                {
                    Name="Менеджер", Employees={employers[1]},
                },
            };
            divisionList.ItemsSource = divisions;

        }

        private void DivisionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employeeData.ItemsSource = divisions[divisionList.SelectedIndex].Employees;
        }
    }
}
