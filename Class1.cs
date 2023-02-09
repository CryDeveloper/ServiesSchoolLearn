using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiesSchoolLearn
{
    public partial class Service
    {
        public string PriceAndTime 
        { get
            {
                //return Cost.ToString() + " рублей за " + (DurationInSeconds / 60).ToString() + " минут";
                return ((double)Cost - (double)Cost *Discount).ToString() + " рублей за " + (DurationInSeconds / 60).ToString() + " минут";
            }
        }
        public string DiscountIntext
        {
            get
            {
                if (Discount != 0)
                {
                    return "* скидка " + (Discount * 100).ToString() + "%";
                }
                return "";
            }
        }
    }
}
