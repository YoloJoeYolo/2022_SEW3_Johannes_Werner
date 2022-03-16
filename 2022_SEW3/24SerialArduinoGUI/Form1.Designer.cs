
namespace _24SerialArduinoGUI
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
            this.btn_LED_ON = new System.Windows.Forms.Button();
            this.btn_LED_OFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LED_ON
            // 
            this.btn_LED_ON.Location = new System.Drawing.Point(12, 12);
            this.btn_LED_ON.Name = "btn_LED_ON";
            this.btn_LED_ON.Size = new System.Drawing.Size(150, 125);
            this.btn_LED_ON.TabIndex = 0;
            this.btn_LED_ON.Text = "LED ON";
            this.btn_LED_ON.UseVisualStyleBackColor = true;
            this.btn_LED_ON.Click += new System.EventHandler(this.btn_LED_ON_Click);
            // 
            // btn_LED_OFF
            // 
            this.btn_LED_OFF.Location = new System.Drawing.Point(168, 12);
            this.btn_LED_OFF.Name = "btn_LED_OFF";
            this.btn_LED_OFF.Size = new System.Drawing.Size(150, 125);
            this.btn_LED_OFF.TabIndex = 1;
            this.btn_LED_OFF.Text = "LED OFF";
            this.btn_LED_OFF.UseVisualStyleBackColor = true;
            this.btn_LED_OFF.Click += new System.EventHandler(this.btn_LED_OFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 151);
            this.Controls.Add(this.btn_LED_OFF);
            this.Controls.Add(this.btn_LED_ON);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LED_ON;
        private System.Windows.Forms.Button btn_LED_OFF;
    }
}

