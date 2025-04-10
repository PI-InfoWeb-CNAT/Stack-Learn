﻿using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stack_Learn.Infraestrutura
{
    public static class IdentityHelpers
    {
        public static MvcHtmlString GetUserName(this HtmlHelper html, string id)
        {
            GerenciadorUsuario mgr = HttpContext.Current.GetOwinContext().GetUserManager<GerenciadorUsuario>();
            return new MvcHtmlString(mgr.FindByIdAsync(id).Result.UserName);
        }
        public static MvcHtmlString GetAuthenticatedUser(this HtmlHelper html)
        {
            return new MvcHtmlString(HttpContext.Current.User.Identity.Name);
        }
        public static MvcHtmlString GetAuthenticatedUserId(this HtmlHelper html)
        {
            return new MvcHtmlString(HttpContext.Current.User.Identity.GetUserId());
        }
    }
}