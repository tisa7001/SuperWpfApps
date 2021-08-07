using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuperWpfApps.ViewModel
{
    public class MainWindowViewModel : ViewBaseModel
    {
        public System.Windows.Media.ImageSource? _togglebtnImageSource;


        public ICommand btnToggleClick
        {
            get { return new DelegateCommand<object>(FuncToCall, FuncToEvaluate); }
        }

        private void FuncToCall(object context)
        {
            //this is called when the button is clicked

        }

        private bool FuncToEvaluate(object context)
        {
            //this is called to evaluate whether FuncToCall can be called
            //for example you can return true or false based on some validation logic
            return true;
        }


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

    }

    public class ViewBaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        protected bool SetPropertry<T>
                (ref T Storage, T Value, [CallerMemberName] string Propertyname = null)
        {
            if (EqualityComparer<T>.Default.Equals(Storage, Value)) return false;
            Storage = Value;
            IPropertyChanged(Propertyname);
            return true;
        }
        protected void IPropertyChanged(string PropertyName)
        {
            PropertyChangedEventHandler Handler = this.PropertyChanged;
            if (Handler != null)
                Handler(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
