using System.ComponentModel;

namespace Uppgift4.ViewModel
{
    public class ObservableObject : INotifyPropertyChanged
    {
        // Capture the property change as PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // For notifying that a property has been changed
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;

            // Make sure that the changed property is 
            // coming from a legitimate source. Faking 
            // a property change is not possible now.
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
