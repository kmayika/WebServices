using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceLibrary
{
    public class MyServiceLibrary : IMyLibraryService
    {
        public string GetData()
        {
            return "Hello from my service";
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
