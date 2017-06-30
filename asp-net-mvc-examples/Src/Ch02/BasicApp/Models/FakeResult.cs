using System.Web.Mvc;
public class FakeResult : ActionResult
{
    public override void ExecuteResult(ControllerContext context)
    {
        return;
    }
}