using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        private Student student1;
        private Student student2;

        private Student displayedStudent;

        private DateTime newDate = DateTime.Now;

        public DateTime NewDate
        {
            get { return newDate; }
            set
            {
                newDate = value;
                OnPropertyChanged(nameof(NewDate));
            }
        }

        public Student DisplayedStudent
        {
            get { return displayedStudent; }
            set
            {
                displayedStudent = value;
                OnPropertyChanged(nameof(DisplayedStudent));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            student1= new Student("Daniel","Mizrahi","daniel123@gmail.com","daniel.png",new DateTime (2007,9,11),"050-1234567");
            student2= new Student("Noa","Ashkenazi","noa123@gmail.com","noa.png",new DateTime (2008,8,5),"050-67676767");

            DisplayedStudent=student1;
            this.BindingContext=this;

            
        }

        private void ChangeStudent_Clicked(object sender, EventArgs e)
        {
            if (DisplayedStudent == student1)
            {
                DisplayedStudent = student2;

            }
            else
            {
                DisplayedStudent = student1;
            }
        }

        private void UpdateBirthDate_Clicked(object sender, EventArgs e)
        {
            DisplayedStudent.DateOfBirth = NewDate;
        }

    }
}
