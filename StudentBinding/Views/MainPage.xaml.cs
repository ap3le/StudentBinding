using StudentBinding.Models;
using StudentBinding.ViewModels;

namespace StudentBinding.Views;
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModels();

            
        }

        private void ChangeStudent_Clicked(object sender, EventArgs e)
        {
            // if (DisplayedStudent == student1)
            // {
            //     DisplayedStudent = student2;

            // }
            // else
            // {
            //     DisplayedStudent = student1;
            // }
        }

        private void UpdateBirthDate_Clicked(object sender, EventArgs e)
        {
            // DisplayedStudent.DateOfBirth = NewDate;
        }

    }
}
