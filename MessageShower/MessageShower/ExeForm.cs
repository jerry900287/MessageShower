using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace MessageShower
{
    public partial class ExeForm : Form
    {
        private string titleText = string.Empty;
        private string contentTWText = string.Empty;
        private string contentUSText = string.Empty;
        private string executionFile = string.Empty;
        private int executionCompletedStatus = -1;
        private bool executionCompledted = false;

        public ExeForm()
        {
            InitializeComponent();
        }
        public ExeForm(string[] args)
        {
            InitializeComponent();
            titleText = args[0];
            contentTWText = args[1];
            contentUSText = args[2];
            executionFile = args[3];
        }

        private void ExeForm_Load(object sender, EventArgs e)
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
            this.progressLabel.Text = "";
            this.progressLabel.AutoSize = false;

            this.contentTWLabel.AutoSize = true;
            this.contentTWLabel.MaximumSize = new System.Drawing.Size(contentTWPanel.Width, 0);
            this.contentTWLabel.Text = contentTWText;

            this.contentUSLabel.AutoSize = true;
            this.contentUSLabel.MaximumSize = new System.Drawing.Size(contentUSPanel.Width, 0);
            this.contentUSLabel.Text = contentUSText;

            this.executionButton.Text = "執行 (Execute)";
            this.cencelButton.Text = "取消 (Cancel)";

            this.executionProgressBar.Minimum = 0;
            this.executionProgressBar.Maximum = 3600; //1小時
            this.executionProgressBar.Step = 1;
            this.executionProgressTimer.Interval = 1000; //1秒
            
        }

        private void executionProgressTimer_Tick(object sender, EventArgs e)
        {

            if (this.executionProgressBar.Value >= executionProgressBar.Maximum )
            {
                this.executionProgressTimer.Enabled = false;

                if (executionCompletedStatus == 0)
                {
                    MessageBox.Show(this, "執行完成! (Completed!)", "System Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "執行發生錯誤, 請洽系統管理員! (Error! Please call system administrator!)", "System Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Application.Exit();
            }

            if (this.executionCompledted)
            {
                this.executionProgressBar.Step = 100;
                this.executionProgressTimer.Interval = 1;
            }

            this.executionProgressBar.PerformStep();
            this.progressLabel.Text = string.Format(@"{0} / 100", Math.Ceiling((this.executionProgressBar.Value * 1.0f / this.executionProgressBar.Maximum) * 100));
        }
        

        private void executionButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show(this,"確定執行嗎? (Execute it?)", "System Info", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                this.executionButton.Enabled = false;
                this.cencelButton.Enabled = false;
                this.executionProgressTimer.Enabled = true;
                //CallPowershellProcess(executionFile);
                Thread thread = new Thread(() => CallPowershellProcess(executionFile));
                thread.Start();
                
            }
            else if (Result == DialogResult.Cancel)
            {
               
            }
        }

        private void cencelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CallPowershellProcess(string commandLine)
        {

            int resultStatus = 0;
            string result = string.Empty;
            string arguments = string.Empty;
            string filename = @"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe";
            System.Diagnostics.Process process;

            using (process = new System.Diagnostics.Process())
            {
                arguments = string.Format(@"{0}\{1}", Application.StartupPath, commandLine);
                process.StartInfo.FileName = filename;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = false;

                process.StartInfo.Arguments = arguments;
                process.Start();

                process.WaitForExit();
                resultStatus = process.ExitCode;
            }
            this.executionCompletedStatus = resultStatus;
            this.executionCompledted = true;
        }

        private void CallCMDProcess(string commandLine)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;             //接受來自呼叫程式的輸入資訊
            process.StartInfo.RedirectStandardOutput = false;           //由呼叫程式獲取輸出資訊
            process.StartInfo.RedirectStandardError = false;            //重定向標準錯誤輸出
            process.StartInfo.CreateNoWindow = true;                    //不跳出cmd視窗
            process.Start();                                            // 啟動程式
            process.StandardInput.WriteLine(@"{0}\{1}", Application.StartupPath, commandLine);//向cmd視窗傳送輸入資訊
            process.Close();                                            //關閉程式
        }


    }
}
