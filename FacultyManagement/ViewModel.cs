using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FacultyManagement
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<FacultyManagement> facultyManagements;
        private int currentFacultyManagement;
        public Command NextFacultyManagement { get; private set; }
        public Command PreviousFacultyManagement { get; private set; }
        public ViewModel()
        {
            this.currentFacultyManagement = 0;
            this.IsAtStart = true;
            this.IsAtEnd = false;
            this.NextFacultyManagement = new Command(this.Next, () => this.facultyManagements.Count > 1 && !this.IsAtEnd);
            this.PreviousFacultyManagement = new Command(this.Previous, () => this.facultyManagements.Count > 0 && !IsAtStart);
            this.facultyManagements = new List<FacultyManagement>
            {
                new FacultyManagement
                {
                    FacultyID = 1001,
                    Subject = "CSharp",
                    FirstName = "SR",
                    LastName = "Shohan",
                    JoinDate = "12/20/2021",
                    Phone = "01711235004"
                },
                new FacultyManagement
                {
                    FacultyID = 1002,
                    Subject = "Java",
                    FirstName = "Ashik",
                    LastName = "Rahman",
                    JoinDate = "12/23/2020",
                    Phone = "01521473012"
                },

                new FacultyManagement
                {
                    FacultyID = 1003,
                    Subject = "SEO",
                    FirstName = "Shaon",
                    LastName = "Ahmed",
                    JoinDate = "11/23/2019",
                    Phone = "01811606111"
                },
                new FacultyManagement
                {
                    FacultyID = 1004,
                    Subject = "Networking",
                    FirstName = "Enanul",
                    LastName = "Haque",
                    JoinDate = "01/11/2018",
                    Phone = "01734673482"
                },
                new FacultyManagement
                {
                    FacultyID = 1005,
                    Subject = "Graphics",
                    FirstName = "Fuad",
                    LastName = "Hassan",
                    JoinDate = "08/05/2017",
                    Phone = "01933873927"
                },
                new FacultyManagement
                {
                    FacultyID = 1006,
                    Subject = "Cyber Security",
                    FirstName = "Delwar",
                    LastName = "Hossain",
                    JoinDate = "01/05/2016",
                    Phone = "01638784930"
                }
            };
        }
        private bool _isAtStart;
        public bool IsAtStart
        {
            get => this._isAtStart;
            set
            {
                this._isAtStart = value;
                this.OnPropertyChanged(nameof(IsAtStart));
            }
        }

        private bool _isAtEnd;
        public bool IsAtEnd
        {
            get => this._isAtEnd;
            set
            {
                this._isAtEnd = value;
                this.OnPropertyChanged(nameof(IsAtEnd));
            }
        }
        public FacultyManagement Current
        {
            get => this.facultyManagements.Count > 0 ? this.facultyManagements[currentFacultyManagement] : null;
        }
        private void Next()
        {
            if (this.facultyManagements.Count -1> this.currentFacultyManagement)
            {
                this.currentFacultyManagement++;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtStart = false;
                this.IsAtStart = (this.facultyManagements.Count - 1 == this.currentFacultyManagement);
            }
        }
        private void Previous()
        {
            if (this.currentFacultyManagement>0)
            {
                this.currentFacultyManagement--;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtEnd = false;
                this.IsAtStart = (this.currentFacultyManagement == 0);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

