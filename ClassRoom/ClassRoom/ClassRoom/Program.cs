using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("firstclass");
            Console.WriteLine(new string('-', 70));
            ClassRoom firstclass = new ClassRoom(new BadPupil (), new GoodPupil());
            firstclass.Show();

            Console.WriteLine("secondclass");
            Console.WriteLine(new string ('-', 70));
            ClassRoom secondclass = new ClassRoom(new BadPupil(), new GoodPupil(), new ExcelentPupil());
            secondclass.Show();

            Console.WriteLine("thirdclass");
            Console.WriteLine(new string('-', 70));
            ClassRoom thirdclass = new ClassRoom(new GoodPupil(), new GoodPupil(), new GoodPupil(), new GoodPupil());
            thirdclass.Show();
        }
    }
}
