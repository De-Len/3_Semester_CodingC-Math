﻿using _3_Semester_CSharpMath_WPF.ViewModels.Windows;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace _3_Semester_CSharpMath_WPF.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : INavigationWindow
    {
        public MainWindowViewModel ViewModel { get; set; }
        public MainWindowView()
        {

            ViewModel = new MainWindowViewModel();
            this.DataContext = this;

            //Appearance.SystemThemeWatcher.Watch(this);

            InitializeComponent();
            //SetPageService(pageService);

            //navigationService.SetNavigationControl(RootNavigation);
        }

        public INavigationView GetNavigation() => RootNavigation;

        public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);

        public void SetPageService(IPageService pageService) => RootNavigation.SetPageService(pageService);

        public void ShowWindow() => Show();

        public void CloseWindow() => Close();

        /// <summary>
        /// Raises the closed event.
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Make sure that closing this window will begin the process of closing the application.
            Application.Current.Shutdown();
        }

        INavigationView INavigationWindow.GetNavigation()
        {
            throw new NotImplementedException();
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

    }
}