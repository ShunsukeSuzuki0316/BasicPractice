using BasicPractice.practice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BasicPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Practice practice = new PracticeSample();
            practice.OutputImage();
            practice.Solve();

            practice = new Practice01();
            practice.OutputImage();
            practice.Solve();

            practice = new Practice10();
            practice.OutputImage();
            practice.Solve();
        }
    }
}
