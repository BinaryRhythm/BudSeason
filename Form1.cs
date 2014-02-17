using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Threading;

namespace BudSeason
{
    public partial class budSeason : Form
    {
        string access_token = null;
        List<Album> albums = null;
       
        public budSeason()
        {
            InitializeComponent();

            webBrowser1.Navigate("https://graph.renren.com/oauth/authorize?" +
            "client_id=d8e2cdcb09114343b0d4a7de07527c83&redirect_uri=http://graph.renren.com/oauth/login_success.html&response_type=token&display=popup&scope=read_user_photo+read_user_album");

         
        }

     
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string str = webBrowser1.Url.ToString();
            string token = str.Substring(str.IndexOf("=") + 1, str.IndexOf("&") - str.IndexOf("=") - 1);
            access_token = token;
        }

        private List<Album> getAlbum()
        {
            string method = "photos.getAlbums";
            string v = "1.0";
            string sig;
            string format = "JSON";
            string uid = friendID.Text;   //255123489
            string count = "50";
            if (friendID.Text == null)
            {
                MessageBox.Show("ID 不能为空");
                return null;
            }
            if (uid.Equals("261923811") || uid.Equals("259919719"))
            {
                MessageBox.Show("主人不允许下载！");
                return null;
            }

            string p = "access_token=" + access_token + "count=" + count + "format=" + format + "method=" + method + "uid=" + uid + "v=" + v + "05139d1be52d4a42b3fb98efe45064f6";
            sig = MD5Encrpt(p);

            string s = "http://api.renren.com/restserver.do?method=photos.getAlbums&v=1.0&uid="+uid+"&count=50" + "&access_token=" + access_token + "&format=" + format + 
"&sig=" + sig;

            
            HttpWebRequest HttpWReq =
(HttpWebRequest)WebRequest.Create(s);

            HttpWReq.Method = "POST";

            HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();

            Stream kkk = HttpWResp.GetResponseStream();

            StreamReader ssr = new StreamReader(kkk, Encoding.GetEncoding("UTF-8"));
            string cont = ssr.ReadToEnd();
            HttpWResp.Close();

            List<Album> list = new JavaScriptSerializer().Deserialize<List<Album>>(cont);

            StringBuilder sbList = new StringBuilder();
       
            checkedListBox1.Items.Clear();

            if (list == null)
            {
                MessageBox.Show("必须先加她好友才能获取相册。");
            }
            else if (list.Count <= 0)
            {
                MessageBox.Show("没有相册！");
            }

            foreach (Album f in list)
            {
                checkedListBox1.Items.Add(f.name);
            }
            if (list.Count > 0)
                return list;
            else
                return null;
        }

        // MD5 加密
        public static string MD5Encrpt(string plainText)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            StringBuilder sbList = new StringBuilder();
            foreach (byte d in data)
            {
                sbList.Append(d.ToString("x2"));
            }
            return sbList.ToString();
        }

        private bool savePic(string from,string to)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(from, to);
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        private void btn_addr_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDlg = new FolderBrowserDialog();
            fbDlg.Reset();
            fbDlg.ShowNewFolderButton = true;
            fbDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            
            if (fbDlg.ShowDialog() == DialogResult.OK)
            {
                tb_addr.Text = fbDlg.SelectedPath;
            }

        }

        private void btn_getalbums_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(getAlbumThread));
            t.Start();
            
        }

        private void getAlbumThread()
        {
            albums = getAlbum();
        }
        
        private void btn_down_Click(object sender, EventArgs e)
        {
            //判断哪些相册被选中
            if (albums == null)
            {
                MessageBox.Show("相册为空！");
                return;
            }
            else if (albums.Count <= 0)
            {
                MessageBox.Show("相册为空！");
                return;
            }

            if (tb_addr.Text == null || tb_addr.Text.Equals(""))
            {
                MessageBox.Show("下载到本地的地址不能为空。");
                return;
            }

            Thread t = new Thread(new ThreadStart(getAndSavePic));
            t.Start();
          
        }

        private void getAndSavePic()
        { 
             for (int m = 0; m < checkedListBox1.Items.Count; m++)
            {
                if (checkedListBox1.GetItemCheckState(m) == CheckState.Checked)
                {
                    string first = albums.ElementAt(m).name;
                    if (first.Length > 5) first = first.Substring(0,5)+ "…";
                    downAlbumName.Text = first + ":";
                    photoSum.Text = "共" + albums.ElementAt(m).size + "张";
                    List<Picture> photoList = getPhotosById(albums.ElementAt(m).aid);
  
                    if (photoList == null)
                        return;
                    else if (photoList.Count <= 0)
                        return;
                    for (int i = 0; i < photoList.Count; i++)
                    {
                        savePic(photoList.ElementAt(i).url_large, tb_addr.Text+ "\\" + albums.ElementAt(m).name + i.ToString() + ".jpg");
                        photoNum.Text = "已下载："+(i+1).ToString();
                    }
                }
            }
    
             
        }

        private List<Picture> getPhotosById(string id)
        {
            string method = "photos.get";
            string v = "1.0";
            string sig;
            string format = "JSON";
            string uid = friendID.Text;
            string count = "199";
            string aid = id;

            string p = "access_token=" + access_token + "aid="+aid + "count="+count+"format=" + format + "method=" + method  +"uid=" + uid + "v=" + v + "05139d1be52d4a42b3fb98efe45064f6";

            sig = MD5Encrpt(p);

            string s = "http://api.renren.com/restserver.do?method=photos.get&v=1.0&uid="+uid+"&aid="+ aid + "&count="+count +"&access_token=" + access_token + "&format=" + format +
"&sig=" + sig;


            HttpWebRequest httpWReq =
(HttpWebRequest)WebRequest.Create(s);

            httpWReq.Method = "POST";

            HttpWebResponse httpWResp = (HttpWebResponse)httpWReq.GetResponse();


            Stream sreamTemp = httpWResp.GetResponseStream();

            StreamReader sr = new StreamReader(sreamTemp, Encoding.GetEncoding("UTF-8"));

            string photos = sr.ReadToEnd();
            httpWResp.Close();

            List<Picture> lista = new JavaScriptSerializer().Deserialize<List<Picture>>(photos);   //这里匹配时的空串如何处理还是个未知数？？？？？？？？？？？？
       
            StringBuilder sbList = new StringBuilder();
            if (lista.Count > 0)
                return lista;
            else
                return null;
        }

        private void budSeason_Load(object sender, EventArgs e)
        {
            linkLabel1.Links[0].LinkData = "http://www.ytuhub.com";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

      
      

        
    }
}
