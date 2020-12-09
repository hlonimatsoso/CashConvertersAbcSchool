using AbcSchool.Models;
using AbcSchool.UwpApp.ViewModels;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AbcSchool.UwpApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SubjectsView : Page
    {
        SubjectsViewModel VM ;

        public SubjectsView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            AppData.RefreshDataAsync().GetAwaiter();
            this.VM = new SubjectsViewModel( AppData.Subjects);
            this.DataContext = VM;
            base.OnNavigatedTo(e);
        }

        private void AddSubject_Click(object sender, RoutedEventArgs e)
        {
            Subject subject = new Subject {SubjectName = this.SubjectName.Text,Description=this.SubjectDescription.Text };
            AppData.Client.AddSubject(subject).GetAwaiter();
            AppData.RefreshDataAsync().GetAwaiter();

        }
    }
}
