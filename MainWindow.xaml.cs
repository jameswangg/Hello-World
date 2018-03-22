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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Models.User user = new Models.User();


        public MainWindow()//constructor
        {
            InitializeComponent();
            //dictionary, returf items very fast
        }


        public override void EndInit()
        {
            base.EndInit();
            //uxName.DataContext = user;
            //uxNameError.DataContext = user;//??
            uxContainer.DataContext = user;
        }

        private void uxSubmit_click(object sender, RoutedEventArgs e)
        {
            int x = 1;
            x = x / (x - 1);

            MessageBox.Show("Submitting password:" + uxPassword.Text);

            //close the current window and launch the second window
            var window = new SecondWindow();
            Application.Current.MainWindow = window;

        }

        private void EnterPassword(object sender, RoutedEventArgs e)
        {
            if (uxPassword.Text.Length > 0)
            {
                uxSubmit.IsEnabled = true;
            }
            else
                uxSubmit.IsEnabled = false;

        }

        private void EnterName(Object sender, RoutedEventArgs e)
        {
            if (uxName.Text.Length > 0)
            {
                uxSubmit.IsEnabled = true;
            }
            else
                uxSubmit.IsEnabled = false;
        }



    }
}
