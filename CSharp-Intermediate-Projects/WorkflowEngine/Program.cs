using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new SendEmail());
            var engine = new WorkflowEnginee();
            engine.Run(workflow);
        }
    }
}
