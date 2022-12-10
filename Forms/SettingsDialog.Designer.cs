namespace XeniaUpdater.Forms
{
    partial class SettingsDialog
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
            this.xeniaMasterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xeniaCanaryPRTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xeniaCanaryExTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xeniaMasterTextBox
            // 
            this.xeniaMasterTextBox.Location = new System.Drawing.Point(12, 29);
            this.xeniaMasterTextBox.Name = "xeniaMasterTextBox";
            this.xeniaMasterTextBox.Size = new System.Drawing.Size(334, 20);
            this.xeniaMasterTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xenia Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xenia Canary";
            // 
            // xeniaCanaryPRTextBox
            // 
            this.xeniaCanaryPRTextBox.Location = new System.Drawing.Point(12, 72);
            this.xeniaCanaryPRTextBox.Name = "xeniaCanaryPRTextBox";
            this.xeniaCanaryPRTextBox.Size = new System.Drawing.Size(334, 20);
            this.xeniaCanaryPRTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xenia Canary Ex";
            // 
            // xeniaCanaryExTextBox
            // 
            this.xeniaCanaryExTextBox.Location = new System.Drawing.Point(12, 111);
            this.xeniaCanaryExTextBox.Name = "xeniaCanaryExTextBox";
            this.xeniaCanaryExTextBox.Size = new System.Drawing.Size(334, 20);
            this.xeniaCanaryExTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 155);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(164, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(182, 155);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(164, 23);
            this.saveAndExitButton.TabIndex = 7;
            this.saveAndExitButton.Text = "Save and Exit";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 190);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.xeniaCanaryExTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xeniaCanaryPRTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xeniaMasterTextBox);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xeniaMasterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xeniaCanaryPRTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xeniaCanaryExTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndExitButton;
    }
}