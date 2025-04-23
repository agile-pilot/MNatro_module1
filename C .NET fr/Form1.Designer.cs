namespace C.NET_fr
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
            this.buttonGreet = new System.Windows.Forms.Button();
            this.labelGreetingOutput = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.greeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGreet
            // 
            this.buttonGreet.Location = new System.Drawing.Point(523, 140);
            this.buttonGreet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGreet.Name = "buttonGreet";
            this.buttonGreet.Size = new System.Drawing.Size(100, 28);
            this.buttonGreet.TabIndex = 0;
            this.buttonGreet.Text = "ok";
            this.buttonGreet.UseVisualStyleBackColor = true;
            this.buttonGreet.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGreetingOutput
            // 
            this.labelGreetingOutput.AutoSize = true;
            this.labelGreetingOutput.Location = new System.Drawing.Point(600, 38);
            this.labelGreetingOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGreetingOutput.Name = "labelGreetingOutput";
            this.labelGreetingOutput.Size = new System.Drawing.Size(59, 16);
            this.labelGreetingOutput.TabIndex = 1;
            this.labelGreetingOutput.Text = "user see";
            this.labelGreetingOutput.Click += new System.EventHandler(this.text_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.Location = new System.Drawing.Point(523, 108);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(132, 22);
            this.textboxUsername.TabIndex = 2;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Location = new System.Drawing.Point(519, 38);
            this.greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(59, 16);
            this.greeting.TabIndex = 3;
            this.greeting.Text = "greeting:";
            this.greeting.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.labelGreetingOutput);
            this.Controls.Add(this.buttonGreet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGreet;
        private System.Windows.Forms.Label labelGreetingOutput;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.Label greeting;
    }
}

