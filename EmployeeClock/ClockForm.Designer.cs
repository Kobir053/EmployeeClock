namespace EmployeeClock
{
    partial class ClockForm
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
            label1 = new Label();
            label_ClockEmployeeID = new Label();
            label3 = new Label();
            label_ClockLastRelease = new Label();
            label5 = new Label();
            label_ClockLastEntry = new Label();
            linkLabel_ClockCancel = new LinkLabel();
            button_ClockEnter = new Button();
            button_ClockRelease = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 63);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Identity:";
            // 
            // label_ClockEmployeeID
            // 
            label_ClockEmployeeID.AutoSize = true;
            label_ClockEmployeeID.BackColor = Color.LightGreen;
            label_ClockEmployeeID.Location = new Point(456, 63);
            label_ClockEmployeeID.Name = "label_ClockEmployeeID";
            label_ClockEmployeeID.Size = new Size(94, 20);
            label_ClockEmployeeID.TabIndex = 1;
            label_ClockEmployeeID.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 98);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Last entry:";
            // 
            // label_ClockLastRelease
            // 
            label_ClockLastRelease.AutoSize = true;
            label_ClockLastRelease.BackColor = Color.IndianRed;
            label_ClockLastRelease.Location = new Point(335, 225);
            label_ClockLastRelease.Name = "label_ClockLastRelease";
            label_ClockLastRelease.Size = new Size(146, 20);
            label_ClockLastRelease.TabIndex = 3;
            label_ClockLastRelease.Text = "Date of last release...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 178);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Last release:";
            // 
            // label_ClockLastEntry
            // 
            label_ClockLastEntry.AutoSize = true;
            label_ClockLastEntry.BackColor = Color.LightGreen;
            label_ClockLastEntry.Location = new Point(335, 138);
            label_ClockLastEntry.Name = "label_ClockLastEntry";
            label_ClockLastEntry.Size = new Size(115, 20);
            label_ClockLastEntry.TabIndex = 5;
            label_ClockLastEntry.Text = "Last entry date...";
            // 
            // linkLabel_ClockCancel
            // 
            linkLabel_ClockCancel.AutoSize = true;
            linkLabel_ClockCancel.Location = new Point(363, 291);
            linkLabel_ClockCancel.Name = "linkLabel_ClockCancel";
            linkLabel_ClockCancel.Size = new Size(53, 20);
            linkLabel_ClockCancel.TabIndex = 6;
            linkLabel_ClockCancel.TabStop = true;
            linkLabel_ClockCancel.Text = "Cancel";
            linkLabel_ClockCancel.LinkClicked += linkLabel_ClockCancel_LinkClicked;
            // 
            // button_ClockEnter
            // 
            button_ClockEnter.BackColor = Color.LightGreen;
            button_ClockEnter.Location = new Point(38, 320);
            button_ClockEnter.Name = "button_ClockEnter";
            button_ClockEnter.Size = new Size(94, 66);
            button_ClockEnter.TabIndex = 7;
            button_ClockEnter.Text = "Enter";
            button_ClockEnter.UseVisualStyleBackColor = false;
            button_ClockEnter.Click += button_ClockEnter_Click;
            // 
            // button_ClockRelease
            // 
            button_ClockRelease.BackColor = Color.IndianRed;
            button_ClockRelease.Location = new Point(662, 320);
            button_ClockRelease.Name = "button_ClockRelease";
            button_ClockRelease.Size = new Size(94, 74);
            button_ClockRelease.TabIndex = 8;
            button_ClockRelease.Text = "Release";
            button_ClockRelease.UseVisualStyleBackColor = false;
            button_ClockRelease.Click += button_ClockRelease_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_ClockRelease);
            Controls.Add(button_ClockEnter);
            Controls.Add(linkLabel_ClockCancel);
            Controls.Add(label_ClockLastEntry);
            Controls.Add(label5);
            Controls.Add(label_ClockLastRelease);
            Controls.Add(label3);
            Controls.Add(label_ClockEmployeeID);
            Controls.Add(label1);
            Name = "ClockForm";
            Text = "ClockForm";
            FormClosed += ClockForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_ClockEmployeeID;
        private Label label3;
        private Label label_ClockLastRelease;
        private Label label5;
        private Label label_ClockLastEntry;
        private LinkLabel linkLabel_ClockCancel;
        private Button button_ClockEnter;
        private Button button_ClockRelease;
    }
}