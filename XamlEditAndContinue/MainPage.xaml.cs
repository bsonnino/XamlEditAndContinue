using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XamlEditAndContinue
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel();
            DataContext = ViewModel;
        }

        public MainViewModel ViewModel { get; set; }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin();
        }

        private void SplitViewButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
