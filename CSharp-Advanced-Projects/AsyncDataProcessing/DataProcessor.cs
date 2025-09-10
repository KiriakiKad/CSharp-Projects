using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataProcessing
{
    public class DataProcessor
    {

        public void ProcessData(List<int> data) { 
        
            foreach(var item in data)
            {
                Console.WriteLine(item + " * 2: " + (item*2) );
            }

        }
    }
}
