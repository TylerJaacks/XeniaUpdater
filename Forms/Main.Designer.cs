
namespace XeniaUpdater.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.masterUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.canaryUpdateButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.canaryExUpdateButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masterUpdateButton
            // 
            this.masterUpdateButton.Location = new System.Drawing.Point(191, 6);
            this.masterUpdateButton.Name = "masterUpdateButton";
            this.masterUpdateButton.Size = new System.Drawing.Size(69, 23);
            this.masterUpdateButton.TabIndex = 0;
            this.masterUpdateButton.Text = "Update";
            this.masterUpdateButton.UseVisualStyleBackColor = true;
            this.masterUpdateButton.Click += new System.EventHandler(this.updateMasterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xenia Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xenia Canary PR";
            // 
            // canaryUpdateButton
            // 
            this.canaryUpdateButton.Location = new System.Drawing.Point(191, 35);
            this.canaryUpdateButton.Name = "canaryUpdateButton";
            this.canaryUpdateButton.Size = new System.Drawing.Size(69, 23);
            this.canaryUpdateButton.TabIndex = 4;
            this.canaryUpdateButton.Text = "Update";
            this.canaryUpdateButton.UseVisualStyleBackColor = true;
            this.canaryUpdateButton.Click += new System.EventHandler(this.updateCanaryButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 94);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(219, 23);
            this.progressBar.TabIndex = 7;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.BackColor = System.Drawing.Color.Transparent;
            this.percentageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percentageLabel.Location = new System.Drawing.Point(235, 99);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(21, 13);
            this.percentageLabel.TabIndex = 8;
            this.percentageLabel.Text = "0%";
            this.percentageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xenia Canary Ex";
            // 
            // canaryExUpdateButton
            // 
            this.canaryExUpdateButton.Location = new System.Drawing.Point(191, 64);
            this.canaryExUpdateButton.Name = "canaryExUpdateButton";
            this.canaryExUpdateButton.Size = new System.Drawing.Size(69, 23);
            this.canaryExUpdateButton.TabIndex = 9;
            this.canaryExUpdateButton.Text = "Update";
            this.canaryExUpdateButton.UseVisualStyleBackColor = true;
            this.canaryExUpdateButton.Click += new System.EventHandler(this.updateEx_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(42, 123);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(82, 23);
            this.settingsButton.TabIndex = 16;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(130, 123);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(82, 23);
            this.infoButton.TabIndex = 12;
            this.infoButton.Text = "Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 163);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.canaryExUpdateButton);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.canaryUpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masterUpdateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Xenia Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button masterUpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button canaryUpdateButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button canaryExUpdateButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button infoButton;
    }
}

