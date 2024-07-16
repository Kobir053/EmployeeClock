namespace EmployeeClock
{
    partial class PasswordChangeForm
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
            button_Change_ChangeMyPassword = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel_ = new LinkLabel();
            textBox_Change_ID = new TextBox();
            textBox_Change_Password = new TextBox();
            textBox_Change_NewPassword = new TextBox();
            textBox_Change_VerifyNewPassword = new TextBox();
            SuspendLayout();
            // 
            // button_Change_ChangeMyPassword
            // 
            button_Change_ChangeMyPassword.Location = new Point(483, 350);
            button_Change_ChangeMyPassword.Name = "button_Change_ChangeMyPassword";
            button_Change_ChangeMyPassword.Size = new Size(158, 37);
            button_Change_ChangeMyPassword.TabIndex = 0;
            button_Change_ChangeMyPassword.Text = "Change Password";
            button_Change_ChangeMyPassword.UseVisualStyleBackColor = true;
            button_Change_ChangeMyPassword.Click += button_Change_ChangeMyPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 90);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 156);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 225);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 3;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 298);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 4;
            label4.Text = "Verify New Password";
            // 
            // linkLabel_
            // 
            linkLabel_.AutoSize = true;
            linkLabel_.Location = new Point(219, 367);
            linkLabel_.Name = "linkLabel_";
            linkLabel_.Size = new Size(53, 20);
            linkLabel_.TabIndex = 5;
            linkLabel_.TabStop = true;
            linkLabel_.Text = "Cancel";
            linkLabel_.LinkClicked += linkLabel__LinkClicked;
            // 
            // textBox_Change_ID
            // 
            textBox_Change_ID.Location = new Point(483, 83);
            textBox_Change_ID.Name = "textBox_Change_ID";
            textBox_Change_ID.Size = new Size(158, 27);
            textBox_Change_ID.TabIndex = 6;
            // 
            // textBox_Change_Password
            // 
            textBox_Change_Password.Location = new Point(483, 149);
            textBox_Change_Password.Name = "textBox_Change_Password";
            textBox_Change_Password.Size = new Size(158, 27);
            textBox_Change_Password.TabIndex = 7;
            // 
            // textBox_Change_NewPassword
            // 
            textBox_Change_NewPassword.Location = new Point(483, 218);
            textBox_Change_NewPassword.Name = "textBox_Change_NewPassword";
            textBox_Change_NewPassword.Size = new Size(158, 27);
            textBox_Change_NewPassword.TabIndex = 8;
            // 
            // textBox_Change_VerifyNewPassword
            // 
            textBox_Change_VerifyNewPassword.Location = new Point(483, 291);
            textBox_Change_VerifyNewPassword.Name = "textBox_Change_VerifyNewPassword";
            textBox_Change_VerifyNewPassword.Size = new Size(158, 27);
            textBox_Change_VerifyNewPassword.TabIndex = 9;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Change_VerifyNewPassword);
            Controls.Add(textBox_Change_NewPassword);
            Controls.Add(textBox_Change_Password);
            Controls.Add(textBox_Change_ID);
            Controls.Add(linkLabel_);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Change_ChangeMyPassword);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            FormClosed += PasswordChangeForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Change_ChangeMyPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel_;
        private TextBox textBox_Change_ID;
        private TextBox textBox_Change_Password;
        private TextBox textBox_Change_NewPassword;
        private TextBox textBox_Change_VerifyNewPassword;
    }
}