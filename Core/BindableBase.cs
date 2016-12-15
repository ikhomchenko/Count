using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CounterApp.Core
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(property, value)) return;

            property = value;
            RaisePropertyChanged(propertyName);
            
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new  PropertyChangedEventArgs(propertyName));
        }
    }
}
