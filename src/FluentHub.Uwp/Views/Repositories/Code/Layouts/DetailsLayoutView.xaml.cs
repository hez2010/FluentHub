﻿using FluentHub.Uwp.Models;
using FluentHub.Uwp.Services;
using FluentHub.Uwp.Services.Navigation;
using FluentHub.Uwp.ViewModels;
using FluentHub.Uwp.ViewModels.Repositories.Code.Layouts;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using muxc = Microsoft.UI.Xaml.Controls;

namespace FluentHub.Uwp.Views.Repositories.Code.Layouts
{
    public sealed partial class DetailsLayoutView : Page
    {
        public DetailsLayoutView()
        {
            InitializeComponent();

            var provider = App.Current.Services;
            ViewModel = provider.GetRequiredService<DetailsLayoutViewModel>();
            _navigation = App.Current.Services.GetRequiredService<INavigationService>();
        }

        public DetailsLayoutViewModel ViewModel { get; }
        private readonly INavigationService _navigation;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var param = e.Parameter as FrameNavigationArgs;
            ViewModel.Login = param.Login;
            ViewModel.Name = param.Name;
            ViewModel.CurrentPath = param.Parameters.ElementAtOrDefault(0) as string;

            var command = ViewModel.LoadDetailsViewPageCommand;
            if (command.CanExecute(null))
                command.Execute(null);
        }

        private void OnDirListViewDoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            var item = DirListView.SelectedItem as DetailsLayoutListViewModel;
            var objType = item?.Type;

            string path = ViewModel.ContextViewModel.Path;

            if (string.IsNullOrEmpty(path) is false)
            {
                path += "/";
            }

            path += item.Name;
            List<object> param = new();
            param.Add(objType + "/" + ViewModel.ContextViewModel.BranchName + "/" + path);

            _navigation.Navigate<DetailsLayoutView>(
                new FrameNavigationArgs()
                {
                    Login = ViewModel.Repository.Owner.Login,
                    Name = ViewModel.Repository.Name,
                    Parameters = param,
                });
        }

        private void OnLatestReleaseClick(object sender, RoutedEventArgs e)
        {
            _navigation.Navigate<Views.Repositories.Releases.ReleasesPage>(
                new FrameNavigationArgs()
                {
                    Login = ViewModel.Repository.Owner.Login,
                    Name = ViewModel.Repository.Name,
                    Parameters = new() { ViewModel.ContextViewModel },
                });
        }
    }
}
