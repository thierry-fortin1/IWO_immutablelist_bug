using Microsoft.UI.Xaml.Controls;
using System.Threading.Tasks;
using Uno.Extensions.Configuration;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IWO_immutablelist_bug
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = new ViewModel.BindableViewModel();
        }
    }
}
