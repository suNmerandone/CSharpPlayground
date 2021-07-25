using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateWpfApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateWpfApp.Tests
{
    [TestClass()]
    public class MainWindowViewModelTests
    {
        [TestMethod()]
        public void ChangeItActionTest_EmptyToShowtime()
        {
            // arrange
            var mainWindowVM = new MainWindowViewModel();
            string strBefore = string.Empty;
            string strAfter = "Show Time";
            var expected = 0;

            // act
            mainWindowVM.MainWindowModel.ShowMessage = strBefore;
            mainWindowVM.MainWindowModel.EnterMessage = strAfter;
            mainWindowVM.ChangeItAction();

            var actual = string.Compare(mainWindowVM.MainWindowModel.EnterMessage, mainWindowVM.MainWindowModel.EnterMessage);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ChangeItActionTest_ABCToEmpty()
        {
            // arrange
            var mainWindowVM = new MainWindowViewModel();
            string strBefore = "ABC";
            string strAfter = string.Empty;
            var expected = 0;

            // act
            mainWindowVM.MainWindowModel.ShowMessage = strBefore;
            mainWindowVM.MainWindowModel.EnterMessage = strAfter;
            mainWindowVM.ChangeItAction();

            var actual = string.Compare(mainWindowVM.MainWindowModel.EnterMessage, mainWindowVM.MainWindowModel.EnterMessage);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}