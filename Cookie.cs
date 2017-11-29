using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Providers
{
    public class Cookie
    {

        public void SetCookie(string name, string value, string date, int time)
        {
            HttpCookie cookie = new HttpCookie(name, value);

            switch (date)
            {
                case "second":
                    cookie.Expires = DateTime.Now.AddSeconds(time);
                    break;
                case "minute":
                    cookie.Expires = DateTime.Now.AddMinutes(time);
                    break;
                case "hour":
                    cookie.Expires = DateTime.Now.AddHours(time);
                    break;
                case "day":
                    cookie.Expires = DateTime.Now.AddDays(time);
                    break;
                case "month":
                    cookie.Expires = DateTime.Now.AddMonths(time);
                    break;
                case "year":
                    cookie.Expires = DateTime.Now.AddYears(time);
                    break;
            }

            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
        }



        public string GetCookie(string name)
        {
            return System.Web.HttpContext.Current.Request.Cookies[name].Value.ToString();
        }



        public bool ExistCookie(string name)
        {
            HttpCookie cookie = System.Web.HttpContext.Current.Request.Cookies[name];

            if (cookie != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void RemoveCookie(string name)
        {
            System.Web.HttpContext.Current.Request.Cookies.Remove(name);
        }
    }

}
