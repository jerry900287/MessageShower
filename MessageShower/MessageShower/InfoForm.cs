using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MessageShower.Program;

namespace MessageShower
{
    public partial class InfoForm : Form
    {
        private string titleText = string.Empty;
        private string contentTWText = string.Empty;
        private string contentUSText = string.Empty;

        public InfoForm()
        {
            InitializeComponent();
        }
        public InfoForm(string[] args)
        {
            InitializeComponent();
            titleText = args[0];
            contentTWText = args[1];
            contentUSText = args[2];
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;                                            //關閉控制鈕
            this.MaximizeBox = false;                                           //關閉放大鈕
            this.MinimizeBox = false;                                           //關閉縮小鈕
            this.AutoSize = false;                                              //關閉容納文字視窗縮放
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;        //隨著解析度伸展
            this.FormBorderStyle = FormBorderStyle.FixedSingle;                 //固定視窗大小
            this.TopMost = true;                                                //視窗顯示最上層
            this.ShowInTaskbar = false;                                         //不要顯示在工作列上

            this.Text = titleText;

            this.contentTWLabel.AutoSize = true;
            this.contentTWLabel.MaximumSize = new System.Drawing.Size(contentTWPanel.Width, 0);
            this.contentTWLabel.Text = contentTWText;

            this.contentUSLabel.AutoSize = true;
            this.contentUSLabel.MaximumSize = new System.Drawing.Size(contentUSPanel.Width, 0);
            this.contentUSLabel.Text = contentUSText;

            this.confirmButton.Text = "OK";
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
