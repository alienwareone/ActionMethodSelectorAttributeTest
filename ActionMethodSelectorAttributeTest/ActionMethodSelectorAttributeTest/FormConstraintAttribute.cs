using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Routing;

namespace ActionMethodSelectorAttributeTest.Controllers
{
    public class FormConstraintAttribute : ActionMethodSelectorAttribute
    {
        public FormConstraintAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }

        public override bool IsValidForRequest(RouteContext routeContext, ActionDescriptor action)
        {
            if (!routeContext.HttpContext.Request.HasFormContentType)
            {
                return false;
            }

            var requestFormValue = routeContext.HttpContext.Request.Form[Name];
            return requestFormValue == Value;
        }
    }
}