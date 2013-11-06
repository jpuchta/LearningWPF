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
using System.Windows.Shapes;

namespace LearningDataBinding
{
    /// <summary>
    /// Logika interakcji dla klasy ExampleWindow05.xaml
    /// </summary>
    public partial class ExampleWindow05 : Window
    {
        private EmployeeListFactory Factory;// = new EmployeeListFactory(1);
        private ListEmployee employeesL5;
        private ObservableCollection<Employee> employeesO7;
        private List<Employee> emps3;

        public ExampleWindow05()
        {
            InitializeComponent();
            this.Factory = new EmployeeListFactory(0);
            this.employeesL5 = new ListEmployee(this.Factory.CreateList(5));
            this.Factory = new EmployeeListFactory(2);
            this.employeesO7 = new ObservableCollection<Employee>(this.Factory.CreateList(7));
            this.emps3 = this.Factory.CreateList(3);
            this.EmpNumberComboBox.ItemsSource = this.employeesL5;
            this.EmpNumberComboBox2.ItemsSource = this.employeesO7;

            this.MainGrid.DataContext = this.employeesL5;
  //          this.Resources["zatrudnieni"] = this.employeesPlain;
        }

        
    }
}
