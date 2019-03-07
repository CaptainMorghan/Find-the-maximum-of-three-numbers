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

namespace IF_challange_one
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFindMaxNumber_Click(object sender, RoutedEventArgs e)
        {
            //local variable
            int Number;
            int Numbertwo;
            int Numberthree;
            int.TryParse(txtNumber.Text, out Number);
            int.TryParse(txtNumberTwo.Text, out Numbertwo);
            int.TryParse(txtNumberThree.Text, out Numberthree);



            if (Number > Numbertwo)
            {
                if (Number > Numberthree)

                {
                    lblOutputMaximum.Content = "Number one is larger";
                }
                else
                {
                    lblOutputMaximum.Content = "Number Three is larger";
                }
            }
            else 
            {
                if (Numbertwo > Numberthree)
                {
                    lblOutputMaximum.Content = "Number Two is larger";
                }
                else
                {
                    lblOutputMaximum.Content = "Number Three is larger";
                }
            }
             
        }
    }
}
