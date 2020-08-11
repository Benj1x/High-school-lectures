using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_og_events
{
    public delegate string EventDelegate(object sender, EventArgs args);
    class A
    {
        public static event EventDelegate MethodInvoke;
        public string printText(string text)
        {
            if (MethodInvoke != null)
            {
                MethodInvoke(this, new EventArgs());
            }
            return "Hej";
        }
    }
}
