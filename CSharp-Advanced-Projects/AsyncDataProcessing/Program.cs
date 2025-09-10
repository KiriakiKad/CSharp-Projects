using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDataProcessing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dataFetcher = new DataFetcher();
            var dataProcessor = new DataProcessor();

            //it has to be awaited because FetchDataAsync is an async method
            var data = await dataFetcher.FetchDataAsync();
            dataProcessor.ProcessData(data);



        }
    }
}
