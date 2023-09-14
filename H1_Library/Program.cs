using H1_Library.Controller;
using H1_Library.Model;
using H1_Library.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainCtrl = new MainController();
            mainCtrl.Start();
        }
    }
}
