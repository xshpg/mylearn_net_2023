namespace WindowsFormshello16
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
            this.textBoxshowhello16 = new System.Windows.Forms.TextBox();
            this.buttonclike16hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxshowhello16
            // 
            this.textBoxshowhello16.Location = new System.Drawing.Point(37, 24);
            this.textBoxshowhello16.Name = "textBoxshowhello16";
            this.textBoxshowhello16.Size = new System.Drawing.Size(214, 25);
            this.textBoxshowhello16.TabIndex = 0;
            // 
            // buttonclike16hello
            // 
            this.buttonclike16hello.Location = new System.Drawing.Point(37, 86);
            this.buttonclike16hello.Name = "buttonclike16hello";
            this.buttonclike16hello.Size = new System.Drawing.Size(214, 23);
            this.buttonclike16hello.TabIndex = 1;
            this.buttonclike16hello.Text = "clickme16sayhello";
            this.buttonclike16hello.UseVisualStyleBackColor = true;
            this.buttonclike16hello.Click += new System.EventHandler(this.buttonclike16hello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonclike16hello);
            this.Controls.Add(this.textBoxshowhello16);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxshowhello16;
        private System.Windows.Forms.Button buttonclike16hello;
    }
}

