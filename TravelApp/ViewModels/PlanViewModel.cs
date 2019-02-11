using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Model;

namespace TravelApp.ViewModels
{
    public class PlanViewModel
    {
        public bool Editable { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public PlanViewModel()

        {
            plans = new ObservableCollection<PlanningStuff>();
            AddCommand=new DelegateCommand(OnAddExecute, OnAddCanExecute);
            EditCommand=new DelegateCommand(OnEditExecute, OnAddCanExecute);
            Editable = false;
        }

        private void OnEditExecute()
        {
            Editable = true;
            Load();
        }

        private bool OnAddCanExecute()
        {
            return true;
        }

        private void OnAddExecute()
        {
            plans.Add(new PlanningStuff()
            {
                checking = false,
                place = "Berlin",
                time = "today",
                price = "free"

            });
        }

        public ObservableCollection<PlanningStuff> plans { get; set; }

        public void Load()
        {

            //plans.Add(new PlanningStuff()
            //{
            //    checking = false,
            //    place = "Berlin",
            //    time = "today",
            //    price = "free"

            //});
        }

    }
}
