using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWithLivestreamer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string strCmdText;
                strCmdText = args[0] + " source";
                System.Diagnostics.Process.Start("livestreamer", strCmdText);
            }
            else
            {
                Console.WriteLine("No URL given");
                Console.ReadLine();
            }
        }
    }
}
