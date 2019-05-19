using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ConfigTest.HttpModule
{
    public class MyHttpModule:IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(context_BeginRequest);
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("Add BeginRequest by MyHttpModule!");
        }
    }
}
