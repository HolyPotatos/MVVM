using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PatternMVVM.ViewModels.Base
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected bool Set<T>(ref T Field, T Value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(Field, Value)) return false;
            Field = Value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
