using Prism.Commands;
using SuperWpfApps.HelperClass;
using SuperWpfApps.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SuperWpfApps.ViewModel
{
    public class MainWindowViewModel : ViewBaseModel
    {

        #region Member_Variable
        MainWindowModel m_objMainWindowModel = new MainWindowModel();
        public System.Windows.Media.ImageSource? _togglebtnImageSource;
        private DelegateCommand togglebtnClick;

        #endregion

        #region Properties

        public ICommand TogglebtnClick => togglebtnClick ??= new DelegateCommand(PerformTogglebtnClick);

        private void PerformTogglebtnClick()
        {
            try
            {
                if (togglebtnClick != null)
                {
                    m_objMainWindowModel.ToggleBtnImageUpdate(_togglebtnImageSource);
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        

        /// <summary>
        /// Image Toggle Button Binding
        /// </summary>

        public System.Windows.Media.ImageSource TogglebtnImageSource
        {
            get
            {
                return _togglebtnImageSource;
            }

            set
            {
                _togglebtnImageSource = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("TogglebtnImageSource");
            }
        }

        #endregion Properties

    }


}
