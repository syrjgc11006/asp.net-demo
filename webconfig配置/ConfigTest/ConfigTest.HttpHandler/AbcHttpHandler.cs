using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace ConfigTest.HttpHandler
{
    public class AbcHttpHandler : IHttpHandler, IRequiresSessionState
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<h1><b>Hello HttpHandler</b></h1>");
            context.Session["Test"] = "你在调用AbcHttpHandler容器中调用Session";
            context.Response.Write(context.Session["Test"]);
        }
    }
}
