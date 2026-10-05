using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views
{
    class TranspotView
    {
        public int Kilometes { get; set; }
        public string TimeOfDay { get; set; }
        public double MinPrice { get; set; }
        
        public TranspotView()
        {
            Kilometes = 0;
            TimeOfDay = "";
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter the kilometes :");
            Kilometes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the timeOfDay:");
            TimeOfDay = Console.ReadLine();
        }

        public void ShowMinPrice()
        {
            Console.WriteLine("Min price is: " + MinPrice);
        }
    }
}
