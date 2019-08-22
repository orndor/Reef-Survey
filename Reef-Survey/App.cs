using System;
using System.Collections.Generic;
using System.Text;

namespace Reef_Survey
{
    class App
    {
        public void Run()
        {

            var parse = new Parse(@"C:\Users\samfe\Desktop\Reefs\Reef-Survey\external\survey\1-data\Fish Dump.csv");
            parse.Csv();
        }
    }
}
