using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeManager.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propetryMethod = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetryMethod));
        }
    }
}
