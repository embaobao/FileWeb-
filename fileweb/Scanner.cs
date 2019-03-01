using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace fileweb
{
    public class Scanner
    {
        public static string Path_File = HttpContext.Current.Server.MapPath("~/file/");

        public static string Path_Page = HttpContext.Current.Server.MapPath("~/file/text/");

        private List<PageFile> pageList = null;

        public Scanner(string path)
        {
            PageFile page = null;
            pageList = new List <PageFile>();
    
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo fi in dir.GetFiles())
            {
                page=new PageFile();
                page.Alink= "<tr> <td  style='width: auto'> 最近修改"
                    + fi.LastWriteTime
                    + "</td><td  style='width: auto'><a  href='./Editer.aspx?"
                    + "txt=~/file/text/"
                    + fi.Name
                    + "&title=" + fi.Name + "'>"
                    + fi.Name
                    + "</a><a  target=\"_blank\"  href='" + @"file/text/"
                    + fi.Name + "'  >" + "浏览" + "</a></td>";
            //    page.Alink= "<a  target=\"_blank\"  href='" + "file/" + fi.Name + "'  >" + fi.Name + "</a>";
                page.path = fi.FullName;
                page.title = fi.Name;
                page.addtime = fi.LastWriteTime.ToString();
                page.text = "";
                pageList.Add(page);
            }
        }
        public Scanner(string path,bool isfile)
        {
            PageFile page = null;
            pageList = new List<PageFile>();

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo fi in dir.GetFiles())
            {
                page = new PageFile();

                if (isfile)
                {
              page.Alink = "<tr> <td  style='width: auto'> 上传时间"
              + fi.LastWriteTime
              + "</td>"
              + "<td  style='width: auto'><a  target=\"_blank\"  href='" + @"file/"
              + fi.Name + "'  >" + fi.Name + "下载" + "</a></td>";
                }
                else
                {
                    page.Alink = "<tr> <td  style='width: auto'> 最近修改"
                     + fi.LastWriteTime
                     + "</td><td  style='width: auto'><a  href='./Editer.aspx?"
                     + "txt=~/file/text/"
                     + fi.Name
                     + "&title=" + fi.Name + "'>"
                     + fi.Name
                     + "</a><a  target=\"_blank\"  href='" + @"file/text/"
                     + fi.Name + "'  >" + "     浏览        " + "</a></td>";
                }
                 
                //    page.Alink= "<a  target=\"_blank\"  href='" + "file/" + fi.Name + "'  >" + fi.Name + "</a>";
                page.path = fi.FullName;
                page.title = fi.Name;
                page.addtime = fi.LastWriteTime.ToString();
                page.text = "";
                pageList.Add(page);
            }
        }

        public List<PageFile> GetScnnerList()
        {
            return pageList;
        }

        public string GetScannerString()
        {
            string links=string.Empty;
            foreach(PageFile page in pageList )
            {
            links+= page.Alink+" <br/>";
            }
            return links;

        }
    }
}