namespace Razor.Demo.RoutingConstraints
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Routing;
    using System;
    public class EvenConstraints : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            int id;
            if(Int32.TryParse(values["id"].ToString(),out id))
            {
                return id % 2 == 0 ?true
                                   :false;
            }
            return false;
        }
    }
}