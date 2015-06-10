using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ovjust.ChinaRegionalism.Server
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class DataSearch : System.Web.Services.WebService
    {
        
        [WebMethod]
        public string Provinces()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Citys(string province)
        {
            return "Hello World";
        }

        [WebMethod]
        public string Countys(string city)
        {
            return "Hello World";
        }

        [WebMethod]
        public string AllData()
        {
            return "Hello World";
        }
    }
}
