namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.login_userText = new System.Windows.Forms.TextBox();
            this.login_passText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_submit = new System.Windows.Forms.Button();
            this.login_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_userText
            // 
            this.login_userText.Location = new System.Drawing.Point(73, 12);
            this.login_userText.Name = "login_userText";
            this.login_userText.Size = new System.Drawing.Size(147, 20);
            this.login_userText.TabIndex = 0;
            this.login_userText.TextChanged += new System.EventHandler(this.login_userText_TextChanged);
            // 
            // login_passText
            // 
            this.login_passText.AcceptsReturn = true;
            this.login_passText.Location = new System.Drawing.Point(73, 41);
            this.login_passText.Name = "login_passText";
            this.login_passText.PasswordChar = '*';
            this.login_passText.Size = new System.Drawing.Size(147, 20);
            this.login_passText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // login_submit
            // 
            this.login_submit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.login_submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_submit.Location = new System.Drawing.Point(145, 82);
            this.login_submit.Name = "login_submit";
            this.login_submit.Size = new System.Drawing.Size(75, 23);
            this.login_submit.TabIndex = 5;
            this.login_submit.Text = "Login";
            this.login_submit.UseVisualStyleBackColor = false;
            this.login_submit.Click += new System.EventHandler(this.login_submit_Click);
            // 
            // login_cancel
            // 
            this.login_cancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.login_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_cancel.Location = new System.Drawing.Point(15, 82);
            this.login_cancel.Name = "login_cancel";
            this.login_cancel.Size = new System.Drawing.Size(75, 23);
            this.login_cancel.TabIndex = 6;
            this.login_cancel.Text = "Cancel";
            this.login_cancel.UseVisualStyleBackColor = false;
            this.login_cancel.Click += new System.EventHandler(this.login_cancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 117);
            this.Controls.Add(this.login_cancel);
            this.Controls.Add(this.login_submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_passText);
            this.Controls.Add(this.login_userText);
            this.Name = "Form3";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_userText;
        private System.Windows.Forms.TextBox login_passText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_submit;
        private System.Windows.Forms.Button login_cancel;
    }
}