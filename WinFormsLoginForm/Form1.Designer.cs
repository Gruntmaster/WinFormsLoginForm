namespace WinFormsLoginForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            buttonLogin = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(groupBox2);
            panel.Controls.Add(groupBox1);
            panel.Controls.Add(buttonLogin);
            panel.Location = new Point(12, 12);
            panel.Name = "panel";
            panel.Size = new Size(360, 334);
            panel.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(6, 22);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(258, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(6, 22);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(258, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(113, 237);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(107, 40);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Location = new Point(38, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 54);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxPassword);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(38, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 60);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 353);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            panel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
