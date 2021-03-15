using DataLayer;
using DataLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PresentationLayer.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        static public UnitOfWork unitOfWork;
        private ObservableCollection<Person> people; 

        public MainWindowViewModel()
        {
            unitOfWork = new UnitOfWork(new HOCDbContext());
            people = new ObservableCollection<Person>(unitOfWork.Persons.GetPeople());
        }


        public ObservableCollection<Person> People
        {
            get { return people; }
        }
    }
}
