using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    class Transport
    {
        private int kilometes;
        private string timeOfDay;
        public int Kilometes
        {
            get { return this.kilometes; }
            set { this.kilometes = value; }
        }
        public string TimeOfDay
        {
            get { return this.timeOfDay; }
			set { this.timeOfDay = value; }
		}
        
        public Transport(int kilometes, string timeOfDay)
        {
            Kilometes = kilometes;
            TimeOfDay = timeOfDay;
        }

        public Transport() : this(0, "") { }

        public double CalculateMinPrice()
        {
            double minPrice = 0;
            if (kilometes >= 100)
            {
                minPrice = kilometes * 0.06;
            }
            else if(kilometes >= 20)
                            {
                minPrice = kilometes * 0.09;
            }
            else
            {
                if (timeOfDay == "day")
                {
                    minPrice = kilometes * 0.79 + 0.70;
                }
                else if (timeOfDay == "night")
                {
                    minPrice = kilometes * 0.90 + 0.70;
                }
			}

			return minPrice;
        }
    }
}
