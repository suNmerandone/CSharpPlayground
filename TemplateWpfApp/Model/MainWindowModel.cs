using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateWpfApp
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        #region " Properties "

        public string Label
        {
            get
            {
                return this.label;
            }
        }

        #endregion

        #region " Fields "

        private string label;

        #endregion

        #region " Events - INotifyPropertyChanged "

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region " Events "

        #endregion

        #region " Constructure "

        public MainWindowModel()
        {
            this.label = "Hello World!";

            //You can change the world...

        }

        #endregion

        #region " Methods - INotifyPropertyChanged "

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
