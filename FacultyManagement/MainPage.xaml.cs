using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FacultyManagement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<string> subjects = new List<string>
            {
                "CSharp","Java", "SEO", "3D", "Web Design", "Networking", "Graphics", "Cyber Security"
            };
            this.subject.ItemsSource = subjects;
            this.fSubject.ItemsSource = subjects;
            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
            //FacultyManagement facultyManagement = new FacultyManagement
            //{
            //    FacultyID = 1,
            //    Subject = "CSharp",
            //    FirstName = "John",
            //    LastName = "Sharp",
            //    JoinDate = "12/20/1994",
            //    Phone = "01711235004"
            //};
            //this.DataContext = facultyManagement;
        }
    }
}
