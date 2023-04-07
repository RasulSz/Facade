using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP
{
    public class IndianMeal : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Indian Dishes Cooked");
        }
    }
}
