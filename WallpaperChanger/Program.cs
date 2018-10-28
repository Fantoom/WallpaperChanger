using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace WallpaperChanger
{


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        [DllImport("User32", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uiAction, int uiParam, string pvParam, uint fWinIni);

        public static bool isSave = false;
        public static string DefLink = "https://source.unsplash.com/";
        public static string link;
        public static string selectedType;
        public static string source;
        public static string keywords;
        public static string width;
        public static string height;
        public static byte[] data;
        public static byte[] CustomData;
        public static Form1 form;

        /// </summary>


        [STAThread]
        static void Main()
        {
            //Check if Application already running
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Application already running. Only one instance of this application is allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check internet connection
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com"))
                {
                  
                }
            }
            catch
            {
                MessageBox.Show("Check Internet connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new Form1());

            Console.WriteLine("main");

            /* t = new System.Windows.Forms.Timer();
             t.Interval = 2000;
             t.Tick += new EventHandler(timer_Tick);
             t.Start();*/
        }
        static void timer_Tick(object sender, EventArgs e)
        {
            changeWallpaper();
        }
        public static void CreateLink()
        {
            // Setting source
            if (selectedType != "any")
            {
                link = DefLink + selectedType + "/" + source + "/";

            }
            else if (selectedType == "any")
            {
                link = DefLink;
            }
            link += width + "x" + height + "/";
            if (keywords.Length > 2)
            {
                link += "?" + keywords + "/";
            }
            // Setting size



            Console.WriteLine(link);
        }
        public static void changeWallpaper()
        {
            System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "saved");
            CreateLink();
            

            using (WebClient client = new WebClient())
            {
                data = client.DownloadData(link);
                form.UpdatePic(ByteToImage(data));
            }
            if (isSave)
            {
                Random rnd = new Random();
                long id = rnd.Next(100000000, 999999999);
                string name = id.ToString();

                File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "saved/" + name + ".jpg", data);
                Console.WriteLine("Image saved with name  " + name + ".jpg");
            }
            File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "temp.jpg", data);
            SystemParametersInfo(0x0014, 0, AppDomain.CurrentDomain.BaseDirectory + "temp.jpg", 0x0001);



        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static Image GetImageByUrl(string url)
        {

            using (WebClient client = new WebClient())
            {
                CustomData = client.DownloadData(url);
            }

            return ByteToImage(CustomData);

        }

        public static void SetCustomWallpaper(string url)
        {
            System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "saved");
            CreateLink();
            

            using (WebClient client = new WebClient())
            {
                data = client.DownloadData(url);
                form.UpdatePic(ByteToImage(data));
            }
            if (isSave)
            {
                Random rnd = new Random();
                long id = rnd.Next(100000000, 999999999);
                string name = id.ToString();

                File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "saved/" + name + ".jpg", data);
                Console.WriteLine("Image saved with name  " + name + ".jpg");
            }
            File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "customTemp.jpg", data);
            SystemParametersInfo(0x0014, 0, AppDomain.CurrentDomain.BaseDirectory + "customTemp.jpg", 0x0001);



        }
        public static void saveCurrent()
        {
            Random rnd = new Random();
            long id = rnd.Next(100000000, 999999999);
            string name = id.ToString();

            File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "saved/" + name + ".jpg", data);
            Console.WriteLine("Image saved with name  " + name + ".jpg");
        }

        public static void showNext()
        {
            CreateLink();
            

            using (WebClient client = new WebClient())
            {
                data = client.DownloadData(link);
                form.UpdatePic(ByteToImage(data));
            }
        }
        public static void setCurrent()
        {
            File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "setTemp.jpg", data);
            SystemParametersInfo(0x0014, 0, AppDomain.CurrentDomain.BaseDirectory + "setTemp.jpg", 0x0001);
        }
    }
}
