using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace fileweb
{
    public class DoBase
    {

        /// <summary>
        /// 返回JS弹出框提醒
        /// </summary>
        ///<param name="page">页面对象</param>
        /// <param name="str">提醒内容</param>

        public static void ShowMessage(Page page,string str)
        {
           page.Response.Write("<script>alert('" +str+ "')</script>");
        }
    }
}