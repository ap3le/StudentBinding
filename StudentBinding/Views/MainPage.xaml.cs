using StudentBinding.Models;
using StudentBinding.ViewModels;

namespace StudentBinding.Views
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModels();

            
        }

        

    }
}
