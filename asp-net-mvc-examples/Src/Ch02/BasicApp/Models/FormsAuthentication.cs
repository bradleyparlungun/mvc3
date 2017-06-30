using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true)]
public class FormsAuthenticationAttribute : FilterAttribute, IAuthenticationFilter
{
    public void OnAuthentication(AuthenticationContext filterContext)
    {
    }

    public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
    {
        var user = filterContext.HttpContext.User;
        if (user == null || !user.Identity.IsAuthenticated)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }
}