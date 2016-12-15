using CounterApp.Models;

namespace CounterApp.ViewModels
{
    public  class MainPageViewModel
    {
        public Counter Counter { get; set; }

        public MainPageViewModel()
        {
            Counter = new Counter();
        }
    }
   
}
