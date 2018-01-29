using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DivisionHW
{
   public class Division: INotifyPropertyChanged
    {
        private string name;
        private List<Employee> employees;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged("Employers");
            }
        }

        public Division()
        {
            employees = new List<Employee>();
            PropertyChanged += new PropertyChangedEventHandler(Message_PropertyChanged);
        }

        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public void Message_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           // MessageBox.Show($"Свойство {e.PropertyName} у {name} изменилось");
        }
    }
}
