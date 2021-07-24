using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemplateWpfApp
{
    public class MainWindowViewModel
    {
        #region " Properties "

        public MainWindowModel MainWindowModel
        {
            get
            {
                return this.mainWindowModel;
            }
        }

        #endregion

        #region " ICommand "

        public ICommand ChangeItCommand
        {
            get
            {
                return _changeItCommand ?? (_changeItCommand = new CommandHandler(() => ChangeItAction(), () => CanChangeItCommandExecute));
            }
        }

        public bool CanChangeItCommandExecute
        {
            get
            {
                return true;
            }
        }

        #endregion

        #region " Fields "

        private ICommand _changeItCommand;

        private MainWindowModel mainWindowModel;

        #endregion

        #region " Constructure "

        public MainWindowViewModel()
        {
            this.mainWindowModel = new MainWindowModel();
        }

        #endregion

        #region " Methods - Command "

        public void ChangeItAction()
        {
            System.Diagnostics.Debug.WriteLine("ChangeItAction has been clicked!");

            this.MainWindowModel.ShowMessage = this.MainWindowModel.EnterMessage;
        }

        #endregion
    }
}
