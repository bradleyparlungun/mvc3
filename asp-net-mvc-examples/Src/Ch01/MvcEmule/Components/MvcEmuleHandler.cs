using System;
using System.Reflection;
using System.Web;

namespace MvcEmule.Components
{
    public class MvcEmuleHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            // Parse out the URL and extract controller, action and parameter
            var segments = context.Request.Url.Segments;
            var controller = segments[1].TrimEnd('/');
            var action = segments[2].TrimEnd('/');
            var param1 = segments[3].TrimEnd('/');

            // Complete controller class name with suffix and (default) namespace
            var fullName = String.Format("{0}.{1}Controller", this.GetType().Namespace, controller);
            var controllerType = Type.GetType(fullName, true, true);

            // Get an instance of the controller
            var instance = Activator.CreateInstance(controllerType);

            // Invoke action method
            var methodInfo = controllerType.GetMethod(action, BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Public);
            var result = String.Empty;
            if (methodInfo.GetParameters().Length == 0)   
            {
                result = methodInfo.Invoke(instance, null) as String;
            }
            else
            {
                result = methodInfo.Invoke(instance, new Object[] { param1 }) as String;;
            }

            // Write out results
            context.Response.Write(result);
        }

        public Boolean IsReusable
        {
            get { return false; }
        }
    }
}