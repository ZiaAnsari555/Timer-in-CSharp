namespace TimerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.developedByEliteAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 165);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00:00";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(151)))));
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.StartBtn.Location = new System.Drawing.Point(27, 91);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(160, 60);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopBtn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StopBtn.Location = new System.Drawing.Point(326, 91);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(160, 60);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.Snow;
            this.ResetBtn.Location = new System.Drawing.Point(612, 91);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(160, 60);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developedByEliteAppsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // developedByEliteAppsToolStripMenuItem
            // 
            this.developedByEliteAppsToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.developedByEliteAppsToolStripMenuItem.Name = "developedByEliteAppsToolStripMenuItem";
            this.developedByEliteAppsToolStripMenuItem.Size = new System.Drawing.Size(205, 25);
            this.developedByEliteAppsToolStripMenuItem.Text = "Developed by Elite Apps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Elite Timer ";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button StartBtn;
        private Button StopBtn;
        private Button ResetBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem developedByEliteAppsToolStripMenuItem;
    }
}