using System;

namespace MvcEmule.Components
{
    public class HomeController  
    {
        public String Test(Object param1)
        {
            return String.Format("<html><h1>Got it! You passed '{0}'</h1></html>", param1);
        }
    }
}
