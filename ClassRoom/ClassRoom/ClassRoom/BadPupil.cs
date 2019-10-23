using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil study");
        }
        public override void Read()
        {
            Console.WriteLine("Bad pupil read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad pupil write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad pupil relax");
        }
    }
}
