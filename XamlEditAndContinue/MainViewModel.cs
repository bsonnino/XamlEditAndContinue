using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamlEditAndContinue
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _textLabel;
        private string _textLabel2;

        public MainViewModel()
        {
            TextLabel = "Text Label";
            TextLabel2 = "Text Label 2";
        }
        public string TextLabel
        {
            get => _textLabel;
            set
            {
                _textLabel = value;
                OnPropertyChanged();
            }
        }

        public string TextLabel2
        {
            get => _textLabel2;
            set
            {
                _textLabel2 = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
