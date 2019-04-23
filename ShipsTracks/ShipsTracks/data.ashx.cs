using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using ShipsTracks.Common;

namespace ShipsTracks
{
    /// <summary>
    /// data1 的摘要说明
    /// </summary>
    public class data1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //在此写入您的处理程序实现。
            string typestring = context.Request.QueryString["t"];
            string json = string.Empty;
            if (!string.IsNullOrEmpty(typestring))
            {
                switch (typestring.ToUpper())
                {
                    case "SHIPS":
                        json = JsonConvert.SerializeObject(ShipDal.Query(""));
                        break;
                    case "BS":
                        json = JsonConvert.SerializeObject(BSDal.Query(""));
                        break;
                }
            }
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}