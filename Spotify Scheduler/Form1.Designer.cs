namespace Spotify_Scheduler
{
    partial class Form1
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeProgressBar = new System.Windows.Forms.ProgressBar();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.albumLinkLabel = new System.Windows.Forms.LinkLabel();
            this.artistLinkLabel = new System.Windows.Forms.LinkLabel();
            this.clientVersionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.skipBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.titleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.isPlayingLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(3, 202);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 17);
            this.timeLabel.TabIndex = 29;
            this.timeLabel.Text = "-";
            // 
            // timeProgressBar
            // 
            this.timeProgressBar.Location = new System.Drawing.Point(6, 176);
            this.timeProgressBar.Name = "timeProgressBar";
            this.timeProgressBar.Size = new System.Drawing.Size(306, 23);
            this.timeProgressBar.TabIndex = 28;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(85, 37);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(13, 17);
            this.versionLabel.TabIndex = 28;
            this.versionLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Artist:";
            // 
            // albumLinkLabel
            // 
            this.albumLinkLabel.AutoSize = true;
            this.albumLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLinkLabel.Location = new System.Drawing.Point(85, 116);
            this.albumLinkLabel.Name = "albumLinkLabel";
            this.albumLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.albumLinkLabel.TabIndex = 7;
            this.albumLinkLabel.TabStop = true;
            this.albumLinkLabel.Text = "-";
            this.albumLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistLinkLabel
            // 
            this.artistLinkLabel.AutoSize = true;
            this.artistLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLinkLabel.Location = new System.Drawing.Point(85, 93);
            this.artistLinkLabel.Name = "artistLinkLabel";
            this.artistLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.artistLinkLabel.TabIndex = 6;
            this.artistLinkLabel.TabStop = true;
            this.artistLinkLabel.Text = "-";
            this.artistLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientVersionLabel
            // 
            this.clientVersionLabel.AutoSize = true;
            this.clientVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientVersionLabel.Location = new System.Drawing.Point(87, 20);
            this.clientVersionLabel.Name = "clientVersionLabel";
            this.clientVersionLabel.Size = new System.Drawing.Size(13, 17);
            this.clientVersionLabel.TabIndex = 26;
            this.clientVersionLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Client-Version";
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipBtn.Location = new System.Drawing.Point(245, 252);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(67, 23);
            this.skipBtn.TabIndex = 24;
            this.skipBtn.Text = "Skip";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.Location = new System.Drawing.Point(164, 252);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 23;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBtn.Location = new System.Drawing.Point(83, 252);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 22;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(6, 252);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(71, 23);
            this.playBtn.TabIndex = 21;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Album:";
            // 
            // titleLinkLabel
            // 
            this.titleLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLinkLabel.AutoSize = true;
            this.titleLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLinkLabel.Location = new System.Drawing.Point(85, 71);
            this.titleLinkLabel.Name = "titleLinkLabel";
            this.titleLinkLabel.Size = new System.Drawing.Size(13, 17);
            this.titleLinkLabel.TabIndex = 5;
            this.titleLinkLabel.TabStop = true;
            this.titleLinkLabel.Text = "-";
            this.titleLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "- -";
            // 
            // isPlayingLabel
            // 
            this.isPlayingLabel.AutoSize = true;
            this.isPlayingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPlayingLabel.Location = new System.Drawing.Point(86, 54);
            this.isPlayingLabel.Name = "isPlayingLabel";
            this.isPlayingLabel.Size = new System.Drawing.Size(13, 17);
            this.isPlayingLabel.TabIndex = 14;
            this.isPlayingLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Is Playing:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.timeProgressBar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.versionLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.albumLinkLabel);
            this.groupBox1.Controls.Add(this.clientVersionLabel);
            this.groupBox1.Controls.Add(this.artistLinkLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.titleLinkLabel);
            this.groupBox1.Controls.Add(this.skipBtn);
            this.groupBox1.Controls.Add(this.prevBtn);
            this.groupBox1.Controls.Add(this.pauseBtn);
            this.groupBox1.Controls.Add(this.playBtn);
            this.groupBox1.Controls.Add(this.isPlayingLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 286);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spotify Info";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(6, 17);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(318, 23);
            this.connectBtn.TabIndex = 9;
            this.connectBtn.Text = "Connect to Spotify";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(716, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(349, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 316);
            this.listBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Limpiar lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectBtn);
            this.MinimumSize = new System.Drawing.Size(839, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar timeProgressBar;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel albumLinkLabel;
        private System.Windows.Forms.LinkLabel artistLinkLabel;
        private System.Windows.Forms.Label clientVersionLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel titleLinkLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label isPlayingLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

