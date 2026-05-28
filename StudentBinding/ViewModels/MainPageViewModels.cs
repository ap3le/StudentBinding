using StudentBinding;
using StudentBinding.Models;

namespace StudentBinding.ViewModels
{
    internal class MainPageViewModels : ObservableObject
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

        public MainPageViewModels()
        {
            student1= new Student("Daniel","Mizrahi","daniel123@gmail.com","daniel.png",new DateTime (2007,9,11),"050-1234567");
            student2= new Student("Noa","Ashkenazi","noa123@gmail.com","noa.png",new DateTime (2008,8,5),"050-67676767");

            DisplayedStudent=student1;

            
        }

        
    }
}