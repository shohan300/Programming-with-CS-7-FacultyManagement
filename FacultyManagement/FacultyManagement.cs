using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FacultyManagement
{
    public class FacultyManagement : INotifyPropertyChanged
    {
        public int _facultyID;
        public int FacultyID
        {
            get => this._facultyID;
            set
            {
                this._facultyID = value;
                this.OnPropertyChanged(nameof(FacultyID));
            }
        }
        public string _subject;
        public string Subject
        {
            get => this._subject;
            set
            {
                this._subject = value;
                this.OnPropertyChanged(nameof(Subject));
            }
        }
        public string _firstName;
        public string FirstName
        {
            get => this._firstName;
            set
            {
                this._firstName = value;
                this.OnPropertyChanged(nameof(FirstName));
            }
        }
        public string _lastName;
        public string LastName
        {
            get => this._lastName;
            set
            {
                this._lastName = value;
                this.OnPropertyChanged(nameof(LastName));
            }
        }
        public string _joinDate;
        public string JoinDate
        {
            get => this._joinDate;
            set
            {
                this._joinDate = value;
                this.OnPropertyChanged(nameof(JoinDate));
            }
        }
        public string _phone;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
        public string Phone
        {
            get => this._phone;
            set
            {
                this._phone = value;
                this.OnPropertyChanged(nameof(Phone));
            }

        }
    }

}
