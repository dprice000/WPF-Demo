using Demo.DAL.Models;
using Demo.DAL.Services;
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
        private MeasurementService measurementService;

        public InputPage()
        {
            InitializeComponent();

            measurementService = new MeasurementService();

            var vm = new InputPageViewModel();
            vm.ID = Guid.NewGuid();
            vm.Name = "Testing for fun";
            vm.Value = 200.00;
            vm.UoM = "cm";
            vm.Timestamp = DateTime.Now;
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = (InputPageViewModel)this.DataContext;
            var meas = new Measurement();

            meas.ID = vm.ID;
            meas.Name = vm.Name;
            meas.Timestamp = vm.Timestamp;
            meas.UoM = vm.UoM;
            meas.Value = vm.Value;

            var entry = measurementService.Get(vm.ID);

            if (entry == null)
            {
                measurementService.Create(meas);
            }
            else
            {
                measurementService.Update(meas);
            }
        }
    }
}
