namespace WindowsFormshello13
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
            this.textBoxshowhello13 = new System.Windows.Forms.TextBox();
            this.buttonclicksayhello13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxshowhello13
            // 
            this.textBoxshowhello13.Location = new System.Drawing.Point(26, 25);
            this.textBoxshowhello13.Name = "textBoxshowhello13";
            this.textBoxshowhello13.Size = new System.Drawing.Size(221, 25);
            this.textBoxshowhello13.TabIndex = 0;
            // 
            // buttonclicksayhello13
            // 
            this.buttonclicksayhello13.Location = new System.Drawing.Point(26, 75);
            this.buttonclicksayhello13.Name = "buttonclicksayhello13";
            this.buttonclicksayhello13.Size = new System.Drawing.Size(221, 37);
            this.buttonclicksayhello13.TabIndex = 1;
            this.buttonclicksayhello13.Text = "clickme13sayhello";
            this.buttonclicksayhello13.UseVisualStyleBackColor = true;
            this.buttonclicksayhello13.Click += new System.EventHandler(this.buttonclicksayhello13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonclicksayhello13);
            this.Controls.Add(this.textBoxshowhello13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxshowhello13;
        private System.Windows.Forms.Button buttonclicksayhello13;
    }
}

