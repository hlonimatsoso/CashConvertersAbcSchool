using AbcSchool.Interfaces;
using AbcSchool.Models;
using AbcSchool.UwpApp.Clients;
using AbcSchool.UwpApp.ViewModels;
using AbcSchool.UwpApp.Views;
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

namespace AbcSchool.UwpApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        IAbcSchoolClient client;

        public MainPageViewModel MainPageViewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.client = new AbcSchoolClient();
            this.MainPageViewModel = new MainPageViewModel();
            this.MainPageViewModel.Students = this.client.GetStudents().Result;
            this.DataContext = this.MainPageViewModel;
            MainFrame.Navigate(typeof(HomeView));
        }

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            HambergerSplit.IsPaneOpen = !HambergerSplit.IsPaneOpen;
        }

        private void HomeLink_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(HomeView));
            HambergerSplit.IsPaneOpen = !HambergerSplit.IsPaneOpen;

        }


        private void SubjectLink_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(SubjectsView));
            HambergerSplit.IsPaneOpen = !HambergerSplit.IsPaneOpen;
        }

        private void StudentLink_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(StudentsView));
            HambergerSplit.IsPaneOpen = !HambergerSplit.IsPaneOpen;
        }
    }
}
