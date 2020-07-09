namespace FinalProjectMEP
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.meetingWorkerButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(564, 364);
            // 
            // acronym
            // 
            this.acronym.Location = new System.Drawing.Point(560, 331);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(571, 312);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(3, 166);
            this.profilePictureBox.MaximumSize = new System.Drawing.Size(160, 184);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(160, 184);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // thumbnail
            // 
            this.thumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thumbnail.Image = ((System.Drawing.Image)(resources.GetObject("thumbnail.Image")));
            this.thumbnail.Location = new System.Drawing.Point(3, 3);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(144, 157);
            this.thumbnail.TabIndex = 1;
            this.thumbnail.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Controls.Add(this.thumbnail);
            this.flowLayoutPanel1.Controls.Add(this.profilePictureBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(59, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 218);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            this.flowLayoutPanel1.DragLeave += new System.EventHandler(this.flowLayoutPanel1_DragLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(314, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(521, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // meetingWorkerButton
            // 
            this.meetingWorkerButton.Location = new System.Drawing.Point(293, 234);
            this.meetingWorkerButton.Name = "meetingWorkerButton";
            this.meetingWorkerButton.Size = new System.Drawing.Size(176, 53);
            this.meetingWorkerButton.TabIndex = 7;
            this.meetingWorkerButton.Text = "Meeting with Team Player?";
            this.meetingWorkerButton.UseVisualStyleBackColor = true;
            this.meetingWorkerButton.Click += new System.EventHandler(this.meetingWorkerButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.userNameLabel.Location = new System.Drawing.Point(293, 86);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(176, 34);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "label2";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Profile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.meetingWorkerButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.meetingWorkerButton, 0);
            this.Controls.SetChildIndex(this.acronym, 0);
            this.Controls.SetChildIndex(this.companyName, 0);
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.Controls.SetChildIndex(this.userNameLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button meetingWorkerButton;
        protected internal System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}