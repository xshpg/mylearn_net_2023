namespace WindowsFormshello12
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
            this.textBoxshowhello12 = new System.Windows.Forms.TextBox();
            this.buttonclicksayhello12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxshowhello12
            // 
            this.textBoxshowhello12.Location = new System.Drawing.Point(32, 13);
            this.textBoxshowhello12.Name = "textBoxshowhello12";
            this.textBoxshowhello12.Size = new System.Drawing.Size(205, 25);
            this.textBoxshowhello12.TabIndex = 0;
            // 
            // buttonclicksayhello12
            // 
            this.buttonclicksayhello12.Location = new System.Drawing.Point(32, 73);
            this.buttonclicksayhello12.Name = "buttonclicksayhello12";
            this.buttonclicksayhello12.Size = new System.Drawing.Size(205, 23);
            this.buttonclicksayhello12.TabIndex = 1;
            this.buttonclicksayhello12.Text = "clickme12";
            this.buttonclicksayhello12.UseVisualStyleBackColor = true;
            this.buttonclicksayhello12.Click += new System.EventHandler(this.buttonclicksayhello12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonclicksayhello12);
            this.Controls.Add(this.textBoxshowhello12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxshowhello12;
        private System.Windows.Forms.Button buttonclicksayhello12;
    }
}

