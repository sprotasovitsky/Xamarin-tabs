using System.ComponentModel;
using Xamarin.Forms;
using Tabbedapp.ViewModels;

namespace Tabbedapp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
