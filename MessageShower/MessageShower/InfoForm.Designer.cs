namespace MessageShower
{
    partial class InfoForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.confirmButton = new System.Windows.Forms.Button();
            this.contentTWPanel = new System.Windows.Forms.Panel();
            this.contentTWLabel = new System.Windows.Forms.Label();
            this.contentUSPanel = new System.Windows.Forms.Panel();
            this.contentUSLabel = new System.Windows.Forms.Label();
            this.contentTWPanel.SuspendLayout();
            this.contentUSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(218, 388);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 60);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "confirmButton";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // contentTWPanel
            // 
            this.contentTWPanel.Controls.Add(this.contentTWLabel);
            this.contentTWPanel.Location = new System.Drawing.Point(12, 12);
            this.contentTWPanel.Name = "contentTWPanel";
            this.contentTWPanel.Size = new System.Drawing.Size(560, 150);
            this.contentTWPanel.TabIndex = 1;
            // 
            // contentTWLabel
            // 
            this.contentTWLabel.AutoSize = true;
            this.contentTWLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentTWLabel.Location = new System.Drawing.Point(4, 4);
            this.contentTWLabel.Name = "contentTWLabel";
            this.contentTWLabel.Size = new System.Drawing.Size(115, 19);
            this.contentTWLabel.TabIndex = 0;
            this.contentTWLabel.Text = "contentTWLabel";
            // 
            // contentUSPanel
            // 
            this.contentUSPanel.Controls.Add(this.contentUSLabel);
            this.contentUSPanel.Location = new System.Drawing.Point(12, 168);
            this.contentUSPanel.Name = "contentUSPanel";
            this.contentUSPanel.Size = new System.Drawing.Size(560, 150);
            this.contentUSPanel.TabIndex = 2;
            // 
            // contentUSLabel
            // 
            this.contentUSLabel.AutoSize = true;
            this.contentUSLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentUSLabel.Location = new System.Drawing.Point(4, 4);
            this.contentUSLabel.Name = "contentUSLabel";
            this.contentUSLabel.Size = new System.Drawing.Size(110, 19);
            this.contentUSLabel.TabIndex = 0;
            this.contentUSLabel.Text = "contentUSLabel";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.contentUSPanel);
            this.Controls.Add(this.contentTWPanel);
            this.Controls.Add(this.confirmButton);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Form";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.contentTWPanel.ResumeLayout(false);
            this.contentTWPanel.PerformLayout();
            this.contentUSPanel.ResumeLayout(false);
            this.contentUSPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel contentTWPanel;
        private System.Windows.Forms.Label contentTWLabel;
        private System.Windows.Forms.Panel contentUSPanel;
        private System.Windows.Forms.Label contentUSLabel;
    }
}

