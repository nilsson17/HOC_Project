using PresentationLayer.Navigators;
using PresentationLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PresentationLayer.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
            navigator.UpdateCurrentViewModelCommand = this;
            //Sätter startmenyn till LoginViewModel
            _navigator.CurrentViewModel = new MainWindowViewModel();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }


        // Hanterar navigeringen mellan de olika viewsen
        // TODO: Lägga till  Settings
        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                MessageBox.Show(parameter.ToString());
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Person:
                        _navigator.CurrentViewModel = new PersonViewModel();
                        MessageBox.Show(_navigator.CurrentViewModel.ToString());
                        break;
                    case ViewType.Dog:
                        _navigator.CurrentViewModel = new DogViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

