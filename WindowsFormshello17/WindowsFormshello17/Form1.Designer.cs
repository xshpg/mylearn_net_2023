namespace WindowsFormshello17
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
            this.textBoxshowsayhello17 = new System.Windows.Forms.TextBox();
            this.buttonclicksayhello17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxshowsayhello17
            // 
            this.textBoxshowsayhello17.Location = new System.Drawing.Point(36, 27);
            this.textBoxshowsayhello17.Name = "textBoxshowsayhello17";
            this.textBoxshowsayhello17.Size = new System.Drawing.Size(234, 25);
            this.textBoxshowsayhello17.TabIndex = 0;
            // 
            // buttonclicksayhello17
            // 
            this.buttonclicksayhello17.Location = new System.Drawing.Point(36, 90);
            this.buttonclicksayhello17.Name = "buttonclicksayhello17";
            this.buttonclicksayhello17.Size = new System.Drawing.Size(234, 23);
            this.buttonclicksayhello17.TabIndex = 1;
            this.buttonclicksayhello17.Text = "clickme17sayhello";
            this.buttonclicksayhello17.UseVisualStyleBackColor = true;
            this.buttonclicksayhello17.Click += new System.EventHandler(this.buttonclicksayhello17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonclicksayhello17);
            this.Controls.Add(this.textBoxshowsayhello17);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxshowsayhello17;
        private System.Windows.Forms.Button buttonclicksayhello17;
    }
}

