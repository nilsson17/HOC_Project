using PresentationLayer.Commands;
using PresentationLayer.Helpers;
using PresentationLayer.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModel
{
    public class ViewModelBase : ObserverObject
    {
        public static INavigator Navigator { get; set; } = new Navigator();
        public static UpdateCurrentViewModelCommand updateCurrentViewModelCommand { get; set; } = new UpdateCurrentViewModelCommand(Navigator);

    }
}
