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

namespace LearningDataBinding
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window [] examples = new Window[10];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Example_Button_Click<T>(int i) where T : Window, new()
        {
            RunWindow<T>(ref examples[i]);
        }

        private void RunWindow<T>(ref Window w) where T:Window, new()
        {
            if (w == null || !w.IsLoaded)
                w = new T();
            w.Show();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            HidableWindow.CloseAllHiddenWindows();
            base.OnClosing(e);
        }

        private void Button_E00_Click(object sender, RoutedEventArgs e)
        {
            Example_Button_Click<ExampleWindow00>(0);
        }
        private void Button_E01_Click(object sender, RoutedEventArgs e)
        {
            Example_Button_Click<ExampleWindow01>(1);
        }
        private void Button_E03_Click(object sender, RoutedEventArgs e)
        {
            Example_Button_Click<ExampleWindow03>(3);
        }
        private void Button_E04_Click(object sender, RoutedEventArgs e)
        {
            Example_Button_Click<ExampleWindow04>(4);
        }

        private void Button_E05_Click(object sender, RoutedEventArgs e)
        {
            Example_Button_Click<ExampleWindow05>(5);
        }


    }
}
