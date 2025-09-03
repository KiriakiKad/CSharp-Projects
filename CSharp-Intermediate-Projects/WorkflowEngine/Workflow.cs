using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Workflow
    {
        public IList<IActivity> Activities;

        public Workflow() { 
            Activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}
