using System.ComponentModel;
using PropertyChanged;

namespace Practice{ 
    
    /// <summary>
    /// A base view model
    /// </summary>  
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler  PropertyChanged = (sender, e) => { };
    }
}