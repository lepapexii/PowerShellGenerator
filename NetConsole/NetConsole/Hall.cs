using System;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace NetConsole
{
    class Hall
    {
        static void Main(string[] args)
        {
            //var  para = args[0].ToString();
            starter();


        }

        static void starter([Optional] string options)
        {


            PSFactory PS = new PSFactory();
            PS.FireNForget();
        }

    }
}
