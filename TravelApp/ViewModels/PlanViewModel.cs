using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;

namespace TravelApp.ViewModels
{
    public class PlanViewModel
    {
        public PlanViewModel()

        {
            plans = new ObservableCollection<PlanningStuff>();
        }

        public ObservableCollection<PlanningStuff> plans { get; set; }

        public void Load()
        {

            plans.Add(new PlanningStuff()
            {
                checking = false,
                place = "Berlin",
                time = "today",
                price = "free"

            });
        }

    }
}
