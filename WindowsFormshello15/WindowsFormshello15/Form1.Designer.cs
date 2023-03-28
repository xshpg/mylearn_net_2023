namespace WindowsFormshello15
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
            this.textBoxshowsayhello15 = new System.Windows.Forms.TextBox();
            this.buttonclicksayhello15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxshowsayhello15
            // 
            this.textBoxshowsayhello15.Location = new System.Drawing.Point(25, 25);
            this.textBoxshowsayhello15.Name = "textBoxshowsayhello15";
            this.textBoxshowsayhello15.Size = new System.Drawing.Size(245, 25);
            this.textBoxshowsayhello15.TabIndex = 0;
            // 
            // buttonclicksayhello15
            // 
            this.buttonclicksayhello15.Location = new System.Drawing.Point(25, 71);
            this.buttonclicksayhello15.Name = "buttonclicksayhello15";
            this.buttonclicksayhello15.Size = new System.Drawing.Size(245, 39);
            this.buttonclicksayhello15.TabIndex = 1;
            this.buttonclicksayhello15.Text = "clickmesayhello15";
            this.buttonclicksayhello15.UseVisualStyleBackColor = true;
            this.buttonclicksayhello15.Click += new System.EventHandler(this.buttonclicksayhello15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonclicksayhello15);
            this.Controls.Add(this.textBoxshowsayhello15);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxshowsayhello15;
        private System.Windows.Forms.Button buttonclicksayhello15;
    }
}

