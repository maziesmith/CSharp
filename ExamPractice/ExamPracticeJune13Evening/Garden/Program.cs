//•	The first line holds the tomato seeds amount, the second – the tomato area.
//•	The third line holds the cucumber seeds amount, the fourth line – cucumber area. 
//•	The fifth line holds the potato seeds amount, sixth line – potato area.
//•	The seventh line holds the carrot seeds amount, eighth line – carrot area.
//•	The ninth line holds the cabbage seeds amount, tenth line – cabbage area. 
//•	The eleventh line holds the beans seeds amount.
//tomato	0.5$ per seed		carrot	0.6$ per seed
//cucumber	0.4$ per seed		cabbage	0.3$ per seed
//potato	0.25$ per seed		beans	0.4$ per seed


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomatoSeeds = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberSeeds = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoSeeds = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotSeeds = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageSeeds = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansSeeds = int.Parse(Console.ReadLine());

            double totalCost = (tomatoSeeds * 0.5) + (cucumberSeeds * 0.4) + (potatoSeeds * 0.25) + (carrotSeeds * 0.6) + (cabbageSeeds * 0.3) + (beansSeeds * 0.4);
            Console.WriteLine("Total costs: {0:0.00}",totalCost);

            int beansArea = 250 - tomatoArea - cucumberArea - cabbageArea - carrotArea - potatoArea;
            if (beansArea > 0)
            {
                Console.WriteLine("Beans area: "+beansArea);
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else if (beansArea < 0)
            {
                Console.WriteLine("Insufficient area");
            }


        }
    }
}
