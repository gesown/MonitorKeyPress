using System;
using System.Threading;

namespace TestKeyTrap
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keyFlag=false;

            while (!keyFlag)
            {
                Console.Write(".");
                keyFlag = CheckForKey();
                Thread.Sleep(500);
            }
        }

        private static bool CheckForKey()
        {
            if (Console.KeyAvailable)
            {
                return true;
            }
            return false;
        }
    }
}
;