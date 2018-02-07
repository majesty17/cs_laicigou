using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

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


        public static string buyPet(string petid) {
            HttpWebRequest request;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            int a = (int)(DateTime.Now - startTime).TotalSeconds;

            string data_in = "{\"petId\": \"" + petid +
                "\", \"requestId\": " + (a) +
                "000, \"appId\": 1, \"tpl\": \"\"}";

            string post_url = "https://pet-chain.baidu.com/data/txn/create";
            request = (HttpWebRequest)WebRequest.Create(post_url);
            request.Method = "POST";
            request.ContentType = "application/json";
            //request.ContentLength = Encoding.UTF8.GetByteCount(data_in);
            //初始化httpwebrequest对象
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("BIDUPSID", "E735CD8BECBE9DB5B77A842E6CCB6F50", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("PSTM", "1510255801", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("__cfduid", "dbb622b4363154ef7f9f69a4558af1bfa1511890840", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("BAIDUID", "958B98C86EF05C1EBF83D17F610C6CE0:FG", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("BDUSS", "mZrR0NPak0zT0FURWNobDJJcU5BTH5MUXZ3U3pJemMybUZpcnpGVnVWY1AyWDlhQVFBQUFBJCQAAAAAAAAAAAEAAADfcKMjbWFqZXN0eTE3AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA9MWFoPTFhaS", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("MCITY", "131-131%3A", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("BDRCVFR[mkUqnUt8juD]", "mk3SLVN4HKm", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("BDRCVFR[BIMQ49Drrdf]", "mk3SLVN4HKm", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("BDRCVFR[dG2JNJb_ajR]", "mk3SLVN4HKm", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("locale", "zh", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("PSINO", "2", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("H_PS_PSSID", "1446_21093_20691", "/", ".baidu.com"));
            request.CookieContainer.Add(new Cookie("BDORZ", "FFFB88E999055A3F8A630C64834BD6D0", "/", ".baidu.com"));

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
