using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;

namespace ActionMethodSelectorAttributeTest
{
    public class IndexRouteValueTransformer : DynamicRouteValueTransformer
    {
        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            values ??= new RouteValueDictionary();
            values["controller"] = "Home";
            values["action"] = "Index";
            return new ValueTask<RouteValueDictionary>(values);
        }
    }
}