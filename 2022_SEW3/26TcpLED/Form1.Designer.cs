
namespace _26TcpLED
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.nud_Port = new System.Windows.Forms.NumericUpDown();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_LED_On = new System.Windows.Forms.Button();
            this.btn_LED_Off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(357, 9);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(95, 25);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // nud_Port
            // 
            this.nud_Port.Location = new System.Drawing.Point(253, 12);
            this.nud_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_Port.Name = "nud_Port";
            this.nud_Port.Size = new System.Drawing.Size(98, 23);
            this.nud_Port.TabIndex = 1;
            this.nud_Port.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            // 
            // txt_Log
            // 
            this.txt_Log.AcceptsReturn = true;
            this.txt_Log.Location = new System.Drawing.Point(12, 41);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(440, 397);
            this.txt_Log.TabIndex = 2;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(12, 12);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(235, 23);
            this.txt_IP.TabIndex = 3;
            // 
            // btn_LED_On
            // 
            this.btn_LED_On.Location = new System.Drawing.Point(458, 9);
            this.btn_LED_On.Name = "btn_LED_On";
            this.btn_LED_On.Size = new System.Drawing.Size(77, 25);
            this.btn_LED_On.TabIndex = 4;
            this.btn_LED_On.Text = "LED ein";
            this.btn_LED_On.UseVisualStyleBackColor = true;
            this.btn_LED_On.Click += new System.EventHandler(this.btn_LED_On_Click);
            // 
            // btn_LED_Off
            // 
            this.btn_LED_Off.Location = new System.Drawing.Point(458, 39);
            this.btn_LED_Off.Name = "btn_LED_Off";
            this.btn_LED_Off.Size = new System.Drawing.Size(77, 25);
            this.btn_LED_Off.TabIndex = 5;
            this.btn_LED_Off.Text = "LED aus";
            this.btn_LED_Off.UseVisualStyleBackColor = true;
            this.btn_LED_Off.Click += new System.EventHandler(this.btn_LED_Off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.btn_LED_Off);
            this.Controls.Add(this.btn_LED_On);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.nud_Port);
            this.Controls.Add(this.btn_Connect);
            this.Name = "Form1";
            this.Text = "TCP LED";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.NumericUpDown nud_Port;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_LED_On;
        private System.Windows.Forms.Button btn_LED_Off;
    }
}

