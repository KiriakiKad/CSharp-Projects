using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataProcessing
{
    public class DataFetcher
    {

        public async Task<List<int>> FetchDataAsync()
        {
            await Task.Delay(2000);
            
            return new List<int> { 1, 2, 3, 4, 5};
        }
    }
}
