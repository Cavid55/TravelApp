using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.ViewModels
{
    public class MainWindowModel
    {
        public PlanViewModel PlanViewModel { get; }
        public MainWindowModel(PlanViewModel planViewModel)
        {
            PlanViewModel = planViewModel;
        }

        public void Load()
        {
            PlanViewModel.Load();
        }
    }
}
