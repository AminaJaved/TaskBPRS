namespace TBP
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
            this.label3 = new System.Windows.Forms.Label();
            this.textAns = new System.Windows.Forms.TextBox();
            this.Secret = new System.Windows.Forms.Label();
            this.combo_Q = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSignup = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Answer";
            // 
            // textAns
            // 
            this.textAns.Location = new System.Drawing.Point(198, 209);
            this.textAns.Name = "textAns";
            this.textAns.Size = new System.Drawing.Size(113, 20);
            this.textAns.TabIndex = 41;
            // 
            // Secret
            // 
            this.Secret.AutoSize = true;
            this.Secret.Location = new System.Drawing.Point(71, 158);
            this.Secret.Name = "Secret";
            this.Secret.Size = new System.Drawing.Size(83, 13);
            this.Secret.TabIndex = 40;
            this.Secret.Text = "Secret Question";
            // 
            // combo_Q
            // 
            this.combo_Q.FormattingEnabled = true;
            this.combo_Q.Items.AddRange(new object[] {
            "What\'s your favourite dish?",
            "What\'s your fav color?",
            "What\'s your dream?",
            "why you join CS?"});
            this.combo_Q.Location = new System.Drawing.Point(200, 150);
            this.combo_Q.Name = "combo_Q";
            this.combo_Q.Size = new System.Drawing.Size(113, 21);
            this.combo_Q.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "UserName";
            // 
            // cmdSignup
            // 
            this.cmdSignup.BackColor = System.Drawing.Color.PaleGreen;
            this.cmdSignup.Location = new System.Drawing.Point(178, 284);
            this.cmdSignup.Name = "cmdSignup";
            this.cmdSignup.Size = new System.Drawing.Size(169, 27);
            this.cmdSignup.TabIndex = 35;
            this.cmdSignup.Text = "SignUp";
            this.cmdSignup.UseVisualStyleBackColor = false;
            this.cmdSignup.Click += new System.EventHandler(this.cmdSignup_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(198, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(117, 20);
            this.txtUserName.TabIndex = 34;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(74, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 350);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAns);
            this.Controls.Add(this.Secret);
            this.Controls.Add(this.combo_Q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSignup);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAns;
        private System.Windows.Forms.Label Secret;
        private System.Windows.Forms.ComboBox combo_Q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSignup;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

