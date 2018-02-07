using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Drawing;

namespace cs_laicigou
{
    class Dog
    {
        public static string queryPetsOnSale() {
            HttpWebRequest request;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            int a = (int)(DateTime.Now - startTime).TotalSeconds;
            string data_in = "{\"pageNo\":1,\"pageSize\":1,\"querySortType\":\"AMOUNT_ASC\",\"petIds\":[],\"lastRareDegree\":null,\"requestId\":" + (a) + ",\"appId\":1,\"tpl\":\"\"}";

            string post_url = "https://pet-chain.baidu.com/data/market/queryPetsOnSale";
            request = (HttpWebRequest)WebRequest.Create(post_url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            //request.Timeout = 3000;

            //初始化httpwebrequest对象

            request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            byte[] data = (Encoding.GetEncoding("utf-8")).GetBytes(data_in);

            request.GetRequestStream().Write(data, 0, data.Length);

            HttpWebResponse res = (HttpWebResponse)request.GetResponse();

            Stream st = res.GetResponseStream();
            Encoding en = Encoding.GetEncoding("utf-8");
            StreamReader st_r = new StreamReader(st, en);
            string res_str = st_r.ReadToEnd();
            st.Close();
            st_r.Close();
            
            return res_str;
        }


        public static string buyPet(string petid,string vcode,string cookie,string price,string seed,string cha) {
            HttpWebRequest request;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            int a = (int)(DateTime.Now - startTime).TotalSeconds;

            string data_in = "{\"petId\":\"" + petid +
                "\",\"amount\":\"" + price +
                "\",\"seed\":\"" + seed +
                "\",\"captcha\":\"" + cha +
                "\",\"validCode\":\"" + vcode +
                "\",\"requestId\":" + (a) + ",\"appId\":1,\"tpl\":\"\"}";

            string post_url = "https://pet-chain.baidu.com/data/txn/create";
            request = (HttpWebRequest)WebRequest.Create(post_url);
            request.Method = "POST";
            request.ContentType = "application/json";
            //request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            //初始化httpwebrequest对象
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("BDUSS", cookie, "/", ".baidu.com"));

            request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            byte[] data = (Encoding.GetEncoding("utf-8")).GetBytes(data_in);

            request.GetRequestStream().Write(data, 0, data.Length);

            HttpWebResponse res = (HttpWebResponse)request.GetResponse();

            Stream st = res.GetResponseStream();
            Encoding en = Encoding.GetEncoding("utf-8");
            StreamReader st_r = new StreamReader(st, en);
            string res_str = st_r.ReadToEnd();
            st.Close();
            st_r.Close();

            return res_str;
        }


        public static string getCha(string cookie) {
            HttpWebRequest request;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            int a = (int)(DateTime.Now - startTime).TotalSeconds;

            string data_in = "{\"requestId\":" + (a) + ",\"appId\":1,\"tpl\":\"\"}";

            string post_url = "https://pet-chain.baidu.com/data/captcha/gen";
            request = (HttpWebRequest)WebRequest.Create(post_url);
            request.Method = "POST";
            request.ContentType = "application/json";
            //request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            //初始化httpwebrequest对象
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("BDUSS", cookie, "/", ".baidu.com"));

            request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            byte[] data = (Encoding.GetEncoding("utf-8")).GetBytes(data_in);

            request.GetRequestStream().Write(data, 0, data.Length);

            HttpWebResponse res = (HttpWebResponse)request.GetResponse();

            Stream st = res.GetResponseStream();
            Encoding en = Encoding.GetEncoding("utf-8");
            StreamReader st_r = new StreamReader(st, en);
            string res_str = st_r.ReadToEnd();
            st.Close();
            st_r.Close();

            return res_str;
        }

        public static Image str2Image(string str)
        {
            byte[] b = Convert.FromBase64String(str);
            MemoryStream ms = new MemoryStream(b);
            Bitmap bitmap = new Bitmap(ms);
            return bitmap;
        }

        public static string showUser(string cookie) {
            HttpWebRequest request;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            int a = (int)(DateTime.Now - startTime).TotalSeconds;

            string data_in = "{\"requestId\":" + (a) + ",\"appId\":1,\"tpl\":\"\"}";

            string post_url = "https://pet-chain.baidu.com/data/user/get";
            request = (HttpWebRequest)WebRequest.Create(post_url);
            request.Method = "POST";
            request.ContentType = "application/json";
            //request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            //初始化httpwebrequest对象
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("BDUSS", cookie, "/", ".baidu.com"));

            request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            byte[] data = (Encoding.GetEncoding("utf-8")).GetBytes(data_in);

            request.GetRequestStream().Write(data, 0, data.Length);

            HttpWebResponse res = (HttpWebResponse)request.GetResponse();

            Stream st = res.GetResponseStream();
            Encoding en = Encoding.GetEncoding("utf-8");
            StreamReader st_r = new StreamReader(st, en);
            string res_str = st_r.ReadToEnd();
            st.Close();
            st_r.Close();

            return res_str;
        }
    }
}
