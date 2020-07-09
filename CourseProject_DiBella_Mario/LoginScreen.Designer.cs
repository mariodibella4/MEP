namespace FinalProjectMEP
{
    partial class LoginScreen
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(344, 122);
            // 
            // acronym
            // 
            this.acronym.Location = new System.Drawing.Point(340, 89);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(350, 70);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameTextBox.Location = new System.Drawing.Point(335, 157);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTextBox.Location = new System.Drawing.Point(335, 193);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(151, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(335, 237);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(151, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "LoginScreen";
            this.Text = "We make it easier to connect with employees.";
            this.Controls.SetChildIndex(this.userNameTextBox, 0);
            this.Controls.SetChildIndex(this.passwordTextBox, 0);
            this.Controls.SetChildIndex(this.loginButton, 0);
            this.Controls.SetChildIndex(this.acronym, 0);
            this.Controls.SetChildIndex(this.companyName, 0);
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox userNameTextBox;
        protected System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
    }
}

