using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP
{
    public class Chief
    {
        AzerbaijaniMeal azerbaijaniMeal = new();
        ChineseMeal chineseMeal = new();
        IndianMeal indianMeal = new();
        public void Make()
        {
            azerbaijaniMeal.Cook();
            chineseMeal.Cook();
            indianMeal.Cook();
        }
    }
}
