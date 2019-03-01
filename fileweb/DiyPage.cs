using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace fileweb
{
    public class DiyPage
    {

private    StringBuilder Page = null;


        
        public DiyPage(string title,string content)
        { 
         Page=new StringBuilder();
         string pagestr = DoIo.Reader(DoIo.ApppDatapath + @"txt.html").Replace("<title></title>", "<title>" + title + "</title>");
         pagestr = pagestr.Replace("<div id='content'>","<div id='content'>"+ content);
         Page.Append(pagestr);
        }
        public DiyPage()
        {
        }
        
        public string GetPageStr()
        {
            return Page.ToString();
        }

    }
}