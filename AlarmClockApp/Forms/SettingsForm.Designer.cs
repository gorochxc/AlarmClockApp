using System.Windows.Forms;

namespace AlarmClockApp.Forms
{
    partial class SettingsForm
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
            this.alarmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeSetButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alarmTimePicker
            // 
            this.alarmTimePicker.CustomFormat = "HH:mm:ss";
            this.alarmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.alarmTimePicker.Location = new System.Drawing.Point(94, 94);
            this.alarmTimePicker.Name = "alarmTimePicker";
            this.alarmTimePicker.ShowUpDown = true;
            this.alarmTimePicker.Size = new System.Drawing.Size(200, 20);
            this.alarmTimePicker.TabIndex = 0;
            // 
            // TimeSetButton
            // 
            this.TimeSetButton.Location = new System.Drawing.Point(155, 150);
            this.TimeSetButton.Name = "TimeSetButton";
            this.TimeSetButton.Size = new System.Drawing.Size(75, 23);
            this.TimeSetButton.TabIndex = 1;
            this.TimeSetButton.Text = "Set time";
            this.TimeSetButton.UseVisualStyleBackColor = true;
            this.TimeSetButton.Click += new System.EventHandler(this.TimeSetButton_Click);
            // 
            // okButton
            //
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(155, 260);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 302);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.TimeSetButton);
            this.Controls.Add(this.alarmTimePicker);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker alarmTimePicker;
        private System.Windows.Forms.Button TimeSetButton;
        private Button okButton;
    }
}