using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace cs_laicigou
{
    public partial class Form1 : Form
    {
        bool isrunning = false;
        string cookie = "";
        double max_price = 0.0;

        string cha = "";
        string seed = "";
        string newseed = "";

        public Form1()
        {
            InitializeComponent();
        }


        //启动事件
        private void Form1_Load(object sender, EventArgs e)
        {
            cookie = textBox_cookie.Text.Trim();
        }

        //开始刷新
        private void button_refresh_Click(object sender, EventArgs e)
        {
            isrunning = !isrunning;
            if (isrunning)
            {
                //cookie = textBox_cookie.Text.Trim();
                max_price = Convert.ToDouble(textBox_max.Text);
                button_refresh.Text = "停止";
                timer1.Interval = 1;
                timer1.Start();
            }
            else {
                button_refresh.Text = "开始";
                timer1.Stop();
            }
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            string ret = "";
            try
            {
                ret = Dog.queryPetsOnSale();
                JObject res_j = (JObject)JsonConvert.DeserializeObject(ret);
                JArray res_ja = (JArray)res_j["data"]["petsOnSale"];

                JObject apet = (JObject)res_ja[0];

                textBox_output.AppendText("==============\r\n");


                double price = Convert.ToDouble(apet["amount"]);
                textBox_output.AppendText("" + price + "\r\n");


                if (price <= max_price)
                {
                    string petid=(string)apet["petId"];
                    string vcode=(string)apet["validCode"];
                    string price_str=(string)apet["amount"];
                    string newret=Dog.buyPet(petid, vcode, cookie, price_str, seed, cha);
                    textBox_output.AppendText(newret + "\r\n");
                }


                ////listView1.Items.Clear();
                //for (int i = 0; i < res_ja.Count; i++)
                //{
                //    ListViewItem lvi = new ListViewItem((string)res_ja[i]["id"]);
                //    lvi.SubItems.Add((string)res_ja[i]["petId"]);
                //    lvi.SubItems.Add((string)res_ja[i]["birthType"]);
                //    lvi.SubItems.Add((string)res_ja[i]["mutation"]);
                //    lvi.SubItems.Add((string)res_ja[i]["generation"]);
                //    lvi.SubItems.Add((string)res_ja[i]["rareDegree"]);
                //    lvi.SubItems.Add((string)res_ja[i]["desc"]);
                //    lvi.SubItems.Add((string)res_ja[i]["petType"]);
                //    lvi.SubItems.Add((string)res_ja[i]["amount"]);
                //    lvi.SubItems.Add((string)res_ja[i]["bgColor"]);
                //    lvi.SubItems.Add((string)res_ja[i]["petUrl"]);
                //    //listView1.Items.Add(lvi);
                //}
            }
            catch (Exception ex)
            {
                //MessageBox.Show("获取失败~");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        //input cha
        private void textBox_cha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //推这次的参数上去
                    cha = textBox_cha.Text.Trim();
                    seed = newseed;

                    //拿下次的码&显示，seed存newseed
                    string ret = Dog.getCha(cookie);
                    JObject res_j = (JObject)JsonConvert.DeserializeObject(ret);
                    //MessageBox.Show(ret);
                    newseed = (string)res_j["data"]["seed"];
                    string img = (string)res_j["data"]["img"];

                    pictureBox1.Image = Dog.str2Image(img);


                    //清空自己
                    textBox_cha.Clear();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        //获取用户信息
        private void button_getuser_Click(object sender, EventArgs e)
        {
            string ret = Dog.showUser(cookie);
            JObject res_j = (JObject)JsonConvert.DeserializeObject(ret);
            //MessageBox.Show(ret);
            string u_name = (string)res_j["data"]["userName"];
            string u_amount = (string)res_j["data"]["amount"];
            textBox_user.Text = "name:" + u_name + "\r\n" +
                "amount:" + u_amount + "\r\n";
        }


        //cookie自动填充
        private void textBox_cookie_Leave(object sender, EventArgs e)
        {
            cookie = textBox_cookie.Text.Trim();
        }



    }
}
