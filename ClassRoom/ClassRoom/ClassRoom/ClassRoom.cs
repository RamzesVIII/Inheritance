using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        Pupil pupil_1, pupil_2, pupil_3, pupil_4;
        int counter;
        public ClassRoom (Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
        {
            this.pupil_1 = pupil_1;
            this.pupil_2 = pupil_2;
            this.pupil_3 = pupil_3;
            this.pupil_4 = pupil_4;
            counter = 4;
        }

        public ClassRoom (Pupil pupil_1, Pupil pupil_2, Pupil pupil_3)
        {
            this.pupil_1 = pupil_1;
            this.pupil_2 = pupil_2;
            this.pupil_3 = pupil_3;
            counter = 3;
        }
        public ClassRoom(Pupil pupil_1, Pupil pupil_2)
        {
            this.pupil_1 = pupil_1;
            this.pupil_2 = pupil_2;
            counter = 2;
        }

        public void Show ()
        {
            if (counter >= 2)
            {
                pupil_1.Study();
                pupil_1.Read();
                pupil_1.Write();
                pupil_1.Relax();
                Console.WriteLine(new string('-', 40));

                pupil_2.Study();
                pupil_2.Read();
                pupil_2.Write();
                pupil_2.Relax();
                Console.WriteLine(new string('-', 40));

                if (counter >= 3)
                {
                    pupil_3.Study();
                    pupil_3.Read();
                    pupil_3.Write();
                    pupil_3.Relax();
                    Console.WriteLine(new string('-', 40));

                    if (counter >= 4)
                    {
                        pupil_4.Study();
                        pupil_4.Read();
                        pupil_4.Write();
                        pupil_4.Relax();
                        Console.WriteLine(new string('-', 40));
                    }
                }
            }
            
        }
    }
}
