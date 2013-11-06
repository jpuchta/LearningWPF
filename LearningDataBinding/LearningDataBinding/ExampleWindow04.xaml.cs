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

namespace LearningDataBinding
{
    /// <summary>
    /// Logika interakcji dla klasy ExampleWindow04.xaml
    /// </summary>
    public partial class ExampleWindow04 : Window
    {
        private EmployeeListFactory Factory;// = new EmployeeListFactory(1);
        private List<Employee> employees;
        public ExampleWindow04()
        {
            InitializeComponent();
            this.Factory = new EmployeeListFactory(1);
            this.employees = this.Factory.CreateList(5);
        }
    }
}
