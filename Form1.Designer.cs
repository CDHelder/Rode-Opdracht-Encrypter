namespace Rode_Opdracht_Encrypter
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
            this.label1 = new System.Windows.Forms.Label();
            this.filepathTextbox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.encryptFunction = new System.Windows.Forms.RadioButton();
            this.decryptFunction = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path";
            // 
            // filepathTextbox
            // 
            this.filepathTextbox.Location = new System.Drawing.Point(13, 30);
            this.filepathTextbox.Name = "filepathTextbox";
            this.filepathTextbox.ReadOnly = true;
            this.filepathTextbox.Size = new System.Drawing.Size(325, 20);
            this.filepathTextbox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(344, 27);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // encryptFunction
            // 
            this.encryptFunction.AutoSize = true;
            this.encryptFunction.Location = new System.Drawing.Point(13, 57);
            this.encryptFunction.Name = "encryptFunction";
            this.encryptFunction.Size = new System.Drawing.Size(61, 17);
            this.encryptFunction.TabIndex = 3;
            this.encryptFunction.TabStop = true;
            this.encryptFunction.Text = "Encrypt";
            this.encryptFunction.UseVisualStyleBackColor = true;
            this.encryptFunction.CheckedChanged += new System.EventHandler(this.encryptFunction_CheckedChanged);
            // 
            // decryptFunction
            // 
            this.decryptFunction.AutoSize = true;
            this.decryptFunction.Location = new System.Drawing.Point(81, 57);
            this.decryptFunction.Name = "decryptFunction";
            this.decryptFunction.Size = new System.Drawing.Size(62, 17);
            this.decryptFunction.TabIndex = 4;
            this.decryptFunction.TabStop = true;
            this.decryptFunction.Text = "Decrypt";
            this.decryptFunction.UseVisualStyleBackColor = true;
            this.decryptFunction.CheckedChanged += new System.EventHandler(this.decryptFunction_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(81, 81);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(257, 20);
            this.passwordTextbox.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 107);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(325, 38);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.Location = new System.Drawing.Point(344, 79);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.showPasswordButton.TabIndex = 8;
            this.showPasswordButton.Text = "Show";
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 160);
            this.Controls.Add(this.showPasswordButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptFunction);
            this.Controls.Add(this.encryptFunction);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filepathTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filepathTextbox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.RadioButton encryptFunction;
        private System.Windows.Forms.RadioButton decryptFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button showPasswordButton;
    }
}

