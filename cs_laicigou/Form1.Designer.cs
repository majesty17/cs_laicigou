namespace cs_laicigou
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_cha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_cookie = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.button_getuser = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 542);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_cha);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox_output);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_max);
            this.tabPage1.Controls.Add(this.textBox_cookie);
            this.tabPage1.Controls.Add(this.button_refresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "市场";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_cha
            // 
            this.textBox_cha.Location = new System.Drawing.Point(684, 211);
            this.textBox_cha.MaxLength = 4;
            this.textBox_cha.Name = "textBox_cha";
            this.textBox_cha.Size = new System.Drawing.Size(100, 28);
            this.textBox_cha.TabIndex = 11;
            this.textBox_cha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_cha_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(605, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 90);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(8, 84);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(575, 415);
            this.textBox_output.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "MAX PRICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "BDUSS";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(218, 50);
            this.textBox_max.Multiline = true;
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 28);
            this.textBox_max.TabIndex = 6;
            this.textBox_max.Text = "1000.0";
            // 
            // textBox_cookie
            // 
            this.textBox_cookie.Location = new System.Drawing.Point(191, 16);
            this.textBox_cookie.Name = "textBox_cookie";
            this.textBox_cookie.Size = new System.Drawing.Size(629, 28);
            this.textBox_cookie.TabIndex = 5;
            this.textBox_cookie.Text = "1E3QndSfkFCWXRHflBIYmI4bFhVYWFnSUVtNjZKeWZqMzdyNXhJRlpMUXV4YUJhQUFBQUFBJCQAAAAAAA" +
                "AAAAEAAADfcKMjbWFqZXN0eTE3AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAC44eVouOHlab";
            this.textBox_cookie.Leave += new System.EventHandler(this.textBox_cookie_Leave);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(8, 19);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(99, 40);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.Text = "start";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_user);
            this.tabPage2.Controls.Add(this.button_getuser);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "我的";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(8, 50);
            this.textBox_user.Multiline = true;
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(251, 231);
            this.textBox_user.TabIndex = 1;
            // 
            // button_getuser
            // 
            this.button_getuser.Location = new System.Drawing.Point(8, 6);
            this.button_getuser.Name = "button_getuser";
            this.button_getuser.Size = new System.Drawing.Size(107, 38);
            this.button_getuser.TabIndex = 0;
            this.button_getuser.Text = "用户信息";
            this.button_getuser.UseVisualStyleBackColor = true;
            this.button_getuser.Click += new System.EventHandler(this.button_getuser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 542);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_cookie;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_cha;
        private System.Windows.Forms.Button button_getuser;
        private System.Windows.Forms.TextBox textBox_user;
    }
}

