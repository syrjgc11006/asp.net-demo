using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace ConfigTest.HttpHandler
{
    public class MyHandlerFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            if (url.IndexOf("1") > -1)
            {
                return new HttpHandler1();
            }
            else if (url.IndexOf("2") > -1)
            {
                return new HttpHandler2();
            }
            //返回默认Handler
            return context.Handler;
        }

        public void ReleaseHandler(IHttpHandler handler)
        {
      //      throw new NotImplementedException();
        }
    }

    public class HttpHandler1 : IHttpHandler, IRequiresSessionState
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<h1>HttpHandler1</h1>");
        }
    }

    public class HttpHandler2 : IHttpHandler, IRequiresSessionState
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<h1>HttpHandler2</h1>");
        }
    }
}
