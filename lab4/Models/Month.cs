using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class Month
    {
        public List<string> months = new List<string> {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November"
        };

        private static Month instance = null;
        public static Month Instance
        {
            get
            {
                if (instance == null)
                    instance = new Month();

                return instance;
            }
        }
    }
}
