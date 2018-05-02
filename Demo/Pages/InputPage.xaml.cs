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

namespace Demo.Pages
{
    /// <summary>
    /// Interaction logic for InputPage.xaml
    /// </summary>
    public partial class InputPage : UserControl
    {
        public InputPage()
        {
            InitializeComponent();

            var vm = new InputPageViewModel();
            vm.Name = "Testing for fun";
            vm.Value = 200.00;
            vm.Timestamp = DateTime.Now;
            this.DataContext = vm;
        }
    }
}
