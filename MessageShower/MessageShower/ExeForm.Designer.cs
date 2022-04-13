namespace MessageShower
{
    partial class ExeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExeForm));
            this.contentTWPanel = new System.Windows.Forms.Panel();
            this.contentTWLabel = new System.Windows.Forms.Label();
            this.contentUSPanel = new System.Windows.Forms.Panel();
            this.contentUSLabel = new System.Windows.Forms.Label();
            this.cencelButton = new System.Windows.Forms.Button();
            this.executionButton = new System.Windows.Forms.Button();
            this.executionProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.executionProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.contentTWPanel.SuspendLayout();
            this.contentUSPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTWPanel
            // 
            this.contentTWPanel.Controls.Add(this.contentTWLabel);
            this.contentTWPanel.Location = new System.Drawing.Point(12, 12);
            this.contentTWPanel.Name = "contentTWPanel";
            this.contentTWPanel.Size = new System.Drawing.Size(560, 150);
            this.contentTWPanel.TabIndex = 2;
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
            this.contentUSPanel.TabIndex = 3;
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
            // cencelButton
            // 
            this.cencelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cencelButton.Location = new System.Drawing.Point(422, 398);
            this.cencelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cencelButton.Name = "cencelButton";
            this.cencelButton.Size = new System.Drawing.Size(150, 50);
            this.cencelButton.TabIndex = 4;
            this.cencelButton.Text = "cencelButton";
            this.cencelButton.UseVisualStyleBackColor = true;
            this.cencelButton.Click += new System.EventHandler(this.cencelButton_Click);
            // 
            // executionButton
            // 
            this.executionButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionButton.Location = new System.Drawing.Point(266, 398);
            this.executionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.executionButton.Name = "executionButton";
            this.executionButton.Size = new System.Drawing.Size(150, 50);
            this.executionButton.TabIndex = 5;
            this.executionButton.Text = "executionButton";
            this.executionButton.UseVisualStyleBackColor = true;
            this.executionButton.Click += new System.EventHandler(this.executionButton_Click);
            // 
            // executionProgressBar
            // 
            this.executionProgressBar.Location = new System.Drawing.Point(12, 324);
            this.executionProgressBar.Name = "executionProgressBar";
            this.executionProgressBar.Size = new System.Drawing.Size(560, 23);
            this.executionProgressBar.TabIndex = 6;
            // 
            // progressLabel
            // 
            this.progressLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.progressLabel.Location = new System.Drawing.Point(476, 350);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(96, 20);
            this.progressLabel.TabIndex = 7;
            this.progressLabel.Text = "0 / 100";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // executionProgressTimer
            // 
            this.executionProgressTimer.Tick += new System.EventHandler(this.executionProgressTimer_Tick);
            // 
            // ExeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.executionProgressBar);
            this.Controls.Add(this.executionButton);
            this.Controls.Add(this.cencelButton);
            this.Controls.Add(this.contentUSPanel);
            this.Controls.Add(this.contentTWPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exe Form";
            this.Load += new System.EventHandler(this.ExeForm_Load);
            this.contentTWPanel.ResumeLayout(false);
            this.contentTWPanel.PerformLayout();
            this.contentUSPanel.ResumeLayout(false);
            this.contentUSPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentTWPanel;
        private System.Windows.Forms.Label contentTWLabel;
        private System.Windows.Forms.Panel contentUSPanel;
        private System.Windows.Forms.Label contentUSLabel;
        private System.Windows.Forms.Button cencelButton;
        private System.Windows.Forms.Button executionButton;
        private System.Windows.Forms.ProgressBar executionProgressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Timer executionProgressTimer;
    }
}