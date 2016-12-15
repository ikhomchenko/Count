using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterApp.Core;

namespace CounterApp.Models
{
    public class Counter : BindableBase
    {
        private  int count;

        public int Count
        {
            get { return count; }
            set
            {
                SetProperty(ref count, value);
            }
        }
        public void Increment()
        {
            Count++;
        }
       
        public void Decrement()
        {
            Count--;
        }
    }
}
