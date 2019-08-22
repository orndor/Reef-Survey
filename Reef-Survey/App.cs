using System;
using System.Collections.Generic;
using System.Text;

namespace Reef_Survey
{
    class App
    {
        public void Run()
        {
            var parse = new Parse(@"C:\Users\lukep\Desktop\Reef\Reef-Survey\Reef-Survey\external\survey\1-data\Fish Dump.csv");
            parse.Csv();
        }
    }
}
