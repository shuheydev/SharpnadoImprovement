using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SharpnadoImprovement
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People { 
            get=> _people;
            set
            {
                _people = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();

            this.People = SampleDataGenerator.GetPeople();

            this.BindingContext = this;
        }
    }
}
