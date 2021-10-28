
namespace WeatherApiProject
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
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelLocalTime = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelLocationResult = new System.Windows.Forms.Label();
            this.labelLocalTimeResult = new System.Windows.Forms.Label();
            this.labelTemperatureResult = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.pictureBoxWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(73, 113);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(69, 25);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocation.Location = new System.Drawing.Point(73, 181);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(84, 25);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location";
            // 
            // labelLocalTime
            // 
            this.labelLocalTime.AutoSize = true;
            this.labelLocalTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocalTime.Location = new System.Drawing.Point(73, 249);
            this.labelLocalTime.Name = "labelLocalTime";
            this.labelLocalTime.Size = new System.Drawing.Size(102, 25);
            this.labelLocalTime.TabIndex = 2;
            this.labelLocalTime.Text = "Local Time";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTemperature.Location = new System.Drawing.Point(73, 317);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(118, 25);
            this.labelTemperature.TabIndex = 3;
            this.labelTemperature.Text = "Temperature";
            // 
            // labelLocationResult
            // 
            this.labelLocationResult.AutoSize = true;
            this.labelLocationResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocationResult.Location = new System.Drawing.Point(225, 183);
            this.labelLocationResult.Name = "labelLocationResult";
            this.labelLocationResult.Size = new System.Drawing.Size(136, 25);
            this.labelLocationResult.TabIndex = 4;
            this.labelLocationResult.Text = "Location result";
            // 
            // labelLocalTimeResult
            // 
            this.labelLocalTimeResult.AutoSize = true;
            this.labelLocalTimeResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocalTimeResult.Location = new System.Drawing.Point(225, 249);
            this.labelLocalTimeResult.Name = "labelLocalTimeResult";
            this.labelLocalTimeResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLocalTimeResult.Size = new System.Drawing.Size(154, 25);
            this.labelLocalTimeResult.TabIndex = 5;
            this.labelLocalTimeResult.Text = "Local Time result";
            // 
            // labelTemperatureResult
            // 
            this.labelTemperatureResult.AutoSize = true;
            this.labelTemperatureResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTemperatureResult.Location = new System.Drawing.Point(225, 315);
            this.labelTemperatureResult.Name = "labelTemperatureResult";
            this.labelTemperatureResult.Size = new System.Drawing.Size(170, 25);
            this.labelTemperatureResult.TabIndex = 6;
            this.labelTemperatureResult.Text = "Temperature result";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(225, 109);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 33);
            this.textBoxSearch.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(479, 109);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 33);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.Location = new System.Drawing.Point(624, 109);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(104, 33);
            this.buttonSettings.TabIndex = 9;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxWeatherIcon
            // 
            this.pictureBoxWeatherIcon.Location = new System.Drawing.Point(510, 282);
            this.pictureBoxWeatherIcon.Name = "pictureBoxWeatherIcon";
            this.pictureBoxWeatherIcon.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxWeatherIcon.TabIndex = 10;
            this.pictureBoxWeatherIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxWeatherIcon);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelTemperatureResult);
            this.Controls.Add(this.labelLocalTimeResult);
            this.Controls.Add(this.labelLocationResult);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelLocalTime);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelSearch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather#";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelLocalTime;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelLocationResult;
        private System.Windows.Forms.Label labelLocalTimeResult;
        private System.Windows.Forms.Label labelTemperatureResult;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon;
    }
}

