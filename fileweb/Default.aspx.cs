using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace fileweb
{
    public partial class _Default : System.Web.UI.Page
    {
      
        int ishave=0;
        public List<string> msl = null;
        public static string filetxt = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Environment.CurrentDirectory;
            filetxt = filedir()+pagedir();
            Timer1.Interval = 1000;
            Timer1.Enabled = true;

           
          //  Response.Write("");

        }

        

      ///
      ///文件目录获取更新 
      ///
        public string filedir()
        {
            Scanner scn = new  Scanner(Scanner.Path_File,true);
            return scn.GetScannerString();
        }

        public string pagedir()
        {
            Scanner scn = new Scanner(Scanner.Path_Page);
            return scn.GetScannerString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    string path = Server.MapPath("~/file/") + FileUpload1.FileName;
                    FileUpload1.SaveAs(path);
                    Label1.Text = "上传成功";
                    Response.Redirect("Default.aspx");

                }
                else
                {
                    Label1.Text = "不能上传空文件";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "发生错误" + ex;
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

            Label2.Text = "您的消息准备发射...";
             ishave = (int)Application["status"];
            if (ishave > 0)
            { 
                Label2.Text = "消息已经发射到我的世界->请等待轩然大波！";

            }
                msl = (List<string>)Application["mslist"];
                ListBox1.Items.Clear();
                foreach (string s in msl)
                {
                    ListBox1.Items.Add(s);
                }
                ishave--;
                Application.Set("status", ishave);
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
                
           
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           ishave++;
           Application.Set("status", ishave);
          string s = TextBox1.Text;
          List<string> ls= (List<string>)Application["mslist"];
          s = DateTime.Now.ToLocalTime() + " :" + ""+ " 有人说 -> " + ":" + s;
          ls.Add(s);
          Application.Remove("mslist");
          Application.Add("mslist", ls);
          TextBox1.Text = "";
        }

    }
}
