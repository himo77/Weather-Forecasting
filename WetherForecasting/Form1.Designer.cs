namespace WetherForecasting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAirTemp = new System.Windows.Forms.TextBox();
            this.txtWindChill = new System.Windows.Forms.TextBox();
            this.txtSnowFall = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Air Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Snowfall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wind Chill";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(488, 588);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 37);
            this.lblStatus.TabIndex = 3;
            // 
            // txtAirTemp
            // 
            this.txtAirTemp.Location = new System.Drawing.Point(680, 210);
            this.txtAirTemp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAirTemp.Name = "txtAirTemp";
            this.txtAirTemp.Size = new System.Drawing.Size(388, 31);
            this.txtAirTemp.TabIndex = 4;
            this.txtAirTemp.Text = "0";
            this.txtAirTemp.TextChanged += new System.EventHandler(this.txtAirTemp_TextChanged);
            // 
            // txtWindChill
            // 
            this.txtWindChill.Location = new System.Drawing.Point(680, 308);
            this.txtWindChill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWindChill.Name = "txtWindChill";
            this.txtWindChill.Size = new System.Drawing.Size(388, 31);
            this.txtWindChill.TabIndex = 5;
            this.txtWindChill.Text = "0";
            this.txtWindChill.TextChanged += new System.EventHandler(this.txtWindChill_TextChanged);
            // 
            // txtSnowFall
            // 
            this.txtSnowFall.Location = new System.Drawing.Point(680, 406);
            this.txtSnowFall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSnowFall.Name = "txtSnowFall";
            this.txtSnowFall.Size = new System.Drawing.Size(388, 31);
            this.txtSnowFall.TabIndex = 6;
            this.txtSnowFall.Text = "0";
            this.txtSnowFall.TextChanged += new System.EventHandler(this.txtSnowFall_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.txtSnowFall);
            this.Controls.Add(this.txtWindChill);
            this.Controls.Add(this.txtAirTemp);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Wether ForeCast";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAirTemp;
        private System.Windows.Forms.TextBox txtWindChill;
        private System.Windows.Forms.TextBox txtSnowFall;
    }
}

