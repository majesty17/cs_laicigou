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
        public Form1()
        {
            InitializeComponent();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            isrunning = !isrunning;
            if (isrunning)
            {
                button_refresh.Text = "停止";
                timer1.Interval = 1;
                timer1.Start();
            }
            else {
                button_refresh.Text = "开始";
                timer1.Stop();
            }
        }



        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = listView1.SelectedItems[0].SubItems[1].Text;
            //MessageBox.Show(id);\
            try { MessageBox.Show(Dog.buyPet(id)); }
            catch (Exception ex) { 
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
                listView1.Items.Clear();
                for (int i = 0; i < res_ja.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem((string)res_ja[i]["id"]);
                    lvi.SubItems.Add((string)res_ja[i]["petId"]);
                    lvi.SubItems.Add((string)res_ja[i]["birthType"]);
                    lvi.SubItems.Add((string)res_ja[i]["mutation"]);
                    lvi.SubItems.Add((string)res_ja[i]["generation"]);
                    lvi.SubItems.Add((string)res_ja[i]["rareDegree"]);
                    lvi.SubItems.Add((string)res_ja[i]["desc"]);
                    lvi.SubItems.Add((string)res_ja[i]["petType"]);
                    lvi.SubItems.Add((string)res_ja[i]["amount"]);
                    lvi.SubItems.Add((string)res_ja[i]["bgColor"]);
                    lvi.SubItems.Add((string)res_ja[i]["petUrl"]);
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("获取失败~");
            }
        }
    }
}
