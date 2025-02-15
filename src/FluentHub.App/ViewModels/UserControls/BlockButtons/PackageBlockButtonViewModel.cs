using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Utils;

namespace FluentHub.App.ViewModels.UserControls.BlockButtons
{
    public class PackageBlockButtonViewModel : ObservableObject
    {
        private Package _item;
        public Package Item { get => _item; set => SetProperty(ref _item, value); }
    }
}
