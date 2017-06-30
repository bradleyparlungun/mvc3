using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true)]
public class OptionalAuthenticationAttribute : FilterAttribute, IAuthenticationFilter
{
    public void OnAuthentication(AuthenticationContext filterContext)
    {
        var page = filterContext.ActionDescriptor.ActionName;
        if (DateTime.Now.Millisecond % 2 == 0)
        {
            filterContext.Result = new HttpUnauthorizedResult();
            return;
        }
        else
        {

        }
    }

    public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
    {
        
    }
}