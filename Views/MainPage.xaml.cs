using CounterApp.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace CounterApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainPageViewModel();
        }

        private void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ActualWidth >= 500)
            {
                buttonStack.Orientation = Orientation.Horizontal;
                button1.Style = button2.Style = button3.Style  = Resources["horizontalButtonStyle"] as Style;
            }
            else
            {
                buttonStack.Orientation = Orientation.Vertical;
                button1.Style = button2.Style = button3.Style  = Resources["verticalButtonStyle"] as Style;
            }
        }
    }
}
