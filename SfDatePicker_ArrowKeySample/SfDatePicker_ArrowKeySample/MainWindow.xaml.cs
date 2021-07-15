using Syncfusion.Windows.Controls;
using Syncfusion.Windows.Controls.Input;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfDatePicker_ArrowKeySample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // SfDateSelector
        SfDateSelector selector = null;

        // Popup
        Popup popUp;

        public MainWindow()
        {
            InitializeComponent();
            this.MonthDatePicker.Loaded += MonthDatePicker_Loaded;                        
        }

        

        /// <summary>
        /// Invoked when SfDatePicker Loaded
        /// </summary>
        private void MonthDatePicker_Loaded(object sender, RoutedEventArgs e)
        {
            popUp = MonthDatePicker.Template.FindName("PART_DropDown", MonthDatePicker) as Popup;
            selector = MonthDatePicker.Template.FindName("PART_DateSelector", MonthDatePicker) as SfDateSelector;
            if (popUp != null)
            {
                popUp.Opened += PopUp_Opened;
            }
        }

        /// <summary>
        /// Invoked when the popup opened
        /// </summary>
        private void PopUp_Opened(object sender, EventArgs e)
        {
            Keyboard.Focus(selector);
        }
    }
}
