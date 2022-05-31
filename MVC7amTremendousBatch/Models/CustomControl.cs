using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amTremendousBatch.Models
{
    public static class CustomControl
    {
        public static IHtmlString createUrControl(this HtmlHelper helper, string content)
        {
            string htmlstring = "<input type=" + content + ">";
            return new HtmlString(htmlstring);
        }

    }
}