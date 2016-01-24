using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursera.Princeton.Algorithms
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //string res = Part1.Week1.UnionFindQuestions.Question1Seed341498();
            string res = Part1.Week1.UnionFindQuestions.Question2Seed532465();
            Console.WriteLine(res);
            Clipboard.SetText(res);
            Console.ReadLine();
        }
    }
}
