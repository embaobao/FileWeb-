using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
namespace fileweb
{
    public class DoIo
    {
        public FileInfo file = null;
        private string path;
        public static readonly string Apppath = AppDomain.CurrentDomain.BaseDirectory ;
        public static readonly string ApppDatapath = AppDomain.CurrentDomain.BaseDirectory+@"data\";
        public static readonly string Appconfig= @"data\config.txt";
        public static readonly string AppConfigpath = System.Web.HttpContext.Current.Server.MapPath(@"./data/config.txt");
        public DoIo(string path)
        {
            this.path = path;
           // file = new FileInfo(path);
        }
        public static void Create(string path,string str)
        {
            if (!System.IO.File.Exists(path))
            {
                FileStream stream = System.IO.File.Create(path);
                stream.Close();
                stream.Dispose();
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(str);
            }
       
        }
        public static string Reader( string Path)
        {
            StreamReader sr = new StreamReader(Path);
            return sr.ReadToEnd().ToString();
        }
        public static void AddTXT(string path, string str)
        {
            
            if (!System.IO.File.Exists(path))
            {
                FileStream stream = System.IO.File.Create(path);
                stream.Close();
                stream.Dispose();
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(str);
            }
        }
        public static bool DeleteTxt(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
       
        }
        public static bool Movetxt(string oldPath, string newPath)
        {

            try
            {
                if (File.Exists(oldPath))
                {
                    File.Move(oldPath, newPath);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
       
        }

    }
}