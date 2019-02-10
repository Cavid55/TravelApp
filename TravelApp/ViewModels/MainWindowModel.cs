using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.ViewModels
{
    public class MainWindowModel
    {
        public PlanViewModel _planviewmodel { get; }
        public MainWindowModel(PlanViewModel planViewModel)
        {
            _planviewmodel = planViewModel;
        }

        public void Load()
        {
            _planviewmodel.Load();
        }
    }
}
