using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DentalBusinessCenter.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizeRoleAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string[] _roles;

        public AuthorizeRoleAttribute(params string[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var session = context.HttpContext.Session;
            var role = session.GetString("UserRole");
            if (string.IsNullOrEmpty(role) || (_roles.Length > 0 && !_roles.Contains(role)))
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }
        }
    }
}
