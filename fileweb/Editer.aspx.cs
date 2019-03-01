using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fileweb
{
    public partial class Editer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    if (Request.QueryString["txt"].Length > 0)
                    {

                        string text = DoIo.Reader(Server.MapPath(Request.QueryString["txt"].ToString()));
                        text = text.Remove(1, text.IndexOf("<div id='content'>"));
                        text = text.Replace("</body>", "");
                        text = text.Replace("</html>", "");
                      
                         FreeTextBox1.Text = text;
                    }
                    if (Request.QueryString["title"].Length > 0)
                    {
                        TextBox1.Text = Request.QueryString["title"].ToString();
                    }
                }
               
            }
        }


        public string filedir()
        {
            Scanner scn = new Scanner(Scanner.Path_File, true);
            return scn.GetScannerString();
        }

        public string pagedir()
        {
            Scanner scn = new Scanner(Scanner.Path_Page,false);
            return scn.GetScannerString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string title = "Test";
            string s = FreeTextBox1.Text;
            if (!string.IsNullOrEmpty(TextBox1.Text.Trim().ToString()))
            {
                title = TextBox1.Text.Trim();
            }
             DoIo.Create(DoIo.Apppath + @"\file\text\"+title+@" .html", new DiyPage(title,s).GetPageStr());
        }
    }
}