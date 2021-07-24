using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateWpfApp
{
    public class MainWindowViewModel
    {
        public MainWindowModel MainWindowModel
        {
            get
            {
                return this.mainWindowModel;
            }
        }

        private MainWindowModel mainWindowModel;

        public MainWindowViewModel()
        {
            this.mainWindowModel = new MainWindowModel();
        }
    }
}
