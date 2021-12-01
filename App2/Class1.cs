using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    class Class : Move
    {
        public override void Say()
        {
            Console.WriteLine("I will go!!!!");
        }
        public override void Moving()
        {
            Say();
            Console.WriteLine("I move!!!");
        }
    }
}
