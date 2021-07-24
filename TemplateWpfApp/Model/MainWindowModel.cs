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

        public string ShowMessage
        {
            get { return this.showMessage; }
            set
            {
                if (value != this.showMessage)
                {
                    this.showMessage = value;
                    NotifyPropertyChanged("ShowMessage");
                }
            }
        }

        public string EnterMessage
        {
            get { return this.enterMessage; }
            set
            {
                if (value != this.enterMessage)
                {
                    this.enterMessage = value;
                    NotifyPropertyChanged("EnterMessage");
                }
            }
        }

        #endregion

        #region " Fields "

        private string showMessage;
        private string enterMessage;

        #endregion

        #region " Events - INotifyPropertyChanged "

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region " Events "

        #endregion

        #region " Constructure "

        public MainWindowModel()
        {
            this.showMessage = "Hello World!";

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
