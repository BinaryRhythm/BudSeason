namespace BudSeason
{
    partial class budSeason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(budSeason));
            this.btn_down = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addr = new System.Windows.Forms.Button();
            this.btn_getalbums = new System.Windows.Forms.Button();
            this.downAlbumName = new System.Windows.Forms.Label();
            this.photoNum = new System.Windows.Forms.Label();
            this.photoSum = new System.Windows.Forms.Label();
            this.friendID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(596, 298);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(88, 35);
            this.btn_down.TabIndex = 0;
            this.btn_down.Text = "下载相册";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(422, 324);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(455, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(192, 169);
            this.checkedListBox1.TabIndex = 2;
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(442, 237);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(162, 20);
            this.tb_addr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "下载到：";
            // 
            // btn_addr
            // 
            this.btn_addr.Location = new System.Drawing.Point(618, 233);
            this.btn_addr.Name = "btn_addr";
            this.btn_addr.Size = new System.Drawing.Size(66, 27);
            this.btn_addr.TabIndex = 5;
            this.btn_addr.Text = "浏览...";
            this.btn_addr.UseVisualStyleBackColor = true;
            this.btn_addr.Click += new System.EventHandler(this.btn_addr_Click);
            // 
            // btn_getalbums
            // 
            this.btn_getalbums.Location = new System.Drawing.Point(462, 298);
            this.btn_getalbums.Name = "btn_getalbums";
            this.btn_getalbums.Size = new System.Drawing.Size(94, 35);
            this.btn_getalbums.TabIndex = 6;
            this.btn_getalbums.Text = "获取相册";
            this.btn_getalbums.UseVisualStyleBackColor = true;
            this.btn_getalbums.Click += new System.EventHandler(this.btn_getalbums_Click);
            // 
            // downAlbumName
            // 
            this.downAlbumName.AutoSize = true;
            this.downAlbumName.Location = new System.Drawing.Point(443, 269);
            this.downAlbumName.Name = "downAlbumName";
            this.downAlbumName.Size = new System.Drawing.Size(67, 13);
            this.downAlbumName.TabIndex = 7;
            this.downAlbumName.Text = "下载相册：";
            // 
            // photoNum
            // 
            this.photoNum.AutoSize = true;
            this.photoNum.Location = new System.Drawing.Point(590, 269);
            this.photoNum.Name = "photoNum";
            this.photoNum.Size = new System.Drawing.Size(67, 13);
            this.photoNum.TabIndex = 8;
            this.photoNum.Text = "已下载数目";
            // 
            // photoSum
            // 
            this.photoSum.AutoSize = true;
            this.photoSum.Location = new System.Drawing.Point(516, 269);
            this.photoSum.Name = "photoSum";
            this.photoSum.Size = new System.Drawing.Size(55, 13);
            this.photoSum.TabIndex = 9;
            this.photoSum.Text = "照片总数";
            // 
            // friendID
            // 
            this.friendID.Location = new System.Drawing.Point(519, 196);
            this.friendID.Name = "friendID";
            this.friendID.Size = new System.Drawing.Size(119, 20);
            this.friendID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "好友ID：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(496, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(198, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made By William-silentbinary@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // budSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 366);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.friendID);
            this.Controls.Add(this.photoSum);
            this.Controls.Add(this.photoNum);
            this.Controls.Add(this.downAlbumName);
            this.Controls.Add(this.btn_getalbums);
            this.Controls.Add(this.btn_addr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_down);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "budSeason";
            this.Text = "iRenRen";
            this.Load += new System.EventHandler(this.budSeason_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addr;
        private System.Windows.Forms.Button btn_getalbums;
        private System.Windows.Forms.Label downAlbumName;
        private System.Windows.Forms.Label photoNum;
        private System.Windows.Forms.Label photoSum;
        private System.Windows.Forms.TextBox friendID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

