using DataLayer;
using DataLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public UnitOfWork unitOfWork;

        public void ListViewExample()
        {
            //InitializeComponent();
            //List<Person> items = new List<Person>();
            //items.Add(new Person() { SSN = "19990203", FirstName = "Emma", LastName = "Karlsson", Gender = "Female" });
            //items.Add(new Person() { SSN = "1990405", FirstName = "Lisa", LastName = "Nilsson", Gender = "Female" });
            //items.Add(new Person() { SSN = "19990203", FirstName = "Nils", LastName = "Nilsson", Gender = "Male" });
            //LVOwners.ItemsSource = items;
            
           
        }
        public MainWindow()
        {


            InitializeComponent();

            unitOfWork = new UnitOfWork(new HOCDbContext());
            //unitOfWork.Complete();
        }
    }
}

            //using (var db = new HOCDbContext())
            //{
            //    MessageBox.Show(db.Database.Connection.ConnectionString);
            //    db.Database.Delete();
            //    db.Database.Create();
 

