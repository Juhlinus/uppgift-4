using System.Windows;
using Uppgift4.ViewModel;

namespace Uppgift4.View
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            DataContext = new Presenter();
        }
    }
}
