using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Move
    {
        private void Say()
        {
            Console.WriteLine("I will go...");
        }

        public void Moving()
        {
            Say();
            Console.WriteLine("I move!");
        }
    }
}
