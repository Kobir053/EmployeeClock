namespace EmployeeClock
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            button_LoginEnter = new Button();
            button_LoginChangePassword = new Button();
            textBox_LoginID = new TextBox();
            textBox_LoginPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 97);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 173);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button_LoginEnter
            // 
            button_LoginEnter.Location = new Point(351, 293);
            button_LoginEnter.Name = "button_LoginEnter";
            button_LoginEnter.Size = new Size(185, 45);
            button_LoginEnter.TabIndex = 4;
            button_LoginEnter.Text = "Sign in";
            button_LoginEnter.UseVisualStyleBackColor = true;
            button_LoginEnter.Click += button_LoginEnter_Click;
            // 
            // button_LoginChangePassword
            // 
            button_LoginChangePassword.Location = new Point(351, 358);
            button_LoginChangePassword.Name = "button_LoginChangePassword";
            button_LoginChangePassword.Size = new Size(185, 47);
            button_LoginChangePassword.TabIndex = 5;
            button_LoginChangePassword.Text = "Change password";
            button_LoginChangePassword.UseVisualStyleBackColor = true;
            button_LoginChangePassword.Click += button_LoginChangePassword_Click;
            // 
            // textBox_LoginID
            // 
            textBox_LoginID.Location = new Point(351, 120);
            textBox_LoginID.Name = "textBox_LoginID";
            textBox_LoginID.Size = new Size(185, 27);
            textBox_LoginID.TabIndex = 6;
            // 
            // textBox_LoginPassword
            // 
            textBox_LoginPassword.Location = new Point(351, 196);
            textBox_LoginPassword.Name = "textBox_LoginPassword";
            textBox_LoginPassword.Size = new Size(185, 27);
            textBox_LoginPassword.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_LoginPassword);
            Controls.Add(textBox_LoginID);
            Controls.Add(button_LoginChangePassword);
            Controls.Add(button_LoginEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_LoginEnter;
        private Button button_LoginChangePassword;
        private TextBox textBox_LoginID;
        private TextBox textBox_LoginPassword;
    }
}
