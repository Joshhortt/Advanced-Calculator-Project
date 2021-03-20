//Advanced Calculator project is a desktop application which is developed in C# .NET. 
//In this Project we can add two numbers and perform various operations on it.
//Like square of two numbers, square root of two numbers, cos, sin, tan and other types of advanced operations.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathUsing
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
