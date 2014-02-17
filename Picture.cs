using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudSeason
{
    /*
     pid	表示照片的id
aid	表示照片所在相册id
uid	表示一张照片的所有者用户id
url_tiny	表示一张照片超小的规格
url_head	表示一张照片小的规格
url_large	表示一张照片正常的规格
caption	表示照片的描述信息
time	表示照片的上传时间
view_count	表示照片的查看数
comment_count	表示照片的评论数
source	表示照片的来源
text	表示照片来源的名称
href	表示照片来源的url
     */
     [Serializable]
     public class Picture
    {
        public string comment_count { get; set; }
        public string uid { get; set; }
        public string aid { get; set; }
        public string pid { get; set; }
        public string time { get; set; }
        public string url_large { get; set; }
        public string url_head { get; set; }
         
    //   public string source { get; set; }
      //  public string caption { get; set; }
       public string url_tiny { get; set; }
       public string url_main { get; set; }
       public string view_count { get; set; }
          
        }
    
}
