using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TemplateWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel mainWindowVM;

        public MainWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.mainWindowVM = new MainWindowViewModel();
            this.DataContext = mainWindowVM;
        }

        private void tbEnter_OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                //btnChange.Focusable = true;
                //btnChange.Focus();

                if (this.mainWindowVM.ChangeItCommand != null && this.mainWindowVM.ChangeItCommand.CanExecute(null) == true)
                {
                    this.mainWindowVM.ChangeItCommand.Execute(null);
                }
            }
        }
    }
}
