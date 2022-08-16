using Microsoft.UI.Xaml.Controls;
using System.Threading.Tasks;
using Uno.Extensions;
using Uno.Extensions.Configuration;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IWO_immutablelist_bug
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new ViewModel.BindableViewModel(((App)App.Current).Host.Get<IWritableOptions<Options>>());
        }
    }
}
