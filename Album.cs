using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudSeason
{
    /*
      “aid”: 34595963571485,
        "url”:”http://fm301.img.renren.com/pic001main_787.jpg”,
        “uid”:8055,
        “name”: “每一天过一天”,
        “create_time”: “2008-01-04”,
        “update_time”: “2008-01-04”,
        “description”: “当和尚也好啊，过一天…”,
        “location”:234,”
        "size”:21,
        “visible”:99,
        “comment_count”:10,
        ”type”:0
     
     */
     [Serializable]
     public class Album
    {
       
            public string aid { get; set; }
            public string url { get; set; }
            public string uid { get; set; }
            public string name { get; set; }
            public string create_time { get; set; }
            public string update_time { get; set; }
            public string description { get; set; }
            public string size { get; set; }
            public string visible { get; set; }
            public string comment_count { get; set; }
            public string type { get; set; }
          
        }
    
}
