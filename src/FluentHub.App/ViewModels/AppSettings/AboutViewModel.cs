using CommunityToolkit.WinUI.UI;
using FluentHub.Octokit.Queries.Users;
using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Services;
using FluentHub.App.ViewModels.UserControls.Overview;
using FluentHub.App.Utils;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.System;

namespace FluentHub.App.ViewModels.AppSettings
{
    public class AboutViewModel : ObservableObject
    {
        public AboutViewModel(ILogger logger = null)
        {
            _logger = logger;

            CopyVersionCommand = new RelayCommand(ExecuteCopyVersion);
            OpenLogsCommand = new AsyncRelayCommand(ExecuteOpenLogsAsync);

            LoadUserCommand = new AsyncRelayCommand(LoadUserAsync);
        }

        #region Fields and Properties
        private readonly ILogger _logger;

        public string Version
        {
            get
            {
                string architecture = Windows.ApplicationModel.Package.Current.Id.Architecture.ToString();

#if DEBUG
                string buildConfiguration = "DEBUG";
#else
                string buildConfiguration = "RELEASE";
#endif

                return $"{App.AppVersion} | {architecture} | {buildConfiguration}";
            }
        }

        private Octokit.Models.v4.User _user;
        public Octokit.Models.v4.User User { get => _user; set => SetProperty(ref _user, value); }

        private AppSettingsOverviewViewModel _appSettingsOverviewViewModel;
        public AppSettingsOverviewViewModel AppSettingsOverviewViewModel { get => _appSettingsOverviewViewModel; set => SetProperty(ref _appSettingsOverviewViewModel, value); }

        internal IRelayCommand CopyVersionCommand { get; }
        internal IAsyncRelayCommand OpenLogsCommand { get; }

        public IAsyncRelayCommand LoadUserCommand { get; }
        #endregion

        private void ExecuteCopyVersion()
        {
            try
            {
                var data = new DataPackage
                {
                    RequestedOperation = DataPackageOperation.Copy
                };

                data.SetText(Version);

                Clipboard.SetContentWithOptions(data, new ClipboardContentOptions() { IsAllowedInHistory = true, IsRoamable = true });
                Clipboard.Flush();
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to copy data from copy version command, version: ${Version}", ex);
            }
        }

        private async Task ExecuteOpenLogsAsync()
        {
            string logsFolder = Path.Combine(ApplicationData.Current.LocalFolder.Path, "FluentHub.Logs");
            var result = await Launcher.LaunchFolderPathAsync(logsFolder);
            _logger?.Info("Open logs folder result: {0}", result);
        }

        private async Task LoadUserAsync()
        {
            AppSettingsOverviewViewModel = new()
            {
                SelectedTag = "about",
            };

            if (AppSettingsOverviewViewModel.StoredUser is null)
            {
                UserQueries queries = new();
                var response = await queries.GetAsync(App.AppSettings.SignedInUserName);

                User = response;

                AppSettingsOverviewViewModel.StoredUser = User;
                AppSettingsOverviewViewModel.User = User;
            }
            else
            {
                AppSettingsOverviewViewModel.User = AppSettingsOverviewViewModel.StoredUser;
            }
        }

        private void SetCurrentTabItem()
        {
            var provider = App.Current.Services;
            INavigationService navigationService = provider.GetRequiredService<INavigationService>();

            var currentItem = navigationService.TabView.SelectedItem.NavigationHistory.CurrentItem;
            currentItem.Header = "Appearance";
            currentItem.Description = "Appearance";
            currentItem.Icon = new ImageIconSource
            {
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Icons/Appearance.png"))
            };
        }
    }
}
